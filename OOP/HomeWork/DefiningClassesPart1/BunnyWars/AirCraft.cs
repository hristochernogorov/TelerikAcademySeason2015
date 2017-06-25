using System;

namespace Bunnies
{
    public class AirCraft
    {
        public static double CalculateDistance(AirCraft first, AirCraft second)
        {
            return Math.Sqrt((first.Coordinates.X - second.Coordinates.X) * (first.Coordinates.X - second.Coordinates.X) +
                (first.Coordinates.Y - second.Coordinates.Y) * (first.Coordinates.Y - second.Coordinates.Y));
        }


        public int Id { get; set; }

        public string Name { get; set; }

        public int Demage { get; set; }

        public Bunny Pilot { get; private set; }

        public Coordinates Coordinates { get;  private set; }

        public AirCraft(Bunny bunny, int demage)
        {
            this.Pilot = bunny;
            this.Demage = demage;
            this.Coordinates = new Coordinates();

        }

        public void Attack(AirCraft target)
        {
            target.Pilot.Health -= this.Demage;
        }

        public void Move(Coordinates coor)
        {
            this.Coordinates.X = coor.X;
            this.Coordinates.Y = coor.Y;
        }


    }
}
