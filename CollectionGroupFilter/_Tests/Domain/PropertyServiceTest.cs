using System;
using System.Collections.Generic;
using System.Linq;
using CollectionGroupFilter.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionGroupFilterTests.Domain
{
    [TestClass]
    public class PropertyServiceTest
    {
        [TestMethod]
        public void DistinctPrices()
        {
            PropertyService propertyService = new PropertyService();

            List<Property> props = new List<Property>()
            {
                new Property(1, 1, 2, 1, 1, 3, 100, 1000),
                new Property(2, 1, 2, 1, 1, 3, 100, 1000),
                new Property(3, 1, 2, 1, 1, 3, 100, 2000),
                new Property(4, 1, 2, 1, 1, 3, 100, 3000)
            };

            List<Property> result = propertyService.DistincPriceByTypeSubtypeRooms(props);

            Assert.AreEqual(result.Count, 3);
            Assert.AreEqual(result.Where(p => p.Price == 1000).ToList().Count, 1);
        }

        [TestMethod]
        public void TakeTwoDistinctRoomsPrices()
        {
            PropertyService propertyService = new PropertyService();

            List<Property> props = new List<Property>()
            {
                new Property(1, 1, 2, 1, 1, 3, 100, 1000),
                new Property(2, 1, 2, 1, 1, 3, 100, 1000),
                new Property(3, 1, 2, 1, 1, 3, 100, 2000),
                new Property(4, 1, 2, 1, 1, 3, 100, 3000),
                new Property(5, 1, 2, 1, 1, 4, 100, 1000),
                new Property(6, 1, 2, 1, 1, 4, 100, 2000),
                new Property(7, 1, 2, 1, 1, 4, 100, 3000),
                new Property(8, 1, 2, 1, 1, 5, 100, 3000)
            };

            List<Property> result = propertyService.DistinctRoomsPriceByTypeSubtypeRooms(props);

            Assert.AreEqual(result.Count, 5);
            //Assert.AreEqual(result.Where(p => p.Price == 1000).ToList().Count, 1);
        }

        [TestMethod]
        public void TakeTwoDistinctRoomsSortedByPrices()
        {
            PropertyService propertyService = new PropertyService();

            List<Property> props = new List<Property>()
            {
                new Property(4, 1, 2, 1, 1, 3, 100, 3000),
                new Property(1, 1, 2, 1, 1, 3, 100, 1000),
                new Property(2, 1, 2, 1, 1, 3, 100, 1000),
                new Property(3, 1, 2, 1, 1, 3, 100, 2000),
                new Property(5, 1, 2, 1, 1, 4, 100, 1000),
                new Property(7, 1, 2, 1, 1, 4, 100, 3000),
                new Property(6, 1, 2, 1, 1, 4, 100, 2000),
                new Property(8, 1, 2, 1, 1, 5, 100, 3000)
            };

            List<Property> result = propertyService.DistinctRoomsPriceByTypeSubtypeRoomsSorted(props);

            Assert.AreEqual(result.Count, 5);
            Assert.IsTrue(result.Any(p => p.Id == 1));
            Assert.IsTrue(result.Any(p => p.Id == 3));
            Assert.IsTrue(result.Any(p => p.Id == 5));
            Assert.IsTrue(result.Any(p => p.Id == 6));
            Assert.IsTrue(result.Any(p => p.Id == 8));
        }
    }
}
