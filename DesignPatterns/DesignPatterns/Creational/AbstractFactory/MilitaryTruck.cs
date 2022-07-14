using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory
{
    internal class MilitaryTruck : ITruck
    {
        public DateTime GetDeliveryExtimateTime() => DateTime.Now.AddDays(4);

        public double GetMaxWeight() => 15000.00;
    }
}
