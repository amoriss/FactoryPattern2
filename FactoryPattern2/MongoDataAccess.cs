using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    public class MongoDataAccess : IDataAccess
    {
        public MongoDataAccess()
        {
            Name = "mongo";
        }

        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Cell Phone", Price = 650.49 },
            new Product() {Name = "Cell Phone Case", Price = 29.99 },
            new Product() {Name = "Cell Phone Charger", Price = 19.99 },
            new Product() {Name = "Headphones", Price = 24.99 }

        };
        public string Name { get; set; }

        public List<Product> LoadData()
        {
            Console.WriteLine("Mongo Data Loading.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("Mongo Data Saved.");
        }
    }
}
