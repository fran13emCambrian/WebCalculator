using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorLogic;
using Microsoft.AspNetCore.Mvc;



namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorAddController : ControllerBase
    {
        //Takes numbers for addition
        [HttpGet]
        public double Add([FromQuery] double num1, [FromQuery] double num2)
        {
            return Class1.Addition(num1, num2);
        }

    }
}
