using System.Web.Mvc;
using RobertoWorldWebApp1.Models;

namespace RobertoWorldWebApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly CalculateSumOfTwoNumbersService _service;

        public HomeController() : this(new CalculateSumOfTwoNumbersService())
        {
        }

        private HomeController(CalculateSumOfTwoNumbersService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            return RedirectToAction("CalculateSumOfTwoNumbers");
        }

        public ActionResult CalculateSumOfTwoNumbers()
        {
            return View("CalculateSumOfTwoNumbersInput");
        }

        [HttpPost]
        public ActionResult CalculateSumOfTwoNumbers(SumOfTwoNumbers input)
        {
            var result = _service.Calculate(input);
            return View("CalculateSumOfTwoNumbersResult", result);
        }
    }
}