using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLearnings.AbstractFactoryGeneric
{
    // Uses generics to simplify the creation of factories
    public interface IVehicleFactory<Product> where Product : ITwoWheel
    {
        ITwoWheelerProduct CreateTwoWheel();
        IFourWheelerProduct CreateFourWheel();
    }

    //Concrete Factories (both in same one)
    public class VehicleFactory<Product> : IVehicleFactory<Product> where Product : ITwoWheel, new()
    {
        public IFourWheelerProduct CreateFourWheel()
        {
            return new FourWheel<Product>();
        }

        public ITwoWheelerProduct CreateTwoWheel()
        {
            return new TwoWheel<Product>();
        }
    }

    public interface ITwoWheelerProduct
    {
        string Material { get; }
    }

    public interface IFourWheelerProduct
    {
        int Price { get; }
    }

    //Concrete products Two Wheel
    public class TwoWheel<Product> : ITwoWheelerProduct
            where Product : ITwoWheel, new()
    {
        public Product myProduct;
        public TwoWheel()
        {
            myProduct = new Product();
        }

        public string Material
        {
            get
            {
                return myProduct.Material;
            }
        }
    }

    //Concrete products Four Wheel
    public class FourWheel<Product> : IFourWheelerProduct
        where Product : ITwoWheel, new()
    {
        public Product myProduct;
        public FourWheel()
        {
            myProduct = new Product();
        }
        public int Price
        {
            get
            {
                return myProduct.Price;
            }
        }
    }


    // An interface for all Procudts
    public interface ITwoWheel
    {
        int Price { get; }
        string Material { get; }
    }

    public class Activa : ITwoWheel
    {
        public string Material
        {
            get
            {
                return "Fiber Body";
            }
        }

        public int Price
        {
            get
            {
                return 65000;
            }
        }
    }

    public class Centuro : ITwoWheel
    {
        public string Material
        {
            get
            {
                return "Metal Body";
            }
        }

        public int Price
        {
            get
            {
                return 75000;
            }
        }
    }

    public class Client<Product>
        where Product : ITwoWheel, new()
    {
        public void ClientMain()
        {
            IVehicleFactory<Product> factory = new VehicleFactory<Product>();

            ITwoWheelerProduct twoWheel = factory.CreateTwoWheel();
            IFourWheelerProduct fourWheel = factory.CreateFourWheel();
            Console.WriteLine("Material: " + twoWheel.Material);
            Console.WriteLine("Price: " + fourWheel.Price);

        }
    }

    public class Program
    {
        public static void Start()
        {
            new Client<Activa>().ClientMain();
            new Client<Centuro>().ClientMain();
        }
    }
}
