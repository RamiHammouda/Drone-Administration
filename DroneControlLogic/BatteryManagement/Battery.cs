using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryManagement
{
  public  class Battery
    {
        public int BatteryId;
        public int BatteryAddress;
        
        public Battery(int batteryId, int batteryAddress)
        {
            this.BatteryId = batteryId;
            this.BatteryAddress = batteryAddress;
        }

    }
}
