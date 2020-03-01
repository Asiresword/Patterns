using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.DesignPatterns.Behavioural.State
{
    public class Water
    {
        private IWaterState CurrentState { get; set; }
        public Water(IWaterState State)
        {
            this.CurrentState = State;
        }
        public Water() : this(new LiquidWaterState()) { }

        public void SetState(IWaterState State)
        {
            this.CurrentState = State;
        }

        public void Heat()
        {
            this.CurrentState.Heat(this);
        }

        public void Frost()
        {
            this.CurrentState.Frost(this);
        }
    }
}
