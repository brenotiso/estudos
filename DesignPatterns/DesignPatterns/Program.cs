using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Common;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton;
using System.Text.Json;

#region Singleton
var tokenProvider = TokenProviderSingleton.GetInstance();
Console.WriteLine("Token 1: {0} - {1}", tokenProvider.GetToken(), tokenProvider.GetHashCode());

Thread.Sleep(10);

tokenProvider = TokenProviderSingleton.GetInstance();
Console.WriteLine("Token 2: {0} - {1}", tokenProvider.GetToken(), tokenProvider.GetHashCode());
Console.Write(Environment.NewLine);
#endregion Fim Singleton


#region Factory Method
var transport = VehicleFactory.CreateVehicle(VehicleType.Truck);
Console.WriteLine("Truck extimation delivery: {0}", transport.GetDeliveryExtimateTime());

transport = VehicleFactory.CreateVehicle(VehicleType.Plane);
Console.WriteLine("Plane extimation delivery: {0}", transport.GetDeliveryExtimateTime());
Console.Write(Environment.NewLine);
#endregion Fim Factorie

#region Abstract Factory
var transportFactory = TransportFactoryProducer.CreateFactory(TransportType.Military);
var truck = transportFactory.CreateTruck();
var plane = transportFactory.CreatePlane();
Console.WriteLine("Truck max weigth: {0}", truck.GetMaxWeight());
Console.WriteLine("Plane max altitude: {0}", plane.GetMaxAltitudeInKilometers());

transportFactory = TransportFactoryProducer.CreateFactory(TransportType.Commercial);
truck = transportFactory.CreateTruck();
plane = transportFactory.CreatePlane();
Console.WriteLine("Truck max weigth: {0}", truck.GetMaxWeight());
Console.WriteLine("Plane max altitude: {0}", plane.GetMaxAltitudeInKilometers());
Console.Write(Environment.NewLine);
#endregion Fim Factorie

#region Prototype
var document = new Document()
{
    Name = "teste.doc",
    Description = "teste",
    Path = "c:/docs",
    Author = new Author()
    {
        Name = "Jhon Jones",
        Nickname = "JJ"
    }
};
Console.WriteLine("Document 1: {0} - {1}; Author {2}", JsonSerializer.Serialize(document), document.GetHashCode(), document.Author.GetHashCode());
var documentClone = (Document)document.Clone();
Console.WriteLine("Document Clone: {0} - {1}; Author {2}", JsonSerializer.Serialize(documentClone), documentClone.GetHashCode(), documentClone?.Author?.GetHashCode());
Console.Write(Environment.NewLine);
#endregion Fim Prototype

#region Builder
var carBuilder = new CarBuilder();
var car = carBuilder
    .Reset()
    .SetName("Car")
    .SetSeats(5)
    .SetHorsePower(210)
    .HasABS(true)
    .HasAirbag(true)
    .Build();

Console.WriteLine("Car: {0}", JsonSerializer.Serialize(car));
Console.Write(Environment.NewLine);
#endregion Builder
