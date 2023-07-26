

using Singleton;

VehicleFactory vehicleFactory = VehicleFactory.Instance;

Vehicle car1 = vehicleFactory.CreateVehicle("car");
Vehicle bike1 = vehicleFactory.CreateVehicle("bike");

car1.Drive();
bike1.Drive();
