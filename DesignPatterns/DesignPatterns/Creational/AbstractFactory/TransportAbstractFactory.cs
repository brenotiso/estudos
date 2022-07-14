using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal abstract class TransportAbstractFactory
    {
        public abstract ITruck CreateTruck();

        public abstract IPlane CreatePlane();
    }
}
