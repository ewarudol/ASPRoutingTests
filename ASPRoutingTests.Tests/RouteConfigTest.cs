using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MvcRouteUnitTester;
using System.Web.Routing;

namespace ASPRoutingTests.Tests
{
    [TestFixture]
    public class RouteConfigTest
    {

        private RouteTester tester;

        // --- Global Arrange
        [OneTimeSetUp]
        public void GlobalSetUp() {
            RouteCollection routes = RouteTable.Routes;
            RouteConfig.RegisterRoutes(routes);
            tester = new RouteTester(routes);
        }

        [Test]
        public void TestIncomingRoutes() {

            // Arrange
            // --- Global Arrange

            // Act and Assert
            tester.WithIncomingRequest("/").ShouldMatchRoute("Home", "Index");
        }

        [Test]
        public void TestOutgoingRoutes() {

            // Arrange
            // --- Global Arrange

            // Act and Assert
            tester.WithRouteInfo("Home", "Index").ShouldGenerateUrl("/");
        }

    }
}
