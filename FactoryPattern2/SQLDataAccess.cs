using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    public class SQLDataAccess : IDataAccess
    {
        public SQLDataAccess()
        {
            Name = "SQL";
        }
        public string Name { get; set; }

        public static List<Product> Products = new List<Product>()
        { 
            new Product() {Name = "Cell Phone", Price = 650.49 },
            new Product() {Name = "Cell Phone Case", Price = 29.99 },
            new Product() {Name = "Cell Phone Charger", Price = 19.99 },
            new Product() {Name = "Headphones", Price = 24.99 }

        };
        public List<Product> LoadData()
        {
            Console.WriteLine("SQL Data Loading.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("SQL Data Saved.");
        }
    }
}
