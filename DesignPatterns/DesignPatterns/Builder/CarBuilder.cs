namespace DesignPatterns.Builder
{
    internal class CarBuilder : ICarBuilder
    {
        private Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public ICarBuilder Reset()
        {
            car = new Car();
            return this;
        }

        public Car Build() => car;

        public ICarBuilder HasABS(bool value)
        {
            car.HasABS = value;
            return this;
        }

        public ICarBuilder HasAirbag(bool value)
        {
            car.HasAirbag = value;
            return this;
        }

        public ICarBuilder SetHorsePower(int value)
        {
            car.HorsePower = value;
            return this;
        }

        public ICarBuilder SetName(string name)
        {
            car.Name = name;
            return this;
        }

        public ICarBuilder SetSeats(int value)
        {
            car.Seats = value;
            return this;
        }
    }
}
