using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.FactoryMethod
{
    internal class Truck : ITransport
    {
        public DateTime GetDeliveryExtimateTime() => DateTime.Now.AddDays(4);
    }
}
