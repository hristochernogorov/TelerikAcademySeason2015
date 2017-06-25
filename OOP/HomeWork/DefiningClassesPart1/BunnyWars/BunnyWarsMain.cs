namespace BunnyWars
{
    using System;
    using Bunnies;
    using System.Collections.Generic;

    class BunnyWarsMain
    {
        static void ChangeBunny(Bunny bunny)
        {
            bunny.Health = 0;
        }

        static void Main()
        {
            Bunny vankataBunny = new Bunny("Vankata");
            ulong currentVankataCarrots = vankataBunny.AddCarrots(100);

            Bunny peshoBunny = new Bunny("Peshooo", "Blue");
            ulong currentPeshoCarrots = peshoBunny.AddCarrots(2000);

            string vankataName = vankataBunny.Name;
            vankataBunny.Color = "Blue";
            string color = vankataBunny.Color;
            vankataBunny.Retire();
            vankataBunny.Health -= 250;
            vankataBunny.Retire();
           
            Bunny baiGosho = new Bunny("Goshoo");

            ChangeBunny(baiGosho);

            var bunnies = new List<Bunny>();
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                var currentBunny = new Bunny(new string ((char)i,10));
                currentBunny.Health = random.Next(0, 100);
                bunnies.Add(currentBunny);
            }

            //foreach (var bunny in bunnies)
            //{
            //    Console.WriteLine(bunny.Health);
            //}

            var vankataAndPesho = new List<Bunny>
            {
                vankataBunny,
                peshoBunny
            };
            //foreach (var bunny in vankataAndPesho)
            //{
            //    Console.WriteLine(bunny.Name);
            //}

            var firstAirCraft = new AirCraft(vankataBunny, 50);
            var secondAirCraft = new AirCraft(peshoBunny, 100);





            firstAirCraft.Attack(secondAirCraft);

            Console.WriteLine(secondAirCraft.Pilot.Health);

            firstAirCraft.Move(new Coordinates(15, 20));
            secondAirCraft.Move(new Coordinates(25, 40));
            double distance = AirCraft.CalculateDistance(firstAirCraft, secondAirCraft);
            Console.WriteLine(distance);

            ColorType colorType = ColorType.Blue;
            Console.WriteLine(colorType);



           
       
        }
    }
}
