using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    public sealed class Singleton
    {
        //Private Constructor
        private Singleton()
        {
            Name = "Server1";
            IP = "10.60.61.25";
        }

        //Private object instantiated with private constructor
        private static volatile Singleton instance;//the variable is declared to be volatile to ensure that assignment to the instance variable completes before the instance variable can be accessed.
        private static object syncRoot = new Object();

        private string Name { get; set; }
        private string IP { get; set; }

        //Public static property to get the object
        public static Singleton Instance
        {
            //get { return instance; } //eager initialization

            //lazy initialization of singleton
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }


    }

    public class SingletonClient
    {
        public static void Start()
        {
            Singleton.Instance.Show();

            Singleton.Instance.Show();



        }
    }
}
