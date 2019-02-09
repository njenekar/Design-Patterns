using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLearnings
{
    /// <summary>
    /// Classes and structs that are declared directly within a namespace (in other words that are not nested 
    /// within other classes or structs) can be either public or internal. Internal is the default if no access
    /// modifier is specified.
    /// </summary>
    class TestAccessModifier
    {
        Customer cust = new Customer();
        Product prod = new Product();
        
        static TestAccessModifier()
        { }

        
    }

    class Customer
    {
        public int Id { get; set; }
        public string Name {   get; }
    }

    public class Product
    {
        public int ProdId { get; set; }
        public string Name { get; set; }

        static string ProdNo { get; set; }
        static Product()
        {
            ProdNo = Guid.NewGuid().ToString();
        }

        public dynamic Add(int a, int b)
        {
            return a + b;
        }

        public override string ToString()
        {
            return this.ProdId.ToString() +"-"+ this.Name;
        }
    }

    public static class MyClass
    {
        public static void TestApp()
        {
            Product prod = new Product();
            prod.Add(3, 4);
            prod.ProdId = 101;
            prod.Name = "Computer";
            Console.WriteLine(prod.ToString());
        }
    }
}
