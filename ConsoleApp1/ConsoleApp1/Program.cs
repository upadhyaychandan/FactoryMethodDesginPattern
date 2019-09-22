using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public enum DeviceClassType
        {
            #region Device Class Types

            securitypanel = 1,
            thermostat = 2,
            sensor = 3,
            awair = 4

            #endregion
        }
        static void Main(string[] args)
        {
            string Id = "homes.dc.sensor";
            bool yes = Enum.IsDefined(typeof(DeviceClassType), Id.Split('.').ToArray().Last().ToLower());
        }
        
    }

    
    
}
