using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Homework
{
    class Persons
    {
        public static void Main()
        {
            List<Person> persons=new List<Person>(){
                    new Person("Pesho", 45),
                    new Person("Gosho", 4),
                    new Person("Tosko", 14, "tosko@toshkoafrikanski.bg"),
                    new Person("Penka", 18, "penka@penka.com")
                };
                persons.ForEach(p=>Console.WriteLine(p.ToString()));
        }
    }
}
