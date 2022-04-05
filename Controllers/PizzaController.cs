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
            try{
                return Ok(PizzasServices.GetAll()); 
            } 
            catch(Exception error){
                return Ok("error error error");
            }
        }

        [HttpGet("{id}")] 
        public IActionResult GetById (int id) {
            Pizzas pizza = null;

            if(id <= 0){
                return BadRequest();
            }
            try{
                pizza = PizzasServices.getById(id);
            } 
            catch(Exception error){
                if(error == 404){
                    return NotFound(error);
                }else{
                    return Ok(error);
                }
            }
            return Ok();
        }
        
        [HttpPost]
        public IActionResult Create (Pizza pizza) {
            try{
                return Ok(PizzasServices.Create(pizza));
            } 
            catch(Exception error){
                return Ok("error error error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza) {
           try{
               return Ok(PizzasServices.Update(id, pizza));
            } 
            catch(Exception error){
                return Ok("error error error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id) {
            try{
                return Ok(PizzasServices.DeleteById(id));
            } 
            catch(Exception error){
                return Ok("error error error");
            }
        }
    }
}
