using System.Collections.Generic;
using System.Linq;

namespace _07_AndreyAndBilliard
{
    public class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
            this.shopList = new Dictionary<string, int>(); 
        }
        public string Name { get; set; }
        public Dictionary<string, int> shopList { get; set; } 
    }
}
