using Microsoft.AspNetCore.Mvc;
using VTC.Application.ViewModels;
using VTC.Application.Services.Interfaces;
using VTC.Data.Enums;
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
            PackageVM model = id.HasValue ? _packageService.GetById(id.Value) : new PackageVM(0,null);
            return PartialView("_AddEdit",model);
        }

        [HttpPost]
        public IActionResult AddEdit(PackageVM model)
        {
            if(model.Id ==0)
            {
                _packageService.Add(model);
            }
            else
            {
                _packageService.Update(model);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ChangeStatus(int packageId,EntityStatus entityStatus)
        {
            var package = _packageService.GetById(packageId);
            ViewBag.PackageStatus = entityStatus;
            return PartialView("_ChangeStatus",package);
        }
        [HttpPost]
        [ActionName("ChangeStatus")]
        public IActionResult ChangeStatusPost(int Id, EntityStatus EntityStatus)
        {
            _packageService.UpdateStatus(Id, EntityStatus);
            return RedirectToAction("Index");
        }

    }
}
