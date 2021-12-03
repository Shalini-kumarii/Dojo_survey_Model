using Microsoft.AspNetCore.Mvc;

using Dojosurvey_Model.Models;
namespace Dojosurvey_Model.Controllers     //be sure to use your own project's namespace!
{
    public class DojoController : Controller   //remember inheritance??
    {
        [HttpGet("")]      // Both lines can be written in one line
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult FormProcess(Dojo result)
        {
            return View("result",result);
        }
        [HttpPost]
        [Route("back")]
        public IActionResult back()
        {
            return RedirectToAction("Index");
        }

    }
}

