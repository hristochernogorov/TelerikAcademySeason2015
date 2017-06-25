namespace Bunnies
{
    using System;

    public class Bunny : Animal
    {
        private const int InitialHealth = 200;
        private const int InitialCarrots = 0;


        private string color;
        private ulong carrotsCount;


        public Bunny(string bunnyName)
        {
            this.Name = bunnyName;
            this.Health = InitialHealth;
            this.carrotsCount = InitialCarrots;
            this.IsRetired = false;
        }
        public Bunny(string bunnyName, string playerColor) : this(bunnyName)
        {
            this.Color = playerColor;
        }


        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                if (value != "Blue" && value != "Red")
                {
                    throw new ArgumentException("Color must be Blue or Red");

                }
                this.color = value;
            }
        }



        public bool IsRetired { get; private set; }

        public ulong AddCarrots(uint carrots)
        {
            this.carrotsCount += carrots;
            return this.carrotsCount;
        }
        public void Retire()
        {
            if (this.Health < 0)
            {
                this.IsRetired = true;
            }
        }
    }
}
