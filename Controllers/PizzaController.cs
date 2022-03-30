using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Pizzas.API.Models;
using Pizzas.API.Helpers;
using Pizzas.API.Utils;
using Pizzas.API.Services;

namespace Pizzas.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController{

        [HttpGet]
        public IActionResult GetAll(){
            return Ok(PizzasServices.GetAll()); 
        }

        [HttpGet("{id}")] 
        public IActionResult GetById (int id) {
            return Ok(PizzasServices.getById(id));
        }
        
        [HttpPost]
        public IActionResult Create (Pizza pizza) {
            return Ok(PizzasServices.Create(pizza));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza) {
           return Ok(PizzasServices.Update(id, pizza));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id) {
           return Ok(PizzasServices.DeleteById(id));
        }  
    }
}
