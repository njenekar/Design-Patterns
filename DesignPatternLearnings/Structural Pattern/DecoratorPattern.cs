/*Decorators do not need any advanced language features; they rely on object aggregation and interface implementation.
 * The example starts off with the IComponent interface and a simple Component class
that implements it. There are two decorators that also implement the
interface; each of them includes a declaration of an IComponent, which is the object it
will decorate. DecoratorA is fairly plain and simply implements the
Operation by calling it on the component it has stored, then adding something to the
string it returns. DecoratorB is more elaborate. It also implements
the Operation in its own way, but it offers some public addedState 
and addedBehavior as well. In both implemented operations, the component’s
Operation method is called first, but this is not a requirement of the pattern;
it merely makes for more readable output in this example.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    public class DecoratorPattern
    {
        interface IComponent
        {
            string Operation();
        }


        class Component : IComponent //Component implements(realizes) IComponent interface. is-a relationship 
        {
            public string Operation()
            {
                return "I am Walking ";
            }
        }

        class DecoratorA : IComponent //DecoratorA implements(realizes) IComponent interface. is-a relationship 
        {
            IComponent component; //DecoratorA has-a relationship with IComponent.

            public DecoratorA(IComponent c)
            {
                component = c;
            }

            public string Operation()
            {
                string s = component.Operation();
                s += "and listening to Classic FM ";
                return s;
            }
        }

        class DecoratorB : IComponent
        {
            IComponent component;
            public string addedState = "past the Coffee Shop ";

            public DecoratorB(IComponent c)
            {
                component = c;
            }

            public string Operation()
            {
                string s = component.Operation();
                s += "to school ";
                return s;
            }

            public string AddedBehavior()
            {
                return "and I bought a cappuccino ";
            }
        }

        public class Client
        {
            static void Display(string s, IComponent c)
            {
                Console.WriteLine(s + c.Operation());
            }

            public static void Start()
            {
                Console.WriteLine("Decorator Pattern\n");

                IComponent component = new Component();
                Display("1. Basic component: ", component);
                Display("2. A-decorated : ", new DecoratorA(component));

                Display("3. B-decorated : ", new DecoratorB(component));
                Display("4. B-A-decorated : ", new DecoratorB(new DecoratorA(component)));

                // Explicit DecoratorB
                DecoratorB b = new DecoratorB(new Component());
                Display("5. A-B-decorated : ", new DecoratorA(b));

                // Invoking its added state and added behavior
                Console.WriteLine("\t\t\t" + b.addedState + b.AddedBehavior());
            }
        }
    }
}
