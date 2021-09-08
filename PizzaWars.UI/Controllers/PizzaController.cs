﻿using Microsoft.AspNetCore.Mvc;
using PizzaWars.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWars.UI.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<PizzaModel> PizzaLists()
        {
            List<PizzaModel> pizzas = new List<PizzaModel>();
            var randomNumb = new Random();

            pizzas.Add(new PizzaModel{ Id = 1, HypeLevel = randomNumb.Next(1,11), Name = "Hawai" , Toppings = { "Pine Apple", "Cheese", "Ham" } });
            pizzas.Add(new PizzaModel { Id = 2, HypeLevel = randomNumb.Next(1, 11), Name = "Kebab", Toppings = { "Tomato", "Cheese", "Pork" } });
            pizzas.Add(new PizzaModel { Id = 3, HypeLevel = randomNumb.Next(1, 11), Name = "Quattro", Toppings = { "Shrimps", "Mushrooms", "Ham", "Clams" } });
            pizzas.Add(new PizzaModel { Id = 4, HypeLevel = randomNumb.Next(1, 11), Name = "Tuna", Toppings = { "Tuna", "Cheese", "Tomato" } });

            return pizzas;
        }
    }
}