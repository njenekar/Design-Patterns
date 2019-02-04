using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*****Structural Patterns*****");
            Console.WriteLine("S1 : Decorator Pattern");
            Console.WriteLine("S2 : Proxy Pattern");
            Console.WriteLine("S3 : Bridge Pattern");
            Console.WriteLine("S4 : Adapter Pattern");
            Console.WriteLine("S5 : Facade Pattern");
            Console.WriteLine("S6 : Composite Pattern");
            Console.WriteLine("S7 : Flyweight Pattern");
            Console.WriteLine("D1 : Unity IOC Pattern");

            Console.WriteLine("\n*****Creational Patterns*****");
            Console.WriteLine("C1 : Singleton Pattern");
            Console.WriteLine("C2 : Factory Pattern");
            Console.WriteLine("C3 : Prototype Pattern");
            Console.WriteLine("C4 : Abstract Factory Pattern");
            Console.WriteLine("C4a : Abstract Factory Pattern-Generic");
            

            Console.WriteLine("\n*****Behavioral Patterns*****");
            Console.WriteLine("B1 : Strategy Pattern");
            Console.WriteLine("B2 : State Pattern");
            Console.WriteLine("B3 : Template Pattern");

            Console.WriteLine("\n*****General*****");
            Console.WriteLine("T1 : Test Application");

            Console.WriteLine("\nSelect value from above options:");
            string value = Console.ReadLine();

            switch (value)
            {
                case "S1":
                    DesignPatternLearnings.DecoratorPattern.Client.Start();
                    break;
                case "S2":
                    DesignPatternLearnings.ProxyPattern.Client.Start();
                    break;
                case "S3":
                    DesignPatternLearnings.BridgePattern.Client.Start();
                    break;
                case "S4":
                    DesignPatternLearnings.AdapterPattern.Client.Start();
                    break;
                case "C1":
                    DesignPatternLearnings.SingletonClient.Start();
                    break;
                case "C2":
                    DesignPatternLearnings.FactoryPattern.Client.Start();
                    break;
                case "C3":
                    DesignPatternLearnings.PrototypePattern.Client.Start();
                    break;
                case "C4":
                    DesignPatternLearnings.AbstractFactoryPattern.Program.Start();
                    break;
                case "C4a":
                    DesignPatternLearnings.AbstractFactoryGeneric.Program.Start();
                    break;
                case "D1":
                    DesignPatternLearnings.UnityIOC.Client.Start();
                    break;
                case "B1":
                    DesignPatternLearnings.StrategyPattern.Client.Start();
                    break;
                case "B2":
                    DesignPatternLearnings.StatePattern.Client.Start();
                    break;
                case "B3":
                    DesignPatternLearnings.TemplatePattern.Client.Start();
                    break;
                case "T1":
                    MyClass.TestApp();
                    break;
                default:
                    Console.WriteLine("\nImplementation Not Present......");
                    break;
            }
            
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
