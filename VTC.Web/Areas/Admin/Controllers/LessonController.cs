using Microsoft.AspNetCore.Mvc;

namespace VTC.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LessonController : Controller
    {
        public IActionResult AddEdit(int? subjectId, int? lessonId)
        {
            return View();
        }
    }
}
