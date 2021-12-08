using AbstractFactory.MainThings;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ForPhones
{
    public class CreatorForPhones : MainThings.MainCreator
    {
        public override Ad CreateAd()
        {
            return new PhoneAds();
        }
        public override StartingPage CreateStartingPage()
        {
            return new PhoneStartingPage();
        }
    }
}
