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

namespace Pizzas.API.Models{
    public class Usuarios{
        public int      Id              { get; set; }
        public string   Nombre          { get; set; }
        public Pizzas      Pizza              { get; set; }
    }
}