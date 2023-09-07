using dynamic_form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dynamic_form.Controllers
{
    public class FormController : Controller
    {
        private readonly ILogger<FormController> _logger;

        public FormController(ILogger<FormController> logger)
        {
            _logger = logger;
        }

        public IActionResult Insert()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View(new FormViewModel());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}