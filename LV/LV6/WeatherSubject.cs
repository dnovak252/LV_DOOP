using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    public interface WeatherSubject
    {
        void AddObserver(WeatherObserver weatherObserver);
        void RemoveObserver(WeatherObserver weatherObserver);
        void Notify();
    }
}
