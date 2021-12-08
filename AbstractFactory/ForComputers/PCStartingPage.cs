using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ForComputers
{
    public class PCStartingPage : MainThings.StartingPage
    {
        public PCStartingPage()
        {
            Console.WriteLine("Creating a starting page for a PC");
        }
        public override void CreateNavMenu()
        {
            Console.WriteLine("Menu will be shown from the left side of a screen");
        }
        public override void CreateSearch()
        {
            Console.WriteLine("Search bar will show up at the top of a page");
        }
    }
}
