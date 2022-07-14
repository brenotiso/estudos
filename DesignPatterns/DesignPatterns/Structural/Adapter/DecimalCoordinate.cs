namespace DesignPatterns.Structural.Adapter
{
    internal class DecimalCoordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public DecimalCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
