using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.MainThings;

namespace AbstractFactory
{
    public class Controller
    {
        MainCreator type;
        public Controller(MainCreator type)
        {
            this.type = type;
        }
        public void Page()
        {
            Ad ad = type.CreateAd();
            ad.CreateImage();
            ad.CreateGif();
            StartingPage startingPage = type.CreateStartingPage();
            startingPage.CreateNavMenu();
            startingPage.CreateSearch();
        }
    }
}
