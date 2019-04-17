using System;
using System.Collections.Generic;
using System.Linq;
using CollectionGroupFilter.Entities;

namespace CollectionGroupFilterTests.Domain
{
    public class PropertyService
    {
        public List<Property> DistincPriceByTypeSubtypeRooms(List<Property> props)
        {
            return props.GroupBy(p => new { p.PromoId, p.TypeId, p.SubtypeId, p.TransactionTypeId, p.Rooms, p.Price })
                .Select(i => i.First())
                .ToList();
        }

        public List<Property> DistinctRoomsPriceByTypeSubtypeRooms(List<Property> props)
        {
            return DistincPriceByTypeSubtypeRooms(props)
                .GroupBy(p => new { p.PromoId, p.TypeId, p.SubtypeId, p.TransactionTypeId, p.Rooms })
                .SelectMany(i => i.Take(2))
                .ToList();
        }

        public List<Property> DistinctRoomsPriceByTypeSubtypeRoomsSorted(List<Property> props)
        {
            return DistincPriceByTypeSubtypeRooms(props)
                .GroupBy(p => new { p.PromoId, p.TypeId, p.SubtypeId, p.TransactionTypeId, p.Rooms })
                .SelectMany(i => i.OrderBy(p => p.Price).Take(2))
                .ToList();
        }

        
    }
}