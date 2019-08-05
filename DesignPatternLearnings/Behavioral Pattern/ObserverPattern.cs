using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLearnings
{
    public class ObserverPattern
    {
        public class Client
        {
            public static void Start()
            {
                CSharpHelper blog = new CSharpHelper();
                blog.Subscribe(new Observer(blog, "Rocky"));
                var johnObj = new Observer(blog, "John");
                blog.Subscribe(johnObj);
                blog.Subscribe(new Observer(blog, "Kiran"));

                //change subject and notify user
                blog.SubjectState = "New article verion drafted";                
                blog.Notify();

                blog.SubjectState = "New article started";
                blog.Notify();

                //John Unsubscribes from blog 
                blog.Unsubscribe(johnObj);

                blog.SubjectState = "Article published";
                blog.Notify();

                blog.SubjectState = "Article updated";
                blog.Notify();
                Console.ReadKey();
            }
        }

        //The class whose instances independently change their state and notify Observers
        abstract class Subject
        {
            private List<Observer> observers = new List<Observer>();
            public void Notify()
            {
                Console.WriteLine(".........................");
                foreach (Observer obj in observers)
                {
                    obj.Update();
                }
            }

            public void Subscribe(Observer observer)
            {
                observers.Add(observer);
            }

            public void Unsubscribe(Observer observer)
            {
                observers.Remove(observer);
            }
        }

        //Blog site inherits Subject
        class CSharpHelper : Subject
        {
            public string SubjectState
            {
                get; set;
            }
        }

        //An interface for Observers specifying how they should be updated
        interface IObserver
        {
            void Update();
        }

        //A class that provides an Update method to enable its instance’s state to stay consistent
        //with the Subject’s 
        class Observer : IObserver
        {
            CSharpHelper _subject;
            string _observerState;
            string _observerName;

            public Observer(CSharpHelper subject, string name)
            {
                _subject = subject;
                _observerName = name;
            }

            public void Update()
            {
                _observerState = _subject.SubjectState;
                Console.WriteLine("Notified {0} for : {1}", _observerName, _observerState);
            }
        }
    }
}
