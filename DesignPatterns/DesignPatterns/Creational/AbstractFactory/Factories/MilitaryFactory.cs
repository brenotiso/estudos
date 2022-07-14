using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    internal class MilitaryFactory : TransportAbstractFactory
    {
        public override IPlane CreatePlane() => new MilitaryPlane();

        public override ITruck CreateTruck() => new MilitaryTruck();
    }
}
