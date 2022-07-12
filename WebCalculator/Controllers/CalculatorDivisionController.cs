using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


namespace WebCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorDivisionController : ControllerBase
    {
        //Takes numbers for the division
       public double Division([FromQuery] double num1, [FromQuery] double num2)
       {
      return Class1.Division(num1, num2);
        }
    }
}
