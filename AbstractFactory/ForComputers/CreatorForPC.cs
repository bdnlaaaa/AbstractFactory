using AbstractFactory.MainThings;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ForComputers
{
    class CreatorForPC : MainThings.MainCreator
    {
        public override Ad CreateAd()
        {
            return new PCAds();
        }
        public override StartingPage CreateStartingPage()
        {
            return new PCStartingPage();
        }
    }
}
