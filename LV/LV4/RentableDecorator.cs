using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    abstract class RentableDecorator : IRentable
    {
        private IRentable rentable;
        public RentableDecorator(IRentable rentable) 
        {
            this.rentable = rentable; 
        }
        public virtual string Description
        {
            get { return rentable.Description; }
        }

         public virtual double CalculatePrice()
         {
            return rentable.CalculatePrice();
         }
    }
}
