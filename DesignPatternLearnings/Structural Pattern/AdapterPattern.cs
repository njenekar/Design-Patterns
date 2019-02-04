/*
 * Allows a system to use classes of another system that is incompatible with it.
 * It is a versatile pattern that joins together types that were not designed to work with each other.
 * It is one of those patterns that comes in useful when dealing with legacy code—i.e.,
 * code that was written a while ago and to which one might not have access.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    public class AdapterPattern
    {
        public interface ITarget
        {
            string Request(int i);
        }

        public class Adaptee
        {
            public double SpecialRequest(double a, double b)
            {
                return a / b;
            }
        }

        // Implementing the required standard via Adaptee
        public class Adapter : Adaptee, ITarget
        {            
            public string Request(int i)
            {
                return "Rough estimate is " + (int)Math.Round(SpecialRequest(i, 3));
            }
        }

        public class Client
        {
            public static void Start()
            {
                // Showing the Adapteee in standalone mode
                Adaptee first = new Adaptee();
                Console.WriteLine("Before new standard pricing");
                Console.WriteLine(first.SpecialRequest(8,3));


                // What the client really wants
                ITarget second = new Adapter();
                Console.WriteLine("\nMoving to the new standard");
                Console.WriteLine(second.Request(8));
                
                
            }
        }

    }
}
