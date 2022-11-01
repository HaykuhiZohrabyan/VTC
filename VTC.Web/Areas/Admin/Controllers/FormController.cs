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
        public IActionResult List(ParentListVM model, int pageSize = 10, int pageIndex = 1)
        {
            var data = _formService.GetParentList(model, pageSize, pageIndex);
            ViewBag.searchKeyword = model;
            ViewBag.PageCount = (int)Math.Ceiling((double)data.Item2 / pageSize);
            ViewBag.CurrentPage = pageIndex;
            return View(data.Item1);
        }


        public IActionResult Index()
        {

          
              var data=  _formService.GetParentAgreementList();
            return View(data);  
        }
        public IActionResult    PrintAgreement(int id)
        {


            var data = _formService.GetById(id);
            return View(data);
        }

    }
}
