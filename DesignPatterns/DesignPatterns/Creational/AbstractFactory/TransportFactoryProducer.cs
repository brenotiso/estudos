using DesignPatterns.Common;
using DesignPatterns.Creational.AbstractFactory.Factories;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class TransportFactoryProducer
    {
        public static TransportAbstractFactory CreateFactory(TransportType transportType)
        {
            return transportType switch
            {
                TransportType.Military => new MilitaryFactory(),
                TransportType.Commercial => new CommercialFactory(),
                _ => throw new ArgumentException("Transport not expected", "transportType"),
            };
        }
    }
}
