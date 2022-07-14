using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    internal class CommercialFactory : TransportAbstractFactory
    {
        public override IPlane CreatePlane() => new CommercialPlane();

        public override ITruck CreateTruck() => new CommercialTruck();
    }
}
