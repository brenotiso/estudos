﻿using DesignPatterns.Common.Interfaces;

namespace DesignPatterns.AbstractFactory
{
    internal class MilitaryPlane : IPlane
    {
        public DateTime GetDeliveryExtimateTime() => DateTime.Now.AddDays(1);

        public double GetMaxAltitudeInKilometers() => 5.3;
    }
}
