using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    public class Multiplication : Controller
    {
        SimpleCalc calculator = new SimpleCalc();
        // GET api/values/5
        [HttpGet]
        public decimal Get([FromQuery] decimal leftNumber, [FromQuery] decimal rightNumber)
        {
            return calculator.OperatorSwitch(4M, 8M, "Multiplication");
        }

        // POST api/values
        [HttpPost]
        public decimal Post([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            return calculator.OperatorSwitch(3.25M, 7.25M, "Multiplication");
        }


        [HttpOptions]
        public string Options()
        {
            return "Get Method: This Method returns the Multiplication of leftNumber and rightNumber by using the FromQuery attributes\n" +
                "Post Method: This Method returns the Multiplication of leftNumber and rightNumber by using the FromForm attributes\n" +
                "An Example of Both Methods: Get Method will give 32 as result after Multiplication of (4M * 8M), Post Method will give  give 23.5625 as result after Multiplication of (3.25M * 7.25M)\n" +
                "The names of expected Varible are leftNumber and rightNumber";
        }

    }
}
