using System;

namespace DesignPatternLearnings
{
    internal class StrategyPattern
    {
        public static class Client
        {
            public static void Start()
            {
                Context context;
                context = new Context(new StrategyA());
                context.ContextAlgo();

                context = new Context(new StrategyB());
                context.ContextAlgo();
            }
        }

        public class Context
        {
            private IStrategy _strategy;
            public Context(IStrategy strategy)
            {
                _strategy = strategy;
            }

            public void ContextAlgo()
            {
                _strategy.DoAlogorithm();
            }
        }

        public interface IStrategy
        {
            void DoAlogorithm();
        }

        public class StrategyA : IStrategy
        {
            public void DoAlogorithm()
            {
                Console.WriteLine("Called Strategy A Algorithm");

            }
        }

        public class StrategyB : IStrategy
        {
            public void DoAlogorithm()
            {
                Console.WriteLine("Called Strategy B Algorithm");
            }
        }
    }
}