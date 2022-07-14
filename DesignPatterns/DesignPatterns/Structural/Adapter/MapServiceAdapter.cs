namespace DesignPatterns.Structural.Adapter
{
    internal class MapServiceAdapter : ICoordinateHandler
    {
        private readonly MapService _mapService;

        public MapServiceAdapter(MapService mapService)
        {
            _mapService = mapService;
        }

        public string GetMap(DecimalCoordinate coordinate)
        {
            int latitudeDegrees = (int)Math.Truncate(coordinate.Latitude);
            double minutes = coordinate.Latitude % 1 * 60;
            int latitudeMinutes = (int)Math.Truncate(minutes);
            double seconds = minutes % 1 * 60;
            int latitudeSeconds = (int)Math.Truncate(seconds);
            char latitudeDirection = coordinate.Latitude > 0 ? 'N' : 'S';

            int longitudeDegrees = (int)Math.Truncate(coordinate.Longitude);
            minutes = coordinate.Longitude % 1 * 60;
            int longitudeMinutes = (int)Math.Truncate(minutes);
            seconds = minutes % 1 * 60;
            int longitudeSeconds = (int)Math.Truncate(seconds);
            char longitudeDirection = coordinate.Longitude > 0 ? 'E' : 'W';

            return _mapService.GetMap(
                latitudeDegrees,
                latitudeMinutes,
                latitudeSeconds,
                latitudeDirection,
                longitudeDegrees,
                longitudeMinutes,
                longitudeSeconds,
                longitudeDirection);
        }
    }
}
