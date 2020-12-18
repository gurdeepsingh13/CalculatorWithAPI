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
    public class Addition : Controller
    {
        SimpleCalc calculator = new SimpleCalc();
        // GET api/values/5
        [HttpGet]
        public decimal Get([FromQuery] decimal leftNumber, [FromQuery] decimal rightNumber)
        {
            return calculator.OperatorSwitch(4.25M, 8.25M, "Addition");
        }

        // POST api/values
        [HttpPost]
        public decimal Post([FromForm] decimal leftNumber, [FromForm] decimal rightNumber)
        {
            return calculator.OperatorSwitch(3.25M, 7.25M, "Addition");
        }
      

        [HttpOptions]
        public string Options()
        {
            return "Get Method: This Method returns the addition of leftNumber and rightNumber by using the FromQuery attributes\n" +
                "Post Method: This Method returns the addition of leftNumber and rightNumber by using the FromForm attributes\n" +
                "An Example of Both Methods: Get Method will give 12.50 as result after addition of (4.25M + 8.25M), Post Method will give  give 10.50 as result after addition of (3.25M + 7.25M)\n" +
                "The names of expected Varible are leftNumber and rightNumber";
        }

    }
}
