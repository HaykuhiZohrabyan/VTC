using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;
using VTC.Application.Queries;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;
using VTC.Data;
using VTC.Data.Entities;

namespace VTC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LessonController : Controller
    {
        private readonly ILessonService _lessonService;
        private readonly VTCDataContext _context;
        public LessonController(ILessonService lessonService,VTCDataContext context)
        {
            _lessonService = lessonService;
            _context = context; 
        }

        [HttpGet]
        public IActionResult AddEdit(int? subjectId, int? lessonId)
        {


            LessonAddEditVM model = lessonId.HasValue ? _lessonService.GetForEdit(lessonId) : new();
            if(subjectId.HasValue)
            {
                model.SubjectId=subjectId.Value;    
            }
            return PartialView("AddEdit",model);
        }
        [HttpPost]
        public IActionResult AddEdit(LessonAddEditVM   model)
        {
          if(model.Id==0)
            {
           _lessonService.Add(model);

            } 
            else
            {
                _lessonService.Update(model);
            }
            return RedirectToAction("Index");   
        }
    
}
}
