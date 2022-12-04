﻿

using System;

namespace DogBNB_Db.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string SitterId { get; set; }
        public string DogId { get; set; }
        public decimal Price { get; set; }
        public Service Service { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}
