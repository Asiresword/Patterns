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
            Programmer programmer = new Programmer(new CSLanguage());
            programmer.WriteProgram();

            programmer.SetLanguage(new JSLanguage());
            programmer.WriteProgram();
            #endregion

            Separator();

            #region Observer
            Server server = new Server();
            SysAdmin admin = new SysAdmin(server);
            Client client = new Client(server);

            server.SetDown(true);
            Console.WriteLine();
            server.SetDown(false);
            #endregion

            Separator();

            #region Command
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
            School school = new School();
            University university = new University();

            school.Start();
            Console.WriteLine();
            university.Start();
            #endregion

            Separator();

            #region Iterator
            Warehouse warehouse = new Warehouse();
            Supervisor supervisor = new Supervisor();

            supervisor.SeeProducts(warehouse);
            #endregion

            Separator();

            #region State
            Water water = new Water();
            water.Heat();
            water.Heat();
            water.Frost();
            water.Frost();
            water.Frost();
            #endregion

            Separator();

            #region Chain Of Responsibility
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
