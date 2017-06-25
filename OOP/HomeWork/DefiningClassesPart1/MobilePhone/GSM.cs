namespace MobilePhone
{
    using System;

    using System.Collections.Generic;

    using System.Text;

    public class GSM
    {
        // fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> CallHistory;

        //private const 
        private const decimal defaultPrice = 1000;
        private const string defaultOwner = "T-Mobile";
        private const decimal callPriceForMinute = 0.37m;

        public string Owner { get; private set; }
        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        public decimal Price { get; private set; }
        internal Battery Battery { get; private set; }
        internal Display Display { get; private set; }

        internal GSM(string model,string manufacturer,decimal price,string owner,Battery battery,Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }


        static void Main()
        {

        }
    }
}
