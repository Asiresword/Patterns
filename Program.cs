using System;
using Patterns.DesignPatterns.Creational.AbstractFactory;
using Patterns.DesignPatterns.Creational.Factory;
using Patterns.DesignPatterns.Creational.Singleton;

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
        }
    }
}
