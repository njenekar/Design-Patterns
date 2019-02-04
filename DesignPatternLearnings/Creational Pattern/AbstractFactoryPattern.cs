using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLearnings.AbstractFactoryPattern
{

    /// <summary>
    /// AbstractFactory Interface
    /// </summary>
    public interface IVehicleFactory
    {
        ITwoWheelProduct CreateTwoWheeler();
        IFourWheelProduct CreateFourWheeler();
    }

    // Concrete Factories
    public class HondaFactory : IVehicleFactory
    {
        public IFourWheelProduct CreateFourWheeler()
        {
            return new City();
        }

        public ITwoWheelProduct CreateTwoWheeler()
        {
            return new Activa();
        }
    }

    // Concrete Factories
    public class MahindraFactory : IVehicleFactory
    {
        public IFourWheelProduct CreateFourWheeler()
        {
            return new Scorpio();
        }

        public ITwoWheelProduct CreateTwoWheeler()
        {
            return new Centuro();
        }
    }
    //######################################################################
    /// <summary>
    /// Abstract Product1 Interface
    /// </summary>
    public interface ITwoWheelProduct
    {
        string GetName();
    }

    /// <summary>
    /// Abstract Product2 Interface
    /// </summary>
    public interface IFourWheelProduct
    {
        string GetName();
    }


    public class Activa : ITwoWheelProduct
    {
        public string GetName()
        {
            return "Activa";
        }
    }

    public class Centuro : ITwoWheelProduct
    {
        public string GetName()
        {
            return "Centuro";
        }
    }

    public class City : IFourWheelProduct
    {
        public string GetName()
        {
            return "City";
        }
    }

    public class Scorpio : IFourWheelProduct
    {
        public string GetName()
        {
            return "Scorpio";
        }
    }

    public class VehicleClient
    {
        IFourWheelProduct fourWheelsProduct;
        ITwoWheelProduct twoWheelsProduct;

        public VehicleClient(IVehicleFactory factory)
        {
            fourWheelsProduct = factory.CreateFourWheeler();
            twoWheelsProduct = factory.CreateTwoWheeler();
        }

        public string GetFourWheelName()
        {
            return fourWheelsProduct.GetName();
        }

        public string GetTwoWheelName()
        {
            return twoWheelsProduct.GetName();
        }
    }

    public class Program
    {
        public static void Start()
        {
            Console.WriteLine("**************HONDA***************");
            IVehicleFactory hondaFactory = new HondaFactory();
            VehicleClient hondaClient = new VehicleClient(hondaFactory);

            Console.WriteLine(hondaClient.GetTwoWheelName());
            Console.WriteLine(hondaClient.GetFourWheelName());

            Console.WriteLine("**************MAHINDRA***************");
            IVehicleFactory mahindrafactory = new MahindraFactory();
            VehicleClient mahindraClient = new VehicleClient(mahindrafactory);

            Console.WriteLine(mahindraClient.GetTwoWheelName());
            Console.WriteLine(mahindraClient.GetFourWheelName());

        }
    }

}
