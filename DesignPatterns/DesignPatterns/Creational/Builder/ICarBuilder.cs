namespace DesignPatterns.Creational.Builder
{
    internal interface ICarBuilder
    {
        ICarBuilder SetName(string name);
        ICarBuilder SetSeats(int value);
        ICarBuilder SetHorsePower(int value);
        ICarBuilder HasAirbag(bool value);
        ICarBuilder HasABS(bool value);
        ICarBuilder Reset();
        Car Build();
    }
}
