using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class CommercialTruck : ITruck
    {
        public DateTime GetDeliveryExtimateTime() => DateTime.Now.AddDays(4);

        public double GetMaxWeight() => 22000.00;
    }
}
