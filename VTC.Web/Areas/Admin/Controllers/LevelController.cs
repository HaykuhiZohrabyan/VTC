using Microsoft.AspNetCore.Mvc;
using VTC.Application.ViewModels;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels.Level;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq.Expressions;

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
            LevelAddEditVM level = levelId.HasValue ? _levelService.GetForEdit(levelId.Value) :new LevelAddEditVM();
            return PartialView("_AddEdit",level);
        }
        [HttpPost]
        public IActionResult AddEdit(LevelAddEditVM model)
        {
            if (model.Id == 0)
            {
            _levelService.Add(model);
            }
            else
            {
            _levelService.Update(model);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Detail(LevelInfoVM model)
        {
            var detail = _levelService.GetInfoById(model.Id);
            return View(detail);
        
        }

    }      
}
