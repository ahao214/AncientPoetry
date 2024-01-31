using AncientPoetry.Entities;
using AncientPoetry.IRepository.BaseFiles;
using Microsoft.AspNetCore.Mvc;

namespace AncientPoetry.Web.Controllers
{
    /// <summary>
    /// 名句控制器
    /// </summary>
    public class FamoutPhraseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FamoutPhraseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            var famousPhrase = _unitOfWork.FamoutPhrase.GetAll();
            return View(famousPhrase);
        }

        #region 创建

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FamoutPhrase famoutPhrase)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.FamoutPhrase.Add(famoutPhrase);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        #endregion

        #region 编辑

        public IActionResult Edit(int famoutPhraseId)
        {
            FamoutPhrase? famoutPhrase = _unitOfWork.FamoutPhrase.Get(u => u.Id == famoutPhraseId);
            if (famoutPhrase == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(famoutPhrase);
        }

        [HttpPost]
        public IActionResult Edit(FamoutPhrase famoutPhrase)
        {
            if (ModelState.IsValid && famoutPhrase.Id > 0)
            {
                _unitOfWork.FamoutPhrase.Update(famoutPhrase);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        #endregion

        #region 删除

        public IActionResult Delete(int famoutPhraseId)
        {
            FamoutPhrase? famoutPhrase = _unitOfWork.FamoutPhrase.Get(u => u.Id == famoutPhraseId);
            if (famoutPhrase == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(famoutPhrase);
        }

        [HttpPost]
        public IActionResult Delete(FamoutPhrase famoutPhrase)
        {
            FamoutPhrase? objFromDb = _unitOfWork.FamoutPhrase.Get(u => u.Id == famoutPhrase.Id);
            if (objFromDb is not null)
            {
                _unitOfWork.FamoutPhrase.Remove(objFromDb);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        #endregion

    }
}
