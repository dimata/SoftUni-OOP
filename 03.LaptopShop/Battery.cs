using System;

namespace Defining_Classes_Homework
{
    class Battery
    {
        private string battery;
        private int batteryLife;

        public Battery(string battery = null, int batteryLife = 0)
        {
            this.Batt = battery;
            this.BattLife = batteryLife;
        }

        public string Batt
        {
            get { return this.battery; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    this.battery = null;
                this.battery = value;
            }
        }

        public int BattLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("The value must be greater than 0");
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            return "Battery: " + this.Batt + "  Battery life: " + this.BattLife;
        }
    }
}