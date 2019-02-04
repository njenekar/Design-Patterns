using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Participants

    The classes and objects participating in this pattern are:

-AbstractFactory  (ContinentFactory)
    declares an interface for operations that create abstract products
-ConcreteFactory   (AfricaFactory, AmericaFactory)
    implements the operations to create concrete product objects
-AbstractProduct   (Herbivore, Carnivore)
    declares an interface for a type of product object
-Product  (Wildebeest, Lion, Bison, Wolf)
    defines a product object to be created by the corresponding concrete factory
    implements the AbstractProduct interface
-Client  (AnimalWorld)
    uses interfaces declared by AbstractFactory and AbstractProduct classes 
*/
namespace DesignPatternLearnings.AbstractFactoryAnimalWorld
{
    
    public interface IAnimalFactory
    {
        ICarnivore CreateCarnivore();
        IHerbivore CreateHerbivore();
    }

    public class AfricaFactory : IAnimalFactory
    {
        public ICarnivore CreateCarnivore()
        {
            throw new NotImplementedException();
        }

        public IHerbivore CreateHerbivore()
        {
            throw new NotImplementedException();
        }
    }

    public interface IHerbivore
    {
        string CreateHerbivore();
    }

    public interface ICarnivore
    {
        string CreateCarnivore();
    }

    public class Wildebeest : IHerbivore
    {
        public string CreateHerbivore()
        {
            return "Wildebeest created";
        }
    }

    public class Lion : ICarnivore
    {
        public string CreateCarnivore()
        {
            return "Lion created";
        }
    }

    public class Bison : IHerbivore
    {
        public string CreateHerbivore()
        {
            return "Bison created";
        }
    }
    public class Wolf : ICarnivore
    {
        public string CreateCarnivore()
        {
            return "Wolf created";
        }
    }
}
