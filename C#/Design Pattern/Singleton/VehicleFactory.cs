using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
     public sealed class VehicleFactory  // sealed means code should not be inherited 
    {
 
            private static VehicleFactory? instance;

            private VehicleFactory() { } // empty constructor

        // constructor call
            public static VehicleFactory Instance // instance is created, instance should be available at only one time
            {
                get
                {
                // if the instance is empty create an instance else it doesnot create another
                if (instance == null)
                    {
                        instance = new VehicleFactory(); 
                    }
                    return instance;
                }
            }

            public Vehicle CreateVehicle(string vehicleType)
            {
                switch (vehicleType.ToLower())
                {
                    case "car":
                        return new Car();
                    case "bike":
                        return new Bike();
                    default:
                        throw new ArgumentException($"Invalid vehicle type: {vehicleType}");
                }
            }
        }
    
}
