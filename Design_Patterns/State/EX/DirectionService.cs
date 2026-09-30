using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.State.EX;

    public class DirectionService
    {
        private State travelMode;

        public Object getEta()
        {
        return travelMode.ETA();
       
        }

        public Object getDirection()
        {
           return travelMode.Direction();
        }

        public State getTravelMode()
        {
            return travelMode;
        }

        public void setTravelMode(State travelMode)
        {
            this.travelMode = travelMode;
        }
    }


