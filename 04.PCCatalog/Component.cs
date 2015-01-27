using System;


namespace Defining_Classes_Homework
{
    public class Component
    {
        private string name;
        private string details;
        private decimal? price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can not be empty!");
                }
                this.name = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price must be greater than 0!");
                }
                this.price = value;
            }
        }

        public Component(string name, decimal? price, string details = null)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public override string ToString()
        {
            return this.Name + ", " + (this.Details != null ? this.Details + ", " : "") + this.Price + " lv";
        }
    }
}
