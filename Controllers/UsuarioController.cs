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

namespace Pizzas.API.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController{

        [HttpGet]
        public IActionResult GetAll(){
            try{
                return Ok(UsuariosServices.GetAll()); 
            } 
            catch(Exception error){
                return Ok("error error error");
            }
        }

        [HttpGet("{id}")] 
        public IActionResult GetById (int id) {
            try{
                return Ok(UsuariosServices.getById(id));
            } 
            catch(Exception error){
                return Ok("error error error");
            }
        }

        [HttpPost]
        public IActionResult Create (Usuarios user) {
            try{
                return Ok(UsuariosServices.Create(user));
            } 
            catch(Exception error){
                return Ok("error error error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Usuarios user) {
           try{
               return Ok(UsuariosServices.Update(id, user));
            } 
            catch(Exception error){
                return Ok("error error error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id) {
            try{
                return Ok(UsuariosServices.DeleteById(id));
            } 
            catch(Exception error){
                return Ok("error error error");
            }
        }
    }
}