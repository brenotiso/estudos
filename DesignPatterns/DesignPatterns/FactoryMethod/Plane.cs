using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.FactoryMethod
{
    internal class Plane : ITransport
    {
        public DateTime GetDeliveryExtimateTime() => DateTime.Now.AddDays(2);
    }
}
