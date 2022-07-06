using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class CommercialPlane : IPlane
    {
        public DateTime GetDeliveryExtimateTime() => DateTime.Now.AddDays(2);

        public double GetMaxAltitudeInKilometers() => 6.0;
    }
}
