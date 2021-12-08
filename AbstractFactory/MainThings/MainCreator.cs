using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.MainThings
{
    public abstract class MainCreator
    {
        public abstract Ad CreateAd();
        public abstract StartingPage CreateStartingPage();
    }
}
