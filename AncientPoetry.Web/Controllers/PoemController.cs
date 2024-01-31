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
            return View();
        }
    }
}
