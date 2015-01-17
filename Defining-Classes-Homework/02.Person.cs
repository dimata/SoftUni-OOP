using System;


namespace Defining_Classes_Homework
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age) : this(name, age, null) 
        {
        }

        public string Name
        {
            get { 
                return this.name;
                }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name field can not be empty");
                }
                this.name = value;
            }

        }
        

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (1 <= value && value <= 100)
                {
                    throw new ArgumentOutOfRangeException("The age value should be between 1 and 100");

                }
                this.age = value;
            }

        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (null != value && (value.Length == 0 || !value.Contains("@")))
                {
                    throw new ArgumentException("Your e-mail is not valid");
                }
                this.email = value;
            }

        }

        public override string ToString()
        {
            return string.Format("My name is {0} and I am {1} years old", this.Name, this.Age) + 
                (this.Email== null?" and I don't have an email": " email - " + this.Email);
        }  

    }
}
