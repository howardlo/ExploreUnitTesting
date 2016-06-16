using ExploreUnitTesting;
using Microsoft.Owin.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreUnitTestingTest
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public async Task TestStartup()
        {
            using (var server = TestServer.Create<Startup>())
            {
                var response = await server.HttpClient.GetAsync("/nancy-test");
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine("body: ");
                Console.WriteLine(body);
                Assert.IsTrue(body.Contains("nancy-test"));
            }
        }

        //[TestMethod]
        //public void TestMethodPassing()
        //{
        //    Assert.IsTrue(true);
        //}

        //[TestMethod]
        //public void TestMethodFailing()
        //{
        //    Assert.IsTrue(false);
        //}
    }
}
