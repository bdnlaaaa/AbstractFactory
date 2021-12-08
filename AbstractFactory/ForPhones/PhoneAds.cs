using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ForPhones
{
    public class PhoneAds : MainThings.Ad
    {
        public PhoneAds()
        {
            Console.WriteLine("Creating an ad for a mobile device");
        }
        public override void CreateGif()
        {
            Console.WriteLine("Using a static image instead of a gif");
        }
        public override void CreateImage()
        {
            Console.WriteLine("Using a smaller image so it's fits");
        }
    }
}
