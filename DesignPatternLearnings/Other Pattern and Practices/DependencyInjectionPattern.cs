using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    public class DependencyInjectionPattern
    {
        public interface ILogger
        {
            void OpenLog();
            void Log(string message);
            void CloseLog();
        }

        public interface ILoggerInject
        {
            ILogger Construct();
        }

        public class FileLoggerInject : ILoggerInject
        {
            public string FileName { get; set; }
            public ILogger Construct()
            {
                return new FileLogger(FileName);
            }
        }

        public class LoggingEngine
        {
            private ILogger logger;

            ////Constructor Injection
            //public LoggingEngine(ILogger _logger)
            //{
            //    this.logger = _logger;
            //}

            public void Log(ILoggerInject loggerInject, string message)
            {
                logger = loggerInject.Construct();
                logger.OpenLog();
                logger.Log(message);
                logger.CloseLog();
            }

            public void Log(string message)
            {
                logger.OpenLog();
                logger.Log(message);
                logger.CloseLog();
            }
        }

        public class FileLogger : ILogger
        {
            public string LogFileName { get; private set; }
            public FileLogger(string logFileName) { LogFileName = logFileName; }

            public void OpenLog()
            {
                throw new NotImplementedException();
            }

            public void Log(string message)
            {
                throw new NotImplementedException();
            }

            public void CloseLog()
            {
                throw new NotImplementedException();
            }
        }

        public class SplunkLogger : ILogger
        {
            public void CloseLog()
            {
                throw new NotImplementedException();
            }

            public void Log(string message)
            {
                throw new NotImplementedException();
            }

            public void OpenLog()
            {
                throw new NotImplementedException();
            }
        }


        #region Comment


        public interface ITestInterface
        {
            void Print(string msg);
        }

        public abstract class FileHandler : ITestInterface
        {

            #region ITestInterface Members

            public void Print(string msg)
            {
                throw new NotImplementedException();
            }

            #endregion
        }

        public abstract class FileFiller : FileHandler
        {
            public delegate string del(string s);

        }


        //public class MyClass
        //{
        //    public void Print(string msg)
        //    {

        //    }
        //    public string ReplaceSpace(string s)
        //    {
        //        return s;
        //    }
        //}
        //public class InterfaceInheritance : BaseClass
        //{
        //    new void Print(string msg);
        //}

        #endregion



        public class Client
        {
            public static void Start()
            {
                //ILogger myLog = new SplunkLogger();
                //LoggingEngine sLog = new LoggingEngine(new FileLogger());
                //sLog.Log("hello");


                //Interface base injection
                LoggingEngine iEngine = new LoggingEngine();
                ILoggerInject logInject = new FileLoggerInject() { FileName = "xyz" };

                iEngine.Log(logInject, "Hello");

            }
        }

    }
}
