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
        public IActionResult Index(ParentSearchForm searchModel, int pageSize = 1, int pageIndex = 1)
        {
            ViewBag.PageSize = pageSize;
            var data = _formService.GetParentList(searchModel, pageSize, pageIndex);
         
            ViewBag.SearchModel = searchModel;

            // generate dictionary for route
            var values = searchModel.GetType()
                .GetProperties().ToDictionary(p => p.Name, p => p.GetValue(searchModel)?.ToString());
            string value;
            bool a = values.TryGetValue("PageIndex", out value);
            pageIndex=Convert.ToInt32(value);
            ViewBag.Values = values;
            return View(data);
        }
        public IActionResult PrintAgreement(int id)
        {


            var data = _formService.GetById(id);
            return View(data);
        }

    }
}
