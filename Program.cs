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
            CarFactory Factory = new ToyotaFactory("Highlander");
            Console.WriteLine(Factory.CreateCar().Model);

            Factory = new NissanFactory("Qashqai");
            Console.WriteLine(Factory.CreateCar().Model);
            #endregion

            Separator();

            #region Abstract Factory Design Pattern
            PC NIPC = new PC(new NIPCFactory());
            Console.WriteLine(NIPC.CPUInfo());
            Console.WriteLine(NIPC.GPUInfo());

            PC AMDPC = new PC(new AMDPCFactory());
            Console.WriteLine(AMDPC.CPUInfo());
            Console.WriteLine(AMDPC.GPUInfo());
            #endregion

            Separator();

            #region Singleton Design Pattern
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

            #endregion
        }
    }
}
