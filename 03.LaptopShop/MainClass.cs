using System;

namespace Defining_Classes_Homework
{
    class MainClass
    {
        static void Main()
        {
            Laptop Lenovo = new Laptop("Lenovo T410S", 2999, new Battery("Ni-MH", 4), "Lenovo", "Intel", 4, "Ati", "", "1920x1080");

            Laptop HP = new Laptop("HP", 899.99);
            Battery batt = new Battery("Li-ION", 4);
            HP.AddBattery(batt);

            Laptop ASUS = new Laptop("ASUS", 799.00, new Battery("Li-ION", 3), "ASUS");

            Console.WriteLine(Lenovo);
            Console.WriteLine(HP);
            Console.WriteLine(ASUS);
        }
    }
}