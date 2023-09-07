using dynamic_form.Data.Repository;
using dynamic_form.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dynamic_form.Controllers
{
    public class FormController : Controller
    {
        private readonly ILogger<FormController> _logger;

        private readonly IFieldRepository _fieldRepository;

        public FormController(ILogger<FormController> logger, IFieldRepository fieldRepository)
        {
            _logger = logger;
            _fieldRepository = fieldRepository;
        }

        public IActionResult Field()
        {
            return View();
        }

        public IActionResult Form()
        {
            FormViewModel objectForm = new FormViewModel();
            objectForm.components = _fieldRepository.FindAll().Result;
            return View(objectForm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}