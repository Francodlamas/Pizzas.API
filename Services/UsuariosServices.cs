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


namespace Pizzas.API.Services{
    public static class UsuariosServices{

        public static List<Usuarios> GetAll(){
            List<Usuarios> user = null;
            string query ="SELECT * FROM Usuarios";
            
            using (SqlConnection db = BD.GetConnection()){
                user = db.Query<Usuarios>(query).ToList();
            }
            return user;
        }

        
        public static Pizza GetById(int idUsuario){
            Usuarios user = null;
            string query ="SELECT * FROM Usuarios WHERE Id = @id";
            
            using (SqlConnection db = BD.GetConnection()){
                usuario = db.QueryFirstOrDefault<Usuario>(query, new {id = idUsuario});
            }
            return usuario;
        }


        public static int Create(Usuarios user){
            string query = "INSERT INTO Usuarios (Nombre, Pizza) VALUES (@nombre, @pizza)";
            int RegistrosCreados = 0;
            
            using (SqlConnection db =BD.GetConnection() ){
                RegistrosCreador = db.Execute(query, new{nombre = user.nombre, pizza = user.pizza});
            }
            return RegistrosCreados;
        }

        public static int DeleteById(int id){
            int RegistrosEliminados = 0;
            string query = "DELETE * FROM Usuarios WHERE Id = @id";

            using (SqlConnection db = BD.GetConnection()){
                RegistrosEliminados = db.Execute(query, new{Id = id});
            }
            return RegistrosEliminados;
        }

        public static int Update (Usuarios user){
            string query = "UPDATE Usuarios SET (Nombre = @nombre, Pizza = @pizza)";
            int RegistrosActualizados = 0;

            using (SqlConnection db = BD.GetConnection()){
                RegistrosActualizados = db.Execute(query, new{nombre = user.nombre, pizza = user.pizza});
            }
            return RegistrosActualizados;
        }
    }
}