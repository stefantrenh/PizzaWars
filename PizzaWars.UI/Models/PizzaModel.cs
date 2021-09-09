using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWars.UI.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Toppings { get; set; }
        public int HypeLevel { get; set; }
        public string Url { get; set; }
    }
}
