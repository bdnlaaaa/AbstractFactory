using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ForPhones
{
    public class PhoneStartingPage : MainThings.StartingPage
    {
        public PhoneStartingPage()
        {
            Console.WriteLine("Creating a strating page for a small device");
        }
        public override void CreateNavMenu()
        {
            Console.WriteLine("Using a small pictogram to hide the menu");
        }
        public override void CreateSearch()
        {
            Console.WriteLine("Search bar will show up only if the user will scroll up");
        }
    }
}
