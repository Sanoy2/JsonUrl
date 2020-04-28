using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlJson.Models;

namespace UrlJson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly IDestringifier destringifier;
        private readonly Calculator calculator;

        public GradesController(IDestringifier destringifier, Calculator calculator)
        {
            this.destringifier = destringifier;
            this.calculator = calculator;
        }

        /// <summary>
        /// This is example that shows deserializing json sent as base64
        /// </summary>
        /// <remarks>
        /// Sample string:
        /// 
        ///     eyJzdHVkZW50TmFtZSI6ICJKb2huIERvZSIsInN0dWRlbnRHcmFkZXMiOiBbNCw0LDUsNF19
        ///     
        /// Which is json:
        /// 
        ///     {
        ///         "studentName": "John Doe","studentGrades": [4,4,5,4]
        ///     }
        ///     
        /// base64 encoder:
        /// https://www.base64encode.net/
        /// </remarks>
        /// <param name="parameter"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{parameter}")]
        public IActionResult Count([FromRoute] string parameter)
        {
            Grades grades = this.destringifier.Destringify<Grades>(parameter);

            Result result = this.calculator.Calculate(grades);

            return Ok(result);
        }
    }
}