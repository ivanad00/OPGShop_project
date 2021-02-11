using Microsoft.AspNetCore.Mvc;

namespace OPG.Controllers
{
    public class ContactController: Controller
    {
        public IActionResult Index ()
        {
            return View ();
        }
    }
}
