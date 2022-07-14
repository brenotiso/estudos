namespace DesignPatterns.Structural.Adapter
{
    internal class MapService
    {
        public string GetMap(
            int latitudeDegrees,
            int latitudeMinutes,
            int latitudeSeconds,
            char latitudeDirection,
            int longitudeDegrees,
            int longitudeMinutes,
            int longitudeSeconds,
            char longitudeDirection)
        {
            return $"Map for {latitudeDegrees}º {latitudeMinutes}' {latitudeSeconds}'' {latitudeDirection} " +
                $"{longitudeDegrees}º {longitudeMinutes}' {longitudeSeconds}'' {longitudeDirection}";
        }
    }
}
