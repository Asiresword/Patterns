using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.Mediator
{
    public class MediatorManager : IMediator
    {
        private JewelryActor Customer { get; set; }
        private JewelryActor Seller { get; set; }
        private JewelryActor Master { get; set; }
        public MediatorManager(JewelryActor Customer, JewelryActor Seller, JewelryActor Master)
        {
            this.Customer = Customer;
            this.Seller = Seller;
            this.Master = Master;
        }
        public MediatorManager() { }

        public void SetCustomer(JewelryActor Customer)
        {
            this.Customer = Customer;
        }

        public void SetSeller(JewelryActor Seller)
        {
            this.Seller = Seller;
        }

        public void SetMaster(JewelryActor Master)
        {
            this.Master = Master;
        }

        public void Send(string Message, JewelryActor Actor)
        {
            if(Actor == this.Customer)
            {
                this.Seller.Notify(Message);
            }
            else if(Actor == this.Seller)
            {
                this.Master.Notify(Message);
            }
            else if(Actor == this.Master)
            {
                this.Customer.Notify(Message);
            }
        }
    }
}
