using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorApplication.Models;
using CalculatorLibrary;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorApplication.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new Calculator());
        }

        [HttpPost]
        public ActionResult Index(Calculator cal, string final)
        {
            CalculatorLibrary.SimpleCalc calc = new SimpleCalc();
            cal.result = calc.OperatorSwitch(cal.firstNumber, cal.secondNumber, final);
            if (cal.result == decimal.MaxValue)
            {
                cal.message = "Cant Divide by zero";
            }

            /*
            cal.result = 0;
            switch (final)
            {
                case "Addition":
                    cal.result = cal.firstNumber + cal.secondNumber;
                    break;
                case "Subtraction":
                    cal.result = cal.firstNumber - cal.secondNumber;
                    break;
                case "Multiplication":
                    cal.result = cal.firstNumber * cal.secondNumber;
                    break;
                case "Division":
                    if (cal.secondNumber == 0)
                    {

                        cal.message = "Choose a valid number to divide ";
                    }
                    else
                    {
                        cal.result = cal.firstNumber / cal.secondNumber;
                    }
                    break;
                default:

                    break;
            }
            */
            return View(cal);
        }
    }
}
