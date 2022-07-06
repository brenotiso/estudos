using DesignPatterns.Common;
using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.FactoryMethod
{
    internal class VehicleFactory
    {
        public static ITransport CreateVehicle(VehicleType vehicleType)
        {
            return vehicleType switch
            {
                VehicleType.Truck => new Truck(),
                VehicleType.Plane => new Plane(),
                _ => throw new ArgumentException("Vehicle not expected", "vehicleType"),
            };
        }
    }
}
