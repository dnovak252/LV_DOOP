using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    public interface WeatherObserver
    {
        void Update(int temperature);
    }
}
