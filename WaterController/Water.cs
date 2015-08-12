using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterController
{
    public enum WaterState
    {
        Liquid, Solid, Gas, Plasma
    }
    class Water
    {
        protected WaterState state;

        public void ToBoil()
        {
            switch(state)
            {
                case WaterState.Liquid:
                    state = WaterState.Gas;
                    break;
                case WaterState.Solid:
                    state = WaterState.Liquid;
                    break;
                case WaterState.Gas:
                    state = WaterState.Plasma;
                    break;
                case WaterState.Plasma:
                    state = WaterState.Plasma;
                    break;
            }
        }
        public void ToFreeze()
        {
            switch (state)
            {
                case WaterState.Liquid:
                    state = WaterState.Solid;
                    break;
                case WaterState.Solid:
                    state = WaterState.Solid;
                    break;
                case WaterState.Gas:
                    state = WaterState.Liquid;
                    break;
                case WaterState.Plasma:
                    state = WaterState.Gas;
                    break;
            }
        }
        public void ToSublimate()
        {
            switch (state)
            {
                case WaterState.Liquid:
                    state = WaterState.Gas;
                    break;
                case WaterState.Solid:
                    state = WaterState.Gas;
                    break;
                case WaterState.Gas:
                    state = WaterState.Gas;
                    break;
                case WaterState.Plasma:
                    state = WaterState.Plasma;
                    break;
            }
        }
        public void ToDeposition()
        {
            state = WaterState.Solid;
        }

        public void GetState()
        {
            Console.WriteLine("\nElement State: " + state.ToString() + "\n");
        }

        public void ToAct(int value)
        {
            switch (value)
            {
                case 1: ToFreeze(); break;
                case 2: ToBoil(); break;
                case 3: ToSublimate(); break;
                case 4: ToDeposition(); break;
            }
        }
    }
}
