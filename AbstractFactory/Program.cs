using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller ph = new Controller(new ForPhones.CreatorForPhones());
            Controller pc = new Controller(new ForComputers.CreatorForPC());
            ph.Page();
            Console.WriteLine("\n");
            pc.Page();
        }
    }
}
