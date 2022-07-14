namespace DesignPatterns.Creational.Builder
{
    internal class Car
    {
        public string Name { get; set; } = String.Empty;
        public int Seats { get; set; } = 0;
        public bool HasAirbag { get; set; } = false;
        public bool HasABS { get; set; } = false;
        public int HorsePower { get; set; } = 0;
    }
}
