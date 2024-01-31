using AncientPoetry.Entities;
using AncientPoetry.IRepository.BaseFiles;
using Microsoft.AspNetCore.Mvc;

namespace AncientPoetry.Web.Controllers
{
    /// <summary>
    /// 诗歌控制器
    /// </summary>
    public class PoemController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PoemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var poem = _unitOfWork.Poem.GetAll();
            return View(poem);
        }

        #region 创建

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Poem poem)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Poem.Add(poem);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        #endregion

        #region 编辑

        public IActionResult Edit(int id)
        {
            Poem? poem = _unitOfWork.Poem.Get(u => u.Id == id);
            if (poem == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(poem);
        }

        [HttpPost]
        public IActionResult Edit(Poem poem)
        {
            if (ModelState.IsValid && poem.Id > 0)
            {
                _unitOfWork.Poem.Update(poem);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        #endregion


    }
}
