using Microsoft.AspNetCore.Mvc;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
namespace VTC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubjectController : Controller
    {
        private readonly ISubjectService _subjectService;
        private readonly IPackageService _packageService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public SubjectController(ISubjectService subjectService, IPackageService packageService, IWebHostEnvironment webHostEnvironment)
        {
            _subjectService = subjectService;
            _packageService = packageService;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(int? levelId)
        {
            var data = _subjectService.GetAllSubject(levelId);

            return View(data);
        }

        [HttpGet]
        public IActionResult AddEdit(int? subjectId)
        {
            SubjectAddEditVM model = subjectId.HasValue ? _subjectService.GetForEdit(subjectId.Value) : new();
            ViewBag.Levels = _packageService.GetPackagesWithLevels();
            return PartialView("_AddEdit",model);
        }

        [HttpPost]
        public IActionResult AddEdit(SubjectAddEditVM model, IFormFile ImageFile)
        {
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int Id)
        { var subject = _subjectService.GetById(Id);
           // 
            return View(subject);
        }
    }
}
