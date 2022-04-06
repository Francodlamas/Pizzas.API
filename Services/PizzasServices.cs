using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

using Pizzas.API.Models;
using Pizzas.API.Helpers;
using Pizzas.API.Utils;
using Pizzas.API.Services;

namespace Pizzas.API.Services{
    public static class PizzasServices{

        public static List <Pizza> GetAll(){
            List<Pizza> pizzas = null;
            String query ="SELECT * FROM Pizzas";
            
            using (SqlConnection db =BD.GetConnection() ){
                pizzas = db.Query<Pizza>(query).ToList();
            }
            return pizzas;
        }

        
        public static Pizza GetById(int idPizza){
            Pizza pizza = null;
            String query ="SELECT * FROM Pizzas WHERE Id = @id";
            
            using (SqlConnection db = BD.GetConnection()){
                pizza = db.QueryFirstOrDefault<Pizza>(query, new {id = idPizza});
            }
            return pizza;
        }


        public static int Create(Pizza pizza){
            String query = "INSERT INTO Pizzas (Nombre, LibreGluten, Importe, Descripcion) VALUES (@nombre, @libreGluten, @importe, @descripcion)";
            int RegistrosCreados = 0;
            
            using (SqlConnection db = BD.GetConnection()){
                RegistrosCreador = db.Execute(query, new{nombre = pizza.nombre, libreGluten = pizza.LibreGluten, importe = pizza.Importe, descripcion = pizza.Descripcion});
            }
            return RegistrosCreados;
        }

        public static int DeleteById(int id){
            int RegistrosEliminados = 0;
            String query = "DELETE * FROM Pizzas WHERE Id = @id";

            using (SqlConnection db = BD.GetConnection()){
                RegistrosEliminados = db.Execute(query, new{Id = id});
            }
            return RegistrosEliminados;
        }

        public static int Update (Pizza pizza){
            String query = "UPDATE Pizza SET (Nombre = @nombre, LibreGluten = @LibreGluten, Importe = @Importe, Descripcion = @Descripcion)";
            int RegistrosActualizados = 0;

            using (SqlConnection db =BD.GetConnection ()){
                RegistrosActualizados = db.Execute(query, new{nombre=pizza.nombre,libreGluten=pizza.LibreGluten,Importe=pizza.Importe,Descripcion=pizza.Descripcion});
            }
            return RegistrosActualizados;
        }
    }
}