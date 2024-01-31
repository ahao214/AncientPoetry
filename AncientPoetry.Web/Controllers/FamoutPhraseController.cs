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

        #endregion


        #region 编辑

        public IActionResult Edit()
        {
            return View();
        }

        #endregion


        #region 删除

        public IActionResult Delete()
        {
            return View();
        }

        #endregion

    }
}
