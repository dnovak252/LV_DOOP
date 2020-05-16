using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class ShippingService 
    {
        private double weightPrice;
        public ShippingService(double weightPrice) { this.weightPrice = weightPrice; }
        public double shippingPrice (IShipable item)
        {
            double calculatedPrice = 0;
            calculatedPrice = item.Weight * weightPrice;
            return calculatedPrice;
        }
    }
}
