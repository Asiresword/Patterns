using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Facade
{
    public class PhoneFacade
    {
        private PhoneOS OS { get; set; }
        private PhoneApp App { get; set; }
        public PhoneFacade(PhoneOS OS, PhoneApp App)
        {
            this.OS = OS;
            this.App = App;
        }

        public PhoneFacade() : this(new PhoneOS(), new PhoneApp()) { }

        public void Start()
        {
            this.OS.StartOS();
            this.App.StartApp();
        }

        public void Stop()
        {
            this.App.StopApp();
            this.OS.ShutdownOS();
        }
    }
}
