using AncientPoetry.IRepository.BaseFiles;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace AncientPoetry.Web.Controllers
{
    /// <summary>
    /// 问题类型控制器
    /// </summary>
    public class ProblemTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProblemTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            var problemType = _unitOfWork.ProblemType.GetAll();
            return View(problemType);
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
