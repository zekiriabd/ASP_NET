using System;
using System.Threading.Tasks;
using LemonwayWebservice.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonwayWebserviceTest
{
    [TestClass]
    public class FibonacciServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            FibonacciService fibonacciService = new FibonacciService();
            //Assert.IsTrue(fibonacciService.FibonacciAsync(1).Result == 1);
            Assert.IsTrue(fibonacciService.FibonacciAsync(2).Result == 1);
            Assert.IsTrue(fibonacciService.FibonacciAsync(3).Result == 2);
            Assert.IsTrue(fibonacciService.FibonacciAsync(4).Result == 3);
            Assert.IsTrue(fibonacciService.FibonacciAsync(6).Result == 8);
            Assert.IsTrue(fibonacciService.FibonacciAsync(-101).Result == -1);
            Assert.IsTrue(fibonacciService.FibonacciAsync(100).Result == -1);
        }

        
    }
}
