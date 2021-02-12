using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Availability { get; set; }
        public DateTime DateUpdated { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }
    }
}