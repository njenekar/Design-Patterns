using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    public class FactoryPattern
    {
        public interface IProduct
        {
            string ShipFrom();
        }

        public class ProductA : IProduct
        {
            public string ShipFrom()
            {
                return "From Spain";
            }
        }

        public class ProductB : IProduct
        {
            public string ShipFrom()
            {
                return "From SA";
            }
        }

        //Factory class will decide which subclass to instantiate using factory method
        public class Creator
        {
            public IProduct FactoryMethod(int month)
            {
                if (month >= 4 && month <= 11)
                    return new ProductA();
                else
                    return new ProductB();
            }
        }

        public class Client
        {
            public static void Start()
            {
                Creator c = new Creator();//Factory class
                IProduct product;

                product = c.FactoryMethod(10);
                Console.WriteLine("Avocados " + product.ShipFrom());
            }
        }
    }
}
