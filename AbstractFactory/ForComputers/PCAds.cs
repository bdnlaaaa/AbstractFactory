using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ForComputers
{
    public class PCAds : MainThings.Ad
    {
        public PCAds()
        {
            Console.WriteLine("Creating an ad for a computer");
        }
        public override void CreateGif()
        {
            Console.WriteLine("Using a gif, because we can ;)");
        }
        public override void CreateImage()
        {
            Console.WriteLine("Using a huge image");
        }
    }
}
