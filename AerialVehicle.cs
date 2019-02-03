using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Warm_Up_UML
{
    abstract class AerialVehicle
    {
        public int currentAltitude { get; set; }
        public int MaxAltitude { get; set; }
        public Engine Engine {get; set;}
        public bool isFlying { get; set; }

        private void CheckIfFlying()//call this anytime current altitude changes positively
        {
            if (currentAltitude > 0)
                isFlying = true;

            else isFlying = false;
        }

        public AerialVehicle()
        {
            currentAltitude = 0;//default to 0;
            isFlying = false;//defaults to false and becomes true when alt = 0;
            Engine = new Engine();
        }

        public virtual string About()
        {
            return "This " + this.GetType().Name + " has a max altitude of " + MaxAltitude.ToString() + 
                ".\nIt's current altitude is " + currentAltitude + " ft." + 
                "\n" + GetEngineStartedString();
        } 

        public string GetEngineStartedString()
        {
            if (Engine.IsStarted)
                return "Engine is started.";
            else
                return "Engine is not started.";
        }

        public void FlyDown(int howManyFeet)
        {
            if (currentAltitude >= howManyFeet)//can only fly down that amount if it is higher or equal to that amount
                currentAltitude -= howManyFeet;
        }

        public void FlyUp(int howManyFeet)
        {
            if (currentAltitude < MaxAltitude - howManyFeet)
                currentAltitude += howManyFeet;

            CheckIfFlying();//changes our bool if we went up.
        }

        public void FlyUp()
        {
            if (currentAltitude < MaxAltitude - 1000)
                currentAltitude += 1000;

            CheckIfFlying();//changes our bool if we went up      
        }

        public virtual void StartEngine()
        {
            Engine.Start();
        }
        
        public virtual void StopEngine()
        {
            Engine.Stop();
        }

        public virtual string TakeOff()
        {
            if (!Engine.IsStarted)
                return this.GetType().Name + " can't fly. It's engine is not started.";

            else
                return this.GetType().Name + " is flying";
        }
    }
}
