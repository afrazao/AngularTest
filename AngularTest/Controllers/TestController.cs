using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularTest.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private static string[] DDLTest = new[]
        {
            "António", "Matias", "Filips"
        };

        [HttpGet("action")]
        public IEnumerable<Names> NameList()
        {
            //return Enumerable.Select(index => new Names
            //{
            //    Name
            //});
        }

        public class Names
        {
            public string Name { get; set; }
        }
    }
}