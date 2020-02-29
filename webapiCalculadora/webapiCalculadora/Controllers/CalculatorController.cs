using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace webapiCalculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController()
        {

        }
        [Route("Add")]
        [HttpPost]
        public int Add([FromHeader]int a,[FromHeader] int b,int c)
        {
            return a + b;
        }

        [Route("Add")]
        [HttpGet]
        public int Add(int a,  int b)
        {
            return a + b;
        }

        [Route("Mult")]
        [HttpGet]
        public int Mult(int a, int b)
        {
            return a * b;
        }

        [Route("Mult")]
        [HttpPost]
        public int Mult([FromHeader]int a, [FromHeader]int b, int c)
        {
            return a * b;
        }

       
    }
}