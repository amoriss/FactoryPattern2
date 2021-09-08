using System;
using System.Threading; 

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            bool correctInput; 
            do {
                Console.Clear();
                correctInput = true; 
                Console.WriteLine("Enter in type of database you want to use: ");
                Console.WriteLine("SQL, List, or Mongo?");
                userInput = Console.ReadLine();

                if (userInput != "sql" && userInput !="list" && userInput !="mongo")
                {
                    correctInput = false;
                    Console.WriteLine("Input is invalid.");
                    Thread.Sleep(1000);
                
                }

            } while (!correctInput);

            Console.Clear();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);
            Console.WriteLine(db);
            Console.WriteLine(db.Name);
            var products = db.LoadData();
            db.SaveData();


            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price} ");
            }
        }
    }
}
