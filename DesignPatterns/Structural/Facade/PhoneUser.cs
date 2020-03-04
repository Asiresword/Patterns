using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Structural.Facade
{
    public class PhoneUser
    {
        private PhoneFacade Phone { get; set; }
        public PhoneUser(PhoneFacade Phone)
        {
            this.Phone = Phone;
        }

        public PhoneUser() : this(new PhoneFacade()) { }

        public void UsePhone()
        {
            this.Phone.Start();
            this.Phone.Stop();
        }
    }
}
