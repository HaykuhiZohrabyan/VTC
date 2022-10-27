using Microsoft.AspNetCore.Mvc;
using VTC.Application.Services.Interfaces;

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
