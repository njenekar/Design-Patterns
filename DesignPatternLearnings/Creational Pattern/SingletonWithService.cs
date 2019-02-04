using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunicationLib;

namespace DesignPatternLearnings
{
    public class SingletonWithService
    {
        private SingletonWithService()
        {
            Client = new GWServiceRef.GlobalWeatherSoapClient("GlobalWeatherSoap");
        }

        static readonly SingletonWithService instance = new SingletonWithService();

        private GWServiceRef.GlobalWeatherSoapClient Client { get; set; }

        public static SingletonWithService GetObject
        {
            get { return instance; }
        }



        public string GetCitiesByCountry(string country)
        {
            return Client.GetCitiesByCountry(country);
        }

        public string GetWeather(string city, string country)
        {
            return Client.GetWeather(city, country);
        }

    }

    public class ServiceClient
    {
        public static void Start()
        {
            //Console.WriteLine(SingletonWithService.GetObject.GetCitiesByCountry("India"));

            //Console.WriteLine(SingletonWithService.GetObject.GetCitiesByCountry("Italy"));

            Console.WriteLine(CommunicationLib.ClientConnection.Instance.GetCitiesByCountry("India"));
        }
    }

}
