using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DriversJournal.Main.Enums;

namespace DriversJournal.Main.Tests
{
    [TestClass()]
    public class RouteTests
    {
        [TestMethod()]
        public void CalculateRouteDistanceTest()
        {
            // Arrange
            var Route = new Route(origin: "Göteborg",
                                destination: "Trelleborg",
                                milageOrigin: 12347,
                                milageDestination: 12512);
            var expected = 165;

            // Act
            var actual = Route.CalculateRouteDistance();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SummorizeRouteTest()
        {
            // Arrange
            var route = new Route(origin: "Göteborg",   
                                destination: "Trelleborg",
                                milageOrigin: 12347,
                                milageDestination: 12512,
                                journeyTypeEnum: JourneyTypeEnum.Private
                                );
            var expected = "Private\r\nStart: Göteborg - km: 12347\r\nEnd: Trelleborg - km: 12512\r\nDistance: 165";

            // Act
            var actual = route.SummorizeRoute().ToString();

            // Assert
            Assert.AreEqual(expected, actual);
         }
    }
}