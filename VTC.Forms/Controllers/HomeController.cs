using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VTC.Forms.Models;
using VTC.Application.ViewModels;
using VTC.Application.Services.Interfaces;

namespace VTC.Forms.Controllers
{
    public class HomeController : Controller
    {

        private readonly IFormService _formService;

        public HomeController(IFormService formService)
        {
            _formService = formService;
            
        }
       
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ParentAgreementVM model)
        {
           _formService.AddParentAgreement(model);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}