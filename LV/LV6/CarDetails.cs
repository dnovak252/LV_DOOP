using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    enum Tire
        {
            winter,
            summer
        }
    class CarDetails : WeatherObserver
    {
        
        private double enginePower;
        private double fuelInLiters;
        string tires;
        public CarDetails(double power, double fuel, string tires)
        {
            this.enginePower = power;
            this.fuelInLiters = fuel;
            this.tires = tires;
        }
        public void Update(int temperature)
        {
            if (temperature <= 5)
            {
                tires = Tire.winter.ToString();

            }
            else if (temperature > 5)
            {
                tires = Tire.summer.ToString();
            }
        }
        public override string ToString()
        {
            return "Current car status: "+ this.enginePower + "HP, " + this.fuelInLiters + "L, " + this.tires+" tires";
        }
    }
}
