using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    public class ProxyPattern
    {
        public interface ISubject
        {
            string Result();
        }

        private class Subject : ISubject //Its value can be enhanced by making the Subject a private
                                        //class so that the Client cannot get to the Subject except via the Proxy.
        {
            public string Result()
            {
                return "hello world";
            }

            public void Create()
            {
                ///
            }
        }

        public class SubjectProxy : ISubject
        {
            private Subject subject;

            public string Result()
            {
                if (subject == null)
                    subject = new Subject();

                return subject.Result();
            }
        }

        public class Client
        {
            public static void Start()
            {
                Console.WriteLine("Proxy Pattern\n");

                SubjectProxy subproxy = new SubjectProxy();
                Console.WriteLine(subproxy.Result());


                /*----------OR-------------*/
                ISubject subPro = new SubjectProxy();
                Console.WriteLine(subPro.Result());
            }
        }

    }
}
