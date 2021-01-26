using System;
using Phone;
namespace ClassProperties
{
    class Program
    {
        public static PhoneTypes Phone = null;
        static void Main()
        {
            /* When I was doing the phone thing I was trying to explain to my mom how classes work and how objects work
             * lol */
            var Sunflower = new Flower { Name = "Sunni", Petals = 8, Color = "Blue" };
            Console.WriteLine($"{Sunflower}");
            Console.WriteLine($"{Sunflower.Name}");
            Console.WriteLine($"{Sunflower.Petals}");
            Console.WriteLine($"{Sunflower.Color}");
            Console.ReadLine();
            var Samsung = new PhoneTypes();
            Samsung.Color = "Black";
            Samsung.Manufacturer = "Samsung";
            Samsung.OS = "Android";

            var LG = new PhoneTypes();
            LG.Color = "Black";
            LG.Manufacturer = "LG";
            LG.OS = "properitary";

            Console.WriteLine($"{Samsung.Color}");
            Console.WriteLine($"{Samsung.Manufacturer}");



            Console.WriteLine($"{LG.Manufacturer}");
            Console.WriteLine($"{LG.Color}");
        }
    }
}
