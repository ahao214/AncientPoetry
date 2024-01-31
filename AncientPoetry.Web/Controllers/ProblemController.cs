using AncientPoetry.IRepository.BaseFiles;
using Microsoft.AspNetCore.Mvc;

namespace AncientPoetry.Web.Controllers
{
    /// <summary>
    /// 问题控制器
    /// </summary>
    public class ProblemController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProblemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            var problem = _unitOfWork.Problem.GetAll();
            return View(problem);
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
