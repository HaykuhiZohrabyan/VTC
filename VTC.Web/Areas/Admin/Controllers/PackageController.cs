using Microsoft.AspNetCore.Mvc;
using VTC.Application.ViewModels;
using VTC.Application.Services.Interfaces;
namespace VTC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PackageController : Controller
    {
        private readonly IPackageService _packageService;
        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }
        public IActionResult Index()
        {
            var data = _packageService.GetAllPackages();
            return View(data);
        }

        [HttpGet]
        public IActionResult AddEdit(int? id)
        {
            return PartialView("_AddEdit");
        }
        [HttpPost]
        public IActionResult AddEdit(PackageVM model)
        {
            return View();
        }


    }
}
