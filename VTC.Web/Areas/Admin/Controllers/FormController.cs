using Microsoft.AspNetCore.Mvc;
using VTC.Application.Services.Interfaces;
using VTC.Application.ViewModels;

namespace VTC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FormController : Controller
    {
        private readonly IFormService _formService;
        public FormController(IFormService formService)
        {
                _formService = formService;
        }
        [HttpGet]
        public IActionResult Index(ParentListVM model, int pageSize = 10, int pageIndex = 1)
        {
            ViewBag.PageSize = pageSize;
            var data = _formService.GetParentList(model, pageSize, pageIndex);
         
            ViewBag.searchKeyword = model;

            // generate dictionary for route
            var values = model.GetType()
                .GetProperties().ToDictionary(p=>p.Name,p=>p.GetValue(model)?.ToString());
            ViewBag.values = values;
            return View(data);
        }
        public IActionResult PrintAgreement(int id)
        {


            var data = _formService.GetById(id);
            return View(data);
        }

    }
}
