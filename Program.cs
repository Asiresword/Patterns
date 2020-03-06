using System;
using Patterns.DesignPatterns.Creational.AbstractFactory;
using Patterns.DesignPatterns.Creational.Factory;
using Patterns.DesignPatterns.Creational.Singleton;
using Patterns.DesignPatterns.Creational.Prototype;
using Patterns.DesignPatterns.Creational.Builder;
using Patterns.DesignPatterns.Behavioural.Strategy;
using Patterns.DesignPatterns.Behavioural.Observer;
using Patterns.DesignPatterns.Behavioural.Command;
using Patterns.DesignPatterns.Behavioural.Template;
using Patterns.DesignPatterns.Behavioural.Iterator;
using Patterns.DesignPatterns.Behavioural.State;
using Patterns.DesignPatterns.Behavioural.ChainOfResposibility;
using Patterns.DesignPatterns.Behavioural.Interpreter;
using Patterns.DesignPatterns.Behavioural.Mediator;
using Patterns.DesignPatterns.Behavioural.Memento;
using Patterns.DesignPatterns.Behavioural.Visitor;
using Patterns.DesignPatterns.Structural.Decorator;
using Patterns.DesignPatterns.Structural.Adapter;
using Patterns.DesignPatterns.Structural.Facade;
using Patterns.DesignPatterns.Structural.Composite;
using Patterns.DesignPatterns.Structural.Proxy;
using Patterns.DesignPatterns.Structural.Bridge;
using Patterns.DesignPatterns.Structural.Flyweight;

namespace Patterns
{
    class Program
    {
        public static void Separator()
        {
            Console.WriteLine(new string('-', 30));
        }

        internal static void Main()
        {
            #region Creational patterns

            #region Factory Design Pattern
            /*
                Factory Method - a design pattern, that defines a common interface for creating objects in a superclass, 
                                 allowing subclasses to change the type of objects, that being created.
                Difficulty: 1 / 3
                Popularity: 3 / 3
                    When to use:
                        1. When it is not known, what types of objects you need to create.
                        2. When the system should be expandable and independent of the process of creating new objects.
                        3. When you want to allow users to expand parts of your framework or library.
                        4. When the creation of new objects must be delegated from the base class to the inherited classes.
            */

            CarFactory Factory = new ToyotaFactory("Highlander");
            Console.WriteLine(Factory.CreateCar().Model);

            Factory = new NissanFactory("Qashqai");
            Console.WriteLine(Factory.CreateCar().Model);
            #endregion

            Separator();

            #region Abstract Factory Design Pattern
            /*
                Abstract Factory - a design pattern, that allows you to create groups of related objects 
                                   without being tied to specific classes of created objects.
                Difficulty: 2 / 3
                Popularity: 3 / 3
                    When to use:
                        1. When a system needs to work with different types of related products, independent of specific product classes.
                        2. When created objects should be used together and are interconnected.
                        3. When a system already uses a Factory Method, but further changes involve the introduction of new types of products.
            */

            PC NIPC = new PC(new NIPCFactory());
            Console.WriteLine(NIPC.CPUInfo());
            Console.WriteLine(NIPC.GPUInfo());

            PC AMDPC = new PC(new AMDPCFactory());
            Console.WriteLine(AMDPC.CPUInfo());
            Console.WriteLine(AMDPC.GPUInfo());
            #endregion

            Separator();

            #region Singleton Design Pattern
            /*
                Singleton - a design pattern, that ensures that the class has only one instance 
                            and provides a global access point to it.
                Difficulty: 1 / 3
                Popularity: 2 / 3
                    When to use:
                        1. When you want a class to have only one instance.
            */

            Company company = new Company();
            Company company1 = new Company();

            Console.WriteLine(company.GetDirectorName()); // %Director_Name%
            Console.WriteLine(company1.GetDirectorName()); // %Director_Name%

            company.SetDirectorName("Company one director");

            Console.WriteLine(company.GetDirectorName()); // Company one director
            Console.WriteLine(company1.GetDirectorName()); // Company one director
            #endregion

            Separator();

            #region Prototype Design Pattern
            /*
                Prototype - a design pattern, that allows you to copy previously created prototype objects.
                Difficulty: 1 / 3
                Popularity: 2 / 3
                    When to use:
                        1. When a particular type of object to be created must be dynamically determined at run time.
                        2. When it is undesirable to create a separate class hierarchy of factories 
                                          to create product objects from a parallel class hierarchy.
                        3. When cloning an object is a preferable option than creating and initializing it using the constructor.
            */

            IPaper Paper = new BookPaper();
            IPaper PaperClone = Paper.Clone();

            Console.WriteLine(Paper.PaperInfo());
            Console.WriteLine(PaperClone.PaperInfo());

            Paper = new PrintablePaper();
            // PaperClone = Paper.Clone();

            Console.WriteLine(Paper.PaperInfo());
            Console.WriteLine(PaperClone.PaperInfo());
            #endregion

            Separator();

            #region Builder Design Pattern
            /*
                Builder - a design pattern, that allows you to create complex objects step by step.
                Difficulty: 2 / 3
                Popularity: 3 / 3
                    When to use:
                        1. When the process of creating a new object should not depend on 
                           what parts this object consists of and how these parts are related.
                        2. When it is necessary to ensure the receipt of various variations of an object in the process of its creation.
            */

            BedCarpenter Carpenter = new BedCarpenter();

            Bed PoorBed = Carpenter.Build();

            Carpenter.ChangeBuilder(new RichBedBuilder());

            Bed RichBed = Carpenter.Build();

            Console.WriteLine(PoorBed);
            Console.WriteLine();
            Console.WriteLine(RichBed);
            #endregion

            Separator();

            #endregion

            // -------------------------------------------------------------- //

            #region Behavioural patterns

            #region Strategy
            /*
                Strategy - a design pattern, that defines a set of algorithms, 
                           encapsulates each of them and ensures their interchangeability.
                Difficulty: 1 / 3
                Popularity: 3 / 3
                    When to use:
                        1. When you need to use different variants of an algorithm inside one object.
                        2. When there are several related classes that differ in behavior.
                        3. When it is necessary to change the behavior of objects at the program execution stage.
                        4. When a class that uses certain functionality does not need to know anything about its implementation.
            */

            Programmer programmer = new Programmer(new CSLanguage());
            programmer.WriteProgram();

            programmer.SetLanguage(new JSLanguage());
            programmer.WriteProgram();
            #endregion

            Separator();

            #region Observer
            /*
                Observer - a design pattern, that creates a subscription mechanism, that allows objects
                           to monitor and respond to events occurring in other objects.
                Difficulty: 2 / 3
                Popularity: 3 / 3
                    When to use:
                        1. When a system consists of many classes whose objects must be in consistent states.
                        2. When there is one object that sends messages, and many subscribers who receive messages. 
                           Moreover, the exact number of subscribers is not known in advance and the process of the program may change.
                        3. When the general scheme of interaction of objects involves two sides: 
                           one sends messages and is the main one, the other receives messages and responds to them.
                        4. When some objects must observe others, but only in certain cases.
            */

            Server server = new Server();
            SysAdmin admin = new SysAdmin(server);
            Client client = new Client(server);

            server.SetDown(true);
            Console.WriteLine();
            server.SetDown(false);
            #endregion

            Separator();

            #region Command
            /*
                Command - a design pattern, that allows you to encapsulate a request 
                          to perform a specific action as a separate object.
                Difficulty: 2 / 3
                Popularity: 2 / 3
                    When to use:
                        1. When it is necessary to ensure the execution of the request queue, as well as their possible cancellation.
                        2. When it is necessary to support logging of changes as a result of requests.
                        3. When you want to parameterize objects with an action.
            */

            Lighter lighter = new Lighter();
            lighter.SetCommand(new CigaretteCommand());

            lighter.Lit();
            lighter.StopLighter();

            Console.WriteLine();
            lighter.SetCommand(new StoveCommand());

            lighter.Lit();
            lighter.StopLighter();
            #endregion

            Separator();

            #region Template Method
            /*
                Template Method - a design pattern, that defines a general algorithm for the behavior of subclasses, 
                                  allowing them to override the individual steps of this algorithm without changing its structure.
                Difficulty: 1 / 3
                Popularity: 2 / 3
                    When to use:
                        1. When subclasses must extend the basic algorithm without changing its structure.
                        2. When you have several classes doing the same thing with minor differences.
            */

            School school = new School();
            University university = new University();

            school.Start();
            Console.WriteLine();
            university.Start();
            #endregion

            Separator();

            #region Iterator
            /*
                Iterator - a design pattern, which makes it possible to sequentially go around the elements of 
                           composite objects without revealing their internal representation.
                Difficulty: 2 / 3
                Popularity: 3 / 3
                    When to use:
                        1. When it is necessary to bypass an object without revealing its internal structure.
                        2. When you need to provide several alternative options for iterating over the same object.
                        3. When there is a set of composite objects, and you need to provide a single interface for iterating over.
            */

            Warehouse warehouse = new Warehouse();
            Supervisor supervisor = new Supervisor();

            supervisor.SeeProducts(warehouse);
            #endregion

            Separator();

            #region State
            /*
                State - a design pattern, that allows objects to change behavior depending on their state.
                Difficulty: 1 / 3
                Popularity: 2 / 3
                    When to use:
                        1. When the behavior of an object must depend on its state and can change dynamically at run time.
                        2. When the class code contains many large, similar to each other, conditional statements,
                           that select behaviors depending on the current values ​​of the class fields.
            */

            Water water = new Water();
            water.Heat();
            water.Heat();
            water.Frost();
            water.Frost();
            water.Frost();
            #endregion

            Separator();

            #region Chain Of Responsibility
            /*
                Chain Of Responsibility - a design pattern, which allows you to send requests sequentially through a chain of handlers.
                Difficulty: 2 / 3
                Popularity: 1 / 3
                    When to use:
                        1. When there is more than one object that can handle a specific request.
                        2. When it is necessary to transfer a request for execution to one of several objects, 
                           without determining exactly which object.
                        3. When a set of objects capable of processing a request must be set dynamically.
                        4. When it is important that handlers are executed one by one in a strict order.
            */

            TechSupport FirstLine = new FirstLineSupport();
            TechSupport SecondLine = new SecondLineSupport();
            TechSupport ThirdLine = new ThirdLineSupport();

            FirstLine.AddChain(SecondLine);
            SecondLine.AddChain(ThirdLine);

            TechClient techClient = new TechClient(false, true, true);
            FirstLine.Handle(techClient);
            #endregion

            Separator();

            #region Interpreter
            /*
                Interpreter - a design pattern, that defines grammar representation for a given language.
                Difficulty: 3 / 3
                Popularity: 1 / 3
                    When to use:
                        1. When you want to make a binary sequence tree.
                        2. When you want to make your data processing methods and use them in a binary tree.
            */

            InterpretContext Context = new InterpretContext();

            Context.SetVariable("First", 10);
            Context.SetVariable("Second", 5);
            Context.SetVariable("Third", 20);

            IExpression Expression = new SubtractExpression(
                new AddExpression(
                    new ValueExpression("First"), new ValueExpression("Second")
                ),
                new ValueExpression("Third")
            );

            Console.WriteLine(Expression.Interpretate(Context));
            #endregion

            Separator();

            #region Mediator
            /*
                Mediator - a design pattern, that allows the interaction of many objects without the need to refer to each other.
                Difficulty: 2 / 3
                Popularity: 2 / 3
                    When to use:
                        1. When there are many interconnected objects, the relationships between them are complex and confused.
                        2. When you cannot reuse a class, because it depends on a lot of other classes.
                        3. When you have to create many subclasses of components in order to use the same components in different contexts.
            */

            MediatorManager Manager = new MediatorManager();
            JewelryActor Customer = new JewelryCustomer(Manager);
            JewelryActor Seller = new JewelrySeller(Manager);
            JewelryActor Master = new JewelryMaster(Manager);

            Manager.SetCustomer(Customer);
            Manager.SetSeller(Seller);
            Manager.SetMaster(Master);

            Customer.Send("I need a jewelry!");
            Seller.Send("Create a jewelry.");
            Master.Send("I've created a jewelry, you can take it.");
            #endregion

            Separator();

            #region Memento
            /*
                Memento - a design pattern, which allows you to save and restore the past state of objects 
                           without revealing the details of their implementation.
                Difficulty: 3 / 3
                Popularity: 1 / 3
                    When to use:
                        1. When you need to save the state of an object for possible subsequent restoration.
                        2. When state preservation should take place without violating the principle of encapsulation.
            */

            ChessPlayer chessPlayer = new ChessPlayer();
            PlayerHistory playerHistory = new PlayerHistory();

            chessPlayer.Step("B", "2");
            playerHistory.History.Push(chessPlayer.SaveMemento());
            chessPlayer.Step("A", "3");
            playerHistory.History.Push(chessPlayer.SaveMemento());

            chessPlayer.Step("C", "4");
            chessPlayer.RestoreMemento(playerHistory.History.Pop());
            chessPlayer.RestoreMemento(playerHistory.History.Pop());
            #endregion

            Separator();

            #region Visitor
            /*
                Visitor - a design pattern, which allows you to add new operations to the program 
                          without changing the classes of objects on which these operations can be performed.
                Difficulty: 3 / 3
                Popularity: 1 / 3
                    When to use:
                        1. When you need to perform some operation on all elements of a complex structure of objects.
                        2. When new operations are often added to classes, while the general structure of classes is stable and practically unchanged.
            */

            BuildingCompany buildingCompany = new BuildingCompany();
            buildingCompany.Add(new Welder());
            buildingCompany.Add(new Mason());

            buildingCompany.Accept(new Foreman());
            buildingCompany.Accept(new Architect());
            #endregion

            Separator();

            #endregion

            // -------------------------------------------------------------- //

            #region Structural patterns

            #region Decorator
            Salad salad = new ClassicSalad();
            salad = new CucumberSalad(salad);

            Console.WriteLine($"Salad name: {salad.Name}");
            Console.WriteLine($"Salad cost: {salad.GetCost()}");

            salad = new TomatoSalad(salad);

            Console.WriteLine($"Salad name: {salad.Name}");
            Console.WriteLine($"Salad cost: {salad.GetCost()}");

            salad = new PepperSalad(salad);

            Console.WriteLine($"Salad name: {salad.Name}");
            Console.WriteLine($"Salad cost: {salad.GetCost()}");
            #endregion

            Separator();

            #region Adapter
            Vehicle vehicle = new Vehicle();
            Driver driver = new Driver(vehicle);

            driver.StartRide();

            Horse horse = new Horse();
            Donkey donkey = new Donkey();

            driver.SetTransport(new AnimalToTransportAdapter(horse));
            driver.StartRide();

            driver.SetTransport(new AnimalToTransportAdapter(donkey));
            driver.StartRide();
            #endregion

            Separator();

            #region Facade
            PhoneOS phoneOS = new PhoneOS();
            PhoneApp phoneApp = new PhoneApp();

            PhoneFacade phoneFacade = new PhoneFacade(phoneOS, phoneApp);

            PhoneUser phoneUser = new PhoneUser(phoneFacade);

            phoneUser.UsePhone();
            #endregion

            Separator();

            #region Composite
            Component Dir1 = new Directory("Folder1");
            Component File1 = new File("File1");
            Component File2 = new File("File2");
            Component Dir2 = new Directory("Folder2");
            Component File3 = new File("File3");

            Dir1.Add(File1);
            Dir1.Add(File2);
            Dir2.Add(File3);
            Dir1.Add(Dir2);

            Dir1.PrintComponent();
            #endregion

            Separator();

            #region Proxy
            using (IPartGetter PartProxy = new PartStoreProxy())
            {
                Part part = PartProxy.GetPartByName("Car part1");
                Console.WriteLine(part.Description);

                part = PartProxy.GetPartByName("Computer part1");
                Console.WriteLine(part.Description);

                part = PartProxy.GetPartByName("Car part1"); // This call is faster due to caching of received data
                Console.WriteLine(part.Description);
            }
            #endregion

            Separator();

            #region Bridge
            Warrior attacker = new Attacker();
            attacker.MakeABattleCry();
            attacker.Attack();
            attacker.SetWeapon(new SwordAndShield());
            attacker.Defend();

            Console.WriteLine();

            Warrior defender = new Defender();
            defender.MakeABattleCry();
            defender.Attack();
            defender.SetWeapon(new TwoHandedSword());
            defender.Defend();
            #endregion

            Separator();

            #region Flyweight
            SoldierFactory soldierFactory = new SoldierFactory();

            Soldier sergeant = soldierFactory.GetSoldier('S');
            Soldier lieutenant = soldierFactory.GetSoldier('L');
            Soldier general = soldierFactory.GetSoldier('G');

            Console.WriteLine(sergeant.GetInfo());
            Console.WriteLine(lieutenant.GetInfo());
            Console.WriteLine(general.GetInfo());
            #endregion

            Separator();

            #endregion
        }
    }
}
