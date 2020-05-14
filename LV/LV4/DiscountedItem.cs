using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double discount = 2.49;
        private double discountPercentage;
        public DiscountedItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            discountPercentage = (100 * discount) / base.CalculatePrice();

            return discountPercentage;
        }
        public override String Description
        {
            get
            {
                return "Check out this great deal! Now at " + this.discountPercentage + "% off on the title: " + base.Description;
            }
        }
    }
}
