using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2_Warm_Up_UML
{
    class Engine
    {
        public bool IsStarted;

        private string About()
        {
            if (IsStarted)
                return "The engine is started.";

            else return "the engine is not started.";
        }

        public Engine()
        {
            IsStarted = false;
        }

        public void Start()
        {
            IsStarted = true;
        }

        public void Stop()
        {
            IsStarted = false;
        }
    }
}
