using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternLearnings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternLearnings.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Product prod = new Product();
            dynamic res=prod.Add(3, 5);

            //Assert.AreEqual(8, res);
        }
    }
}