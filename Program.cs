using System;
using Patterns.DesignPatterns.Creational.AbstractFactory;
using Patterns.DesignPatterns.Creational.Factory;
using Patterns.DesignPatterns.Creational.Singleton;
using Patterns.DesignPatterns.Creational.Prototype;
using Patterns.DesignPatterns.Creational.Builder;
using Patterns.DesignPatterns.Behavioural.Strategy;

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

            #region Behavioural patterns

            #region Strategy
            Programmer programmer = new Programmer(new CSLanguage());
            programmer.WriteProgram();

            programmer.SetLanguage(new JSLanguage());
            programmer.WriteProgram();
            #endregion

            Separator();

            #endregion
        }
    }
}
