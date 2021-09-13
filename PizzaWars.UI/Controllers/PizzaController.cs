using Microsoft.AspNetCore.Mvc;
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

            pizzas.Add(new PizzaModel{ Id = 0, HypeLevel = randomNumb.Next(1,11), Name = "Hawaii" , Toppings = new List<string>() { "Pineapple", "Cheese", "Ham" } });
            pizzas.Add(new PizzaModel { Id = 1, HypeLevel = randomNumb.Next(1, 11), Name = "Kebab", Toppings = new List<string>() { "Tomato", "Cheese", "Pork" } });
            pizzas.Add(new PizzaModel { Id = 2, HypeLevel = randomNumb.Next(1, 11), Name = "Greek God", Toppings = new List<string>() { "Fat Cheese", "Olives", "Cucumber" } });
            pizzas.Add(new PizzaModel { Id = 3, HypeLevel = randomNumb.Next(1, 11), Name = "Swedish Thor", Toppings = new List<string>() { "Meatballs", "More Meatballs", "Cheese", "Ketchup" } });
            pizzas.Add(new PizzaModel { Id = 4, HypeLevel = randomNumb.Next(1, 11), Name = "Vegan Desire", Toppings = new List<string>() { "Grass?", "Grass??", "Grass?????" } });
            pizzas.Add(new PizzaModel { Id = 5, HypeLevel = randomNumb.Next(1, 11), Name = "Quattro", Toppings = new List<string>() { "Mushrooms", "Ham", "Clam", "Shrimp" } });

            return pizzas;
        }


    }
}
