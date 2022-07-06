using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal abstract class TransportAbstractFactory
    {
        public abstract ITruck CreateTruck();

        public abstract IPlane CreatePlane();
    }
}
