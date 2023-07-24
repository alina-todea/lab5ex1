using System;

namespace lab5ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Elev donald = new Elev("Donald", "Duck");
            Elev mickey = new Elev("Mickey", "Mouse");
            Elev minnie = new Elev("Minnie", "Mouse");

            Catalog xiic = new Catalog("xiic");

            xiic.InscrieElev(donald);
            xiic.InscrieElev(mickey);
            xiic.InscrieElev(minnie);

            donald.AdaugaNota(5);
            donald.AdaugaNota(6);
            donald.AdaugaNota(7);

            mickey.AdaugaNota(9);
            mickey.AdaugaNota(10);
            mickey.AdaugaNota(8);

            minnie.AdaugaNota(6);
            minnie.AdaugaNota(7);
            minnie.AdaugaNota(8);


            Console.WriteLine(xiic.GetDescription());
            Console.Write(donald.GetNote());
            Console.WriteLine($" media: {donald.GetMedia()}");

            Console.Write(mickey.GetNote());
            Console.WriteLine($" media: {mickey.GetMedia()}");

            Console.Write(minnie.GetNote());
            Console.WriteLine($" media: {minnie.GetMedia()}");

            Console.WriteLine($"premiantul: {xiic.GetPremiantul()}");

        }

    }
}
