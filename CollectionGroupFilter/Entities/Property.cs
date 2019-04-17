using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollectionGroupFilter.Entities
{
    public class Property
    {
        public Property(int id, int promoId, int typeId, int subTypeId, int transactionTypeId, int rooms, int surface, int price)
        {
            Id = id;
            PromoId = promoId;
            TypeId = typeId;
            SubtypeId = subTypeId;
            TransactionTypeId = transactionTypeId;
            Rooms = rooms;
            Surface = surface;
            Price = price;
        }

        public int Id { get; }
        public int PromoId { get; }
        public int TypeId { get; }
        public int SubtypeId { get; }
        public int TransactionTypeId { get; }
        public int Rooms { get; }
        public int Surface { get; set; }
        public int Price { get; set; }
    }
}