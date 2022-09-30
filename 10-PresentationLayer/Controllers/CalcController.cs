using _10_ThreeLayerProject.BLL;
using Microsoft.AspNetCore.Mvc;

namespace _10_ThreeLayerProject.PL.Controllers
{
    public class CalcController : Controller
    {
        private readonly ICalcService calcService;
        public CalcController(ICalcService calcService)
        {
            this.calcService = calcService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int firstNumber, int secondNumber, string operation)
        {
            int result;
            switch (operation)
            {
                case "+":
                    {
                        result = calcService.Add(firstNumber, secondNumber);
                        break;
                    }
                case "-":
                    {
                        result = calcService.Substract(firstNumber, secondNumber);
                        break;
                    }
                case "*":
                    {
                        result = calcService.Multiply(firstNumber, secondNumber);
                        break;
                    }
                case "/":
                    {
                        result = calcService.Divide(firstNumber, secondNumber);
                        break;
                    }
                default:
                    {
                        result = 0;
                        break;
                    }
            }
            ViewData["result"] = result;
            return PartialView();
        }
    }
}
