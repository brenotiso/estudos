using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Common;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Proxy;
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
var vehicle = VehicleFactory.CreateVehicle(VehicleType.Truck);
Console.WriteLine("Truck extimation delivery: {0}", vehicle.GetDeliveryExtimateTime());

vehicle = VehicleFactory.CreateVehicle(VehicleType.Plane);
Console.WriteLine("Plane extimation delivery: {0}", vehicle.GetDeliveryExtimateTime());
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
    Author = new Person()
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

#region Adapter
var mapService = new MapService();
var coordinateHandler = new MapServiceAdapter(mapService);

var decimalCoordinate = new DecimalCoordinate(40.446, -79.982);

Console.WriteLine("Map from adapter: {0} {1}", coordinateHandler.GetMap(decimalCoordinate), Environment.NewLine);
#endregion Adapter

#region Bridge
var albumResource = new AlbumResource(new Album() { Title = "Album X", Band = "SuperBand", Year = 2010, Songs = 12, Minutes = 105 });
var cardView = new CardView(albumResource);
var shortView = new ShortView(albumResource);

Console.WriteLine("Bridge cardView Album: {0}", cardView.ShowInfo());
Console.WriteLine("Bridge shortView Album: {0}", shortView.ShowInfo());

var authorResource = new AuthorResource(new Author() { Name = "Jhon Jones", Nickname = "JJ", Biography = "blá blá blá", Country = "Brazil" });
cardView.SetResource(authorResource);
shortView.SetResource(authorResource);

Console.WriteLine("Bridge cardView with Author: {0}", cardView.ShowInfo());
Console.WriteLine("Bridge shortView Author: {0}", shortView.ShowInfo());
Console.Write(Environment.NewLine);
#endregion Bridge

#region Composite 
var invoice1 = new Invoice(10);
var invoice2 = new Invoice(15);
var invoice3 = new Invoice(18);

var order1 = new Order();
var order2 = new Order();
order1.Add(invoice1);
order2.Add(invoice2);
order2.Add(invoice3);

var negociation = new Negociation();
negociation.Add(order1);
negociation.Add(order2);

Console.WriteLine("Total of negociation: {0} {1}", negociation.GetTotal(), Environment.NewLine);
#endregion Adapter

#region Decorator 
IRepository<User> userRepository = new UserRepository();
var userRepositoryDecorated = new RepositoryLoggerDecorator<User>(userRepository);

var user = userRepositoryDecorated.GetById(1);
Console.WriteLine("User: {0} {1}", JsonSerializer.Serialize(user), Environment.NewLine);
#endregion Adapter

#region Proxy 
IDataService dataService = new DataService();
IDataService dataServiceProxy = new DataServiceProxy(dataService);

var getEncryptedData = (IDataService dataService) => dataService.GetEncryptedData();

Console.WriteLine("Result from proxy: {0} {1}", getEncryptedData(dataServiceProxy), Environment.NewLine);
#endregion Adapter

#region Chain of Responsability
var authenticationHandler = new AuthenticationHandler();
var authorizationHandler = new AuthorizationHandler();

authenticationHandler.SetNext(authorizationHandler);

authenticationHandler.Handle("new request");
Console.WriteLine();
#endregion Chain of Responsability

#region Command
ISwitchable lamp = new Light();

ICommand switchClose = new CloseSwitchCommand(lamp);
ICommand switchOpen = new OpenSwitchCommand(lamp);

Switch @switch = new Switch(switchClose, switchOpen);
@switch.Open();
@switch.Close();
#endregion Command

#region Iterator
var collection = new WordsCollection();
collection.AddItem("1");
collection.AddItem("2");
collection.AddItem("3");

Console.WriteLine("Straight traversal:");
foreach (var element in collection)
    Console.WriteLine(element);


collection.ReverseDirection();

Console.WriteLine("\nReverse traversal:");
foreach (var element in collection)
    Console.WriteLine(element);
Console.WriteLine();
#endregion Iterator

#region Mediator
Component1 component1 = new();
Component2 component2 = new();
_ = new ConcreteMediator(component1, component2);

Console.WriteLine("Client triggets operation A.");
component1.DoA();

Console.WriteLine();

Console.WriteLine("Client triggers operation D.");
component2.DoD();

Console.WriteLine();
#endregion Mediator

#region Memento
var semaphore = new MySemaphore();
var caretaker = new MySemaphoreCaretaker(semaphore);

caretaker.Backup();
semaphore.ChangeLight();

caretaker.Backup();
semaphore.ChangeLight();

caretaker.Backup();
semaphore.ChangeLight();

Console.WriteLine("Memento history:");
caretaker.ShowHistory();

Console.WriteLine("\nClient rollback:");
caretaker.Undo();
caretaker.Undo();

Console.WriteLine();
#endregion Memento

#region Observer
Stock ibm = new Stock("IBM", 120.00);
ibm.Attach(new Investor("Sorros"));
ibm.Attach(new Investor("Berkshire"));

ibm.Price = 120.10;
Console.WriteLine();
ibm.Price = 121.00;
Console.WriteLine();
ibm.Price = 120.50;

Console.WriteLine();
#endregion Memento

#region State
Account account = new Account("Jhon Jones");

account.Deposit(500.0);
account.Deposit(300.0);
account.Deposit(550.0);
account.PayInterest();
account.Withdraw(2000.00);
account.Withdraw(1100.00);

Console.WriteLine();
#endregion State

#region Strategy
var context = new Context();

Console.WriteLine("Client: Strategy is set to ASC sorting.");
context.SetStrategy(new AcendingStrategy());
context.DoSomeBusinessLogic();

Console.WriteLine();

Console.WriteLine("Client: Strategy is set to DESC sorting.");
context.SetStrategy(new DescendingStrategy());
context.DoSomeBusinessLogic();

Console.WriteLine();
#endregion Strategy

#region Template Method
var pdfProcessor = new PdfProcessor();
pdfProcessor.Run("report.pdf");

var docProcessor = new DocProcessor();
docProcessor.Run("jun_results.doc");
#endregion Template Method

#region Visitor
var employee = new Employees();

employee.Attach(new Director());
employee.Attach(new President());

employee.Accept(new IncomeVisitor());
employee.Accept(new VacationVisitor());
#endregion Visitor
