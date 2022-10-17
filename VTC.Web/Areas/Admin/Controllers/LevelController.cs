using Microsoft.AspNetCore.Mvc;
using VTC.Application.Services.Interfaces;
using 
namespace VTC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LevelController : Controller
    {
        private readonly ILevelService _levelService;
        private readonly IPackageService _packageService;
        public LevelController(ILevelService levelService, IPackageService packageService)
        {
            _levelService = levelService;
            _packageService = packageService;
        }
        public IActionResult Index(int? packageId)
        {
            ViewBag.Packages = _packageService.GetAllPackages();
            ViewBag.SelectedPackageId = packageId;
            var data = _levelService.GetAllLevels(packageId);
            return View(data);
        }
        public IActionResult AddEdit(int? levelId)
        {
            Leve
            return PartialView();
        }
    }
}
