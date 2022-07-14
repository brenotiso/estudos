using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class CommercialPlane : IPlane
    {
        public DateTime GetDeliveryExtimateTime() => DateTime.Now.AddDays(2);

        public double GetMaxAltitudeInKilometers() => 6.0;
    }
}
