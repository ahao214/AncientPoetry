using AncientPoetry.IRepository.BaseFiles;
using Microsoft.AspNetCore.Mvc;

namespace AncientPoetry.Web.Controllers
{
    /// <summary>
    /// 诗人控制器
    /// </summary>
    public class PoetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PoetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public IActionResult Index()
        {
            var poets = _unitOfWork.Poet.GetAll();
            return View(poets);
        }



    }
}
