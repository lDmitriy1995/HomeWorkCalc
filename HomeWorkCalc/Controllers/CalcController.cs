using Microsoft.AspNetCore.Mvc;

namespace HomeWorkCalc.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Add(int num1, int num2)
        {
            int result = num1 + num2;
            return Content(result.ToString());
        }

        public IActionResult Mul(int num1, int num2)
        {
            int result = num1 * num2;
            return Content(result.ToString());
        }

        public IActionResult Div(int num1, int num2)
        {
            int result = num1 / num2;
            return Content(result.ToString());
        }

        public IActionResult Sub(int num1, int num2)
        {
            int result = num1 - num2;
            return Content(result.ToString());
        }
    }
}
