using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public Product Get()
        {
            return new Product
            {
                id = 1,
                name = "Book",
                price = 23.2
            };
        }

        [HttpGet("{name}")]
        public string Get(string name)
        {
            return "Hello : " + name;
        }

        [HttpPost]
        public string CreateNewProduct([FromBody]Product data)
        {
            //Save to DB
            return "Add " + data.name + " OK.";
        }

        [HttpPut]
        public string UpdateProduct([FromBody]Product data)
        {
            // Update
            return "Update " + data.name + " OK.";
        }
        
    }
}
