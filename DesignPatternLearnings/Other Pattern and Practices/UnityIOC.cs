using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace DesignPatternLearnings
{
    public class UnityIOC
    {
        public interface ICompany
        {
            void ShowSalary();
        }

        //Dependency injection by Property injection
        public class Employee 
        {
            private ICompany _Company;

            [Dependency]
            public ICompany Company
            {
                get { return _Company; }
                set { _Company = value; }
            }

            public void DisplaySalary()
            {
                _Company.ShowSalary();
            }
        }        

        public class Company : ICompany
        {
            #region ICompany Members

            public void ShowSalary()
            {
                Console.WriteLine("Your Salary is 100 K");
            }

            #endregion
        }

        public class Client
        {
            public static void Start()
            {
                //we are creating an object of IUnityContainer 
                IUnityContainer unityContainer = new UnityContainer();

                //Then we will register the class on which the main class is dependent.
                //Here Employee class is dependent on the Company class. 
                //So we need to add the Company class to the container.
                unityContainer.RegisterType<ICompany, Company>();

                //Fine, now the container is ready for use to solve dependency of another class. 
                //We will now create one object of the Employee class and solve it's dependency using IoC container
                //as in the following:
                Employee emp = unityContainer.Resolve<Employee>();
                emp.DisplaySalary();

                Console.ReadLine();
            }
        }

    }
}
