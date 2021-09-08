using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    public class ListDataAccess : IDataAccess
    {
        public ListDataAccess()
        {
            Name = "list"; 
        }
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Cell Phone", Price = 650.49 },
            new Product() {Name = "Cell Phone Case", Price = 29.99 },
            new Product() {Name = "Cell Phone Charger", Price = 19.99 },
            new Product() {Name = "Headphones", Price = 24.99 }

        };

        public string Name { get ; set; }

        public List<Product> LoadData()
        {
            Console.WriteLine("List Data loading.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("List Data saved.");
        }
    }
}
