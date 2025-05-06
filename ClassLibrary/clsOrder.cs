using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public int OrderId { get; set; }
        public int AccountId { get; set; }
        public float TotalCost { get; set; }
        public DateTime DateOfDelivery { get; set; }
        public bool Delivered { get; set; }
        public string DeliveryInstructions { get; set; }
    }
}