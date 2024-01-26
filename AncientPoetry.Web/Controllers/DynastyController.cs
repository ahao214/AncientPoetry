using AncientPoetry.Entities;
using AncientPoetry.IRepository.BaseFiles;
using Microsoft.AspNetCore.Mvc;

namespace AncientPoetry.Web.Controllers
{
    /// <summary>
    /// 朝代
    /// </summary>
    public class DynastyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public DynastyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            var dynasties = _unitOfWork.Dynasty.GetAll();
            return View(dynasties);
        }

        #region 创建

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Dynasty dynasty)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Dynasty.Add(dynasty);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        #endregion

        #region 更新

        public IActionResult Update(int dynastyId)
        {
            Dynasty? dynasty = _unitOfWork.Dynasty.Get(u => u.Id == dynastyId);
            if (dynasty == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(dynasty);
        }

        [HttpPost]
        public IActionResult Update(Dynasty dynasty)
        {
            if (ModelState.IsValid && dynasty.Id > 0)
            {
                _unitOfWork.Dynasty.Update(dynasty);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        #endregion

        #region 删除

        public IActionResult Delete(int dynastyId)
        {
            Dynasty? dynasty = _unitOfWork.Dynasty.Get(u => u.Id == dynastyId);
            if (dynasty == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(dynasty);
        }

        [HttpPost]
        public IActionResult Delete(Dynasty dynasty)
        {
            Dynasty? objFromDb = _unitOfWork.Dynasty.Get(u => u.Id == dynasty.Id);
            if (objFromDb is not null)
            {
                _unitOfWork.Dynasty.Remove(objFromDb);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        #endregion

    }
}
