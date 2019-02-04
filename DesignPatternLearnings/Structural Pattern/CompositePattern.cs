using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternLearnings
{
    public class CompositePattern
    {
        //The Interface
        public interface IComponent<T>
        {
            T Name { get; set; }

            void Add(IComponent<T> c);
            IComponent<T> Remove(T c);
        }

        //The Component
        public class Component<T> : IComponent<T>
        {

            #region IComponent<T> Members

            public T Name
            {
                get;
                set;
            }

            public void Add(IComponent<T> c)
            {
                throw new NotImplementedException();
            }

            public IComponent<T> Remove(T c)
            {
                throw new NotImplementedException();
            }

            #endregion
        }

        //The Composite
        public class Composite<T> : IComponent<T>
        {
            List<IComponent<T>> _list;

            public Composite(T name)
            {
                Name = name;
                _list = new List<IComponent<T>>();
            }

            #region IComponent<T> Members

            public T Name { get; set; }

            public void Add(IComponent<T> c)
            {
                _list.Add(c);
            }

            public IComponent<T> Remove(T c)
            {
                throw new NotImplementedException();
            }

            #endregion
        }


    }
}
