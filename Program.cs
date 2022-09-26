
#region Creational Singleton Pattern
//using Singleton;

//var logger1 = Logger1.Instance;
//var logger2 = Logger1.Instance;

//if (logger1 == logger2 && logger2 == Logger1.Instance) {
//    Console.WriteLine("same instance message");
//}

//Logger1.Log($"message from {nameof(logger1)}");
//Logger1.Log($"message from {nameof(logger2)}");
//Logger1.Log($"message from {nameof(Logger1.Instance)}");


//// another good method
//var logger3 = Logger.Instance;
//var logger4 = Logger.Instance;

//if (logger3 == logger4 && logger4 == Logger.Instance) {
//    Console.WriteLine("same instance message");
//}

//Logger.Log($"message from {nameof(logger3)}");
//Logger.Log($"message from {nameof(logger4)}");
//Logger.Log($"message from {nameof(Logger.Instance)}");
#endregion

#region Creational Patter: Factory
//using ConsoleAppExceptionHandler.Factory;

//Console.Title = "Factory Method";

//var factories = new List<DiscountFactory> {
//    new CodeDiscountFactory(Guid.NewGuid()),
//    new CountryDiscountFactory("BE")
//};

//foreach(var factory in factories) {
//    var discountService = factory.CreateDiscountService();
//    Console.WriteLine($"Percentage {discountService.DiscountPercentage} coming from {discountService}");
//}
//Console.ReadKey();

#endregion

#region Creational Abstract Faktory
//using ConsoleAppExceptionHandler._3___Abtract_Factory;

//Console.Title = "Abstract Factory";

//var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
//var shoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
//shoppingCartForBelgium.CanculateCosts();

//var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
//var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
//shoppingCartForFrance.CanculateCosts();

#endregion

#region Creational Builder Design Pattern
//using ConsoleAppExceptionHandler._4___Builder;

//Console.Title = "Builder";

//var garage = new Garage();
//var miniBuilder = new MiniBuilder();
//var bmwBuilder = new BMVBuilder();

//garage.Construct(miniBuilder);
////Console.WriteLine(miniBuilder.Car.ToString());
//// or:
//garage.Show();

//garage.Construct(bmwBuilder);
////Console.WriteLine(bmwBuilder.Car.ToString());

//// or:
//garage.Show();

//Console.ReadLine();
#endregion

#region Creational Patter Prototype
//using ConsoleAppExceptionHandler._5___Prototype;

//Console.Title = "Prototype";
//var manager = new Manager("Cindy");
//var managerClone = (Manager)manager.Clone(true);
//Console.WriteLine($"Manager was cloned: {managerClone.Name}");

//var employee = new Employee("Kevin", managerClone);
//var employeeClone = (Employee)employee.Clone(true);
//Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with Manager: {employeeClone.Manager.Name}");


//// change the manager name
//managerClone.Name = "Karen";
//Console.WriteLine($"Employee was cloned: {employeeClone.Name}, with manager {employeeClone.Manager.Name}");


//Console.ReadLine();
#endregion

#region Structural Pattern Adapter
//using ConsoleAppExceptionHandler._6___Structural_Pattern_Adapter;

//Console.Title = "Adapter";

//// object adapter example
//ICityAdapter adapter = new CityAdapter();
//var city = adapter.GetCity();
//Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
//Console.ReadLine();
#endregion

#region Structural Pattern Bridge
//using ConsoleAppExceptionHandler._8___Bridge;

//Console.Title = "Bridge";

//var noCoupon = new NoCoupon();
//var oneEuroCoupon = new OneEuroCoupon();
//var twoEuroCoupon = new TwoEuroCoupon();

//var meatBaseMenu = new MeatBasedMenu(noCoupon);
//Console.WriteLine($"Meat based menu, no coupon: {meatBaseMenu.CalculatePrice()} euro");

//meatBaseMenu = new MeatBasedMenu(oneEuroCoupon);
//Console.WriteLine($"Meat based menu, no coupon: {meatBaseMenu.CalculatePrice()} euro");


//var vegetarianMenu = new VegataarianMenu(noCoupon);
//Console.WriteLine($"Vegetarian based menu, no coupon: {vegetarianMenu.CalculatePrice()} euro");

//vegetarianMenu = new VegataarianMenu(oneEuroCoupon);
//Console.WriteLine($"Vegetarian based menu, one coupon: {vegetarianMenu.CalculatePrice()} euro");

//Console.ReadLine();
#endregion

#region Structural Pattern: Decorator
//using ConsoleAppExceptionHandler._7___Structural_Pattern_Decorator;

//Console.Title = "Decorator";

//// instantiated mail service
//var cloudMailService = new CloudMailService();
//cloudMailService.SendMail("Hi there.");

//var premiseMailService = new OnPremiseMailService();
//premiseMailService.SendMail("Hi tehre.");

//// add behavior
//var statisitcMailService = new StatisticDecorator(cloudMailService);
//statisitcMailService.SendMail($"Hi there via {nameof(StatisticDecorator)} wrapper.");

//// add behavior
//var messageDatabaseDecorator = new MessageDatabaseDecorator(premiseMailService);
//messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper 1.");
//messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper 2.");

//foreach (var message in messageDatabaseDecorator.SentMessages) {
//    Console.WriteLine($"stored message \"{message} \"");
//}
#endregion

#region Structural Pattern: Composite
//Console.Title = "Composite";
//var root = new Composite.Directory("root", 0);
//var topLevelFile = new Composite.Directory("toplevel.txt", 100);
//var topLevelDirectory1 = new Composite.Directory("topleveldirectory1", 4);
//var topLevelDirectory2 = new Composite.Directory("topleveldirectory2", 4);

//root.Add(topLevelFile);
//root.Add(topLevelDirectory1);
//root.Add(topLevelDirectory2);

//var sublevelFile1 = new Composite.File("sublevelFile1.txt", 200);
//var sublevelFile2 = new Composite.File("sublevelFile2.txt", 150);

//topLevelDirectory2.Add(sublevelFile1);
//topLevelDirectory2.Add(sublevelFile2);

//Console.WriteLine($"size of topLevelDirectory1: {topLevelDirectory1.GetSize()}");
//Console.WriteLine($"size of topLevelDirectory2: {topLevelDirectory2.GetSize()}");
//Console.WriteLine($"size of root: {root.GetSize()}");

#endregion

#region Structural Pattern: Facade
//using ConsoleAppExceptionHandler._10___Structural_Pattern_Facade;

//Console.Title = "Facade";

//var facade = new DiscountFacate();
//Console.WriteLine($"Discount percentage for customer with id 1:"+
//    $"{facade.CalculateDiscountPercentage(1)}");

//Console.WriteLine($"Discount percentage for customer with id 10:" +
//    $"{facade.CalculateDiscountPercentage(10)}");

//Console.ReadLine();
#endregion

#region Structural Pattern: Proxy
//using System.Reflection.Metadata;

//Console.Title = "Proxy";

//// without proxy
//Console.WriteLine("Constructing document.");
//var myDocument = new Proxy.Document("MyDocument.pdf");
//Console.WriteLine("Document Contuructor.");
//myDocument.DisplayDocument();

//Console.WriteLine();

//// with proxy
//Console.WriteLine("Constructing document proxy.");
//var myDocumentProxy = new Proxy.DocumentProxy("MyDocumentProxy.pdf");
//Console.WriteLine("Document proxy constructed.");
//myDocumentProxy.DisplayDocument();

//Console.WriteLine();

//// with chained proxy
//Console.WriteLine("Constructing protected document proxy. ");
//var myProtectedDocumentProxy = new Proxy.ProtectedDocumentProxy("MyDocument.pdf", "Viewer");
//Console.WriteLine("Protected document constructed.");
//myProtectedDocumentProxy.DisplayDocument();

#endregion

#region Structural Pattern: Flyweight
//using Flyweight;
//using System.Diagnostics.Contracts;

//Console.Title = "Flyweight";

//var aBunchOfCharacters = "abba";
//var characterFactory = new CharacterFactory();

//// Get the flyweight(s)
//var characterObject = characterFactory.GetCharacter(aBunchOfCharacters[0]);
//// Pass through extrinsic state
//characterObject?.Draw("Arial", 12);

//characterObject = characterFactory.GetCharacter(aBunchOfCharacters[1]);
//characterObject?.Draw("Trebuchet MS", 14);


//characterObject = characterFactory.GetCharacter(aBunchOfCharacters[2]);
//characterObject?.Draw("Times New Roman", 16);

//characterObject = characterFactory.GetCharacter(aBunchOfCharacters[3]);
//characterObject?.Draw("Comic Sans", 18);

//// create unshared concrate fşyweight (paragraph)
//var paragraph = characterFactory.CreateParagraph(new List<ICharacter>() { characterObject }, 1);
//paragraph?.Draw("Lucinda", 12);

//Console.ReadLine();
#endregion

#region Behavioral Pattern: Template Method
//using Template_Method;

//Console.Title = "Template Method";
//ExchangeMailParser ExchangeMailParser = new();
//Console.WriteLine(ExchangeMailParser.ParseMailBody("bf3a298c-9990-4b02-873d-3d3c98ad16d2"));
//Console.WriteLine();

//ApacheMailParser apacheMailParser = new();
//Console.WriteLine(apacheMailParser.ParseMailBody("bf3a298c-9990-4b02-873d-3d3c98ad16d2"));
//Console.WriteLine();


//EudoraMailServer eudoraMailServer = new();
//Console.WriteLine(eudoraMailServer.ParseMailBody("bf3a298c-9990-4b02-873d-3d3c98ad16d2"));
//Console.WriteLine();
#endregion

#region Behavioral Pattern: Strategy
//using Strategy;

//Console.Title = "Strategy";

//var order = new Order("Marvin SOftware", 5, "Visual Studio License");
//order.Export(new CSVExportService());
//order.Export(new JsonExportService());

#endregion

#region Behavioral Pattern: Command
//using Command;

//Console.Title = "Command";

//CommandManager commandManager = new();
//IEmployeeManagerRepository repository = new EmployeeManagerRepository();

//commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(111, "Osman")));
//repository.WriteDataStor();

//commandManager.Undo();
//repository.WriteDataStor();

//commandManager.Invoke(new AddEmployeeToManagerList(repository, 2, new Employee(112, "Hale")));
//repository.WriteDataStor();

//commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(113, "Ayla")));
//repository.WriteDataStor();


//commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(113, "Ayla")));
//repository.WriteDataStor();

//commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(113, "Ayla")));
//repository.WriteDataStor();


//commandManager.UndoAll();
//repository.WriteDataStor();

//Console.ReadLine();

#endregion

#region Behavioral Pattern: Memento
//using Memento;

//Console.Title = "Command";

//CommandManager commandManager = new();
//IEmployeeManagerRepository repository = new EmployeeManagerRepository();

//commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(111, "Osman")));
//repository.WriteDataStor();

//commandManager.Undo();
//repository.WriteDataStor();

//commandManager.Invoke(new AddEmployeeToManagerList(repository, 2, new Employee(112, "Hale")));
//repository.WriteDataStor();

//commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(113, "Ayla")));
//repository.WriteDataStor();


//commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(113, "Ayla")));
//repository.WriteDataStor();

//commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(113, "Ayla")));
//repository.WriteDataStor();


//commandManager.UndoAll();
//repository.WriteDataStor();

//Console.ReadLine();
#endregion

#region Behavioral Pattern: Mediator
//using Pattern_Mediator;

//Console.Title = "Mediator";

//TeamChatRoom teamChatRoom = new();

//var sven = new Lawyer("Sven");
//var kenneth = new Lawyer("Kenneth");
//var ann = new AccountManager("Ann");
//var john = new AccountManager("John");
//var kylie = new AccountManager("Kylie");

//teamChatRoom.Register(sven);
//teamChatRoom.Register(kenneth);
//teamChatRoom.Register(ann);
//teamChatRoom.Register(john);
//teamChatRoom.Register(kylie);

//ann.Send("Hi everyone, can someone have a look at file ABC123? I need a compliance check");
//sven.Send("On it");
//sven.Send("Ann", "Could you join me in a Teams call?");

//sven.Send("ann","All good");
//ann.SendTo<AccountManager>("The file was approved!");


//Console.ReadKey();

#endregion

#region Behavioral Pattern: Chain of Responsibility
//using Pattern_Chain_of_Responsibility;
//using System.ComponentModel.DataAnnotations;

//Console.Title = "Chain of Responsibility";

//var validDocument = new Document("How to Avoid Java Development", DateTimeOffset.UtcNow, true, true);
//var invalidDocument = new Document("How ro Avoid Java Development", DateTimeOffset.UtcNow, false, true);

//var documentHandlerChain = new DocumentTitleHandler();
//documentHandlerChain.SetSuccessor(new DocumentLastModifiedHandler())
//                    .SetSuccessor(new DocumentApprovedBylitigationHandler())
//                    .SetSuccessor(new DocumentApprovedByManagementHandler());

//try {
//    documentHandlerChain.Handle(validDocument);
//    Console.WriteLine("Valid document is valid");

//    documentHandlerChain.Handle(invalidDocument);
//    Console.WriteLine("invalid document is valid");
//}
//catch (ValidationException validationexeption) {

//    Console.WriteLine(validationexeption.Message);
//}

#endregion

#region Behavioral Pattern: Observer
//using Behavioral_Pattern_Observer;

//Console.Title = "Observer";

//TicketStockService ticketStockService = new();
//TicketResellerService ticketResellerService = new();
//OrderService orderService = new();

//// add two observers
//orderService.AddObserver(ticketStockService);
//orderService.AddObserver(ticketResellerService);

////notfy
//orderService.ComplateTicketSale(1, 2);
//Console.WriteLine();

//// remove one observer
//orderService.RemoveObserver(ticketStockService);

//// notify
//orderService.ComplateTicketSale(2, 4);

//Console.ReadKey();

#endregion

#region Behavioral Pattern: State
//using Behavioral_Pattern_State;

//Console.Title = "State";

//BankAccount bankAccount = new();
//bankAccount.Deposit(100);
//bankAccount.Withdraw(500);
//bankAccount.Withdraw(100);


//// deposit enough to go to gold
//bankAccount.Deposit(2000);
////should be in gold now
//bankAccount.Deposit(100);
//// back to overdraw
//bankAccount.Withdraw(3000);
//// should transition to regular
//bankAccount.Deposit(3000);
//// should still be in regular
//bankAccount.Deposit(100);


//Console.ReadLine();
#endregion

#region Behavioral Pattern: Iterator
//using Pattern_Iterator;

//Console.Title = "Iterator";

//// create the collection 
//PeopleCollection people = new();

//people.Add(new Person("Thomas Claudius", "German"));
//people.Add(new Person("Kevin Dockx", "Belgium"));
//people.Add(new Person("Gill Cleeren", "Belgium"));
//people.Add(new Person("Roland Guijt", "The Netherlands"));


//// create teh iterator
//var peopleIterator = people.CreateIterator();

//// use the iterator to run through the people
//// in the collection; they should come out
//// in alphebetical order
//for (Person person = peopleIterator.First(); !peopleIterator.IsDone;  person = peopleIterator.Next()) {
//    Console.WriteLine(person?.Name);
//}

//Console.ReadKey();
#endregion

#region Behavioral Pattern: Visitor
//using Visitor;

//Console.Title = "Visitor";

//// create container & add concrete elements
//var container = new Container();
//container.Customers.Add(new Customer("Sophie", 500));
//container.Customers.Add(new Customer("Karen", 1000));
//container.Customers.Add(new Customer("Sven", 800));
//container.Employees.Add(new Employee("Kevin", 18));
//container.Employees.Add(new Employee("Tom", 5));

//// create visitor
//DiscountVisitor discountVisitor = new();

//// pass it through
//container.Accept(discountVisitor);

//// write out gathered amount
//Console.WriteLine($"Total discount: {discountVisitor.TotalDiscountGiven}");

#endregion

#region Behavioral Pattern: Interpreter
using Interpreter;

Console.Title = "Interpreter";
var expressions = new List<RomanExpression> {
    new RomanHundredExpression(),
    new RomanTenExpression(),
    new RomanOneExpression()
};

int NUMBER = 3;
var context = new RomanContext(NUMBER);
foreach (var expression in expressions) {
    expression.Interpret(context);
}
Console.WriteLine($"Translating Arabic numerals to Roman numerals: {NUMBER} = {context.Output}");

NUMBER = 81;
context = new RomanContext(NUMBER);
foreach (var expression in expressions) {
    expression.Interpret(context);
}
Console.WriteLine($"Translating Arabic numerals to Roman numerials: {NUMBER} = {context.Output}");

NUMBER = 333;
context = new RomanContext(NUMBER);
foreach (var expression in expressions) {
    expression.Interpret(context);
}
Console.WriteLine($"Translating Arabic numerals to Roman numericals: {NUMBER} = {context.Output}");

Console.ReadKey();
#endregion