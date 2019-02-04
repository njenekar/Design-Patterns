using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    public class BridgePattern
    {
        public interface IBridge
        {
            void OpernationImplementation();
        }

        //public abstract class Abstraction
        public class Abstraction
        {
            private IBridge _bridge;

            public Abstraction(IBridge implementation)
            {
                _bridge = implementation;
            }

            public void Operation()
            {
                _bridge.OpernationImplementation();
            }
        }

        public class ImplementationA : IBridge
        {
            public void OpernationImplementation()
            {
                Console.WriteLine("ImplementationA");
            }

        }

        public class ImplementationB : IBridge
        {
            public void OpernationImplementation()
            {
                Console.WriteLine("ImplementationB");
            }

        }

        /// <summary>
        /// Real time example of data persistence with Bridge pattern
        /// </summary>
        public interface IPersistData
        {
            void PersistData();
        }

        //Abstraction Class
        public class PersistDataAbstration
        {
            private IPersistData _persistData;

            public PersistDataAbstration(IPersistData _implemantation)
            {
                _persistData = _implemantation;
            }

            public void PersistDataImple()
            {
                _persistData.PersistData();
            }
        }

        public class DB2Implementation : IPersistData
        {
            #region IPersistData Members

            public void PersistData()
            {
                Console.WriteLine("Save Data to DB2");
            }

            #endregion
        }

        public class SQLServerImplementation : IPersistData
        {
            #region IPersistData Members

            public void PersistData()
            {
                Console.WriteLine("Save Data to SQLServer");
            }

            #endregion
        }

        public class Client
        {
            public static void Start()
            {
                Console.WriteLine("Bridge Pattern\n");

                ImplementationA impA = new ImplementationA();
                impA.OpernationImplementation();

                new ImplementationB().OpernationImplementation();

                //........................
                //new Abstraction().Operation();
                new Abstraction(new ImplementationA()).Operation();
                new Abstraction(new ImplementationB()).Operation();


                //************************************
                //Client will decide which sub class to instantiate at run time.

                bool persistFlag = false;
                if (persistFlag)
                {
                    new PersistDataAbstration(new DB2Implementation()).PersistDataImple();
                }
                else
                {
                    new PersistDataAbstration(new SQLServerImplementation()).PersistDataImple();
                }
            }
        }
    }
}
