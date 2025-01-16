using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice.Abstract
{
    internal abstract class BasePerson
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }


        public BasePerson(string name, string lastName, string department)
        {
            Name = name;
            LastName = lastName;
            Department = department;


        }
        public abstract void Gorev();
    }     
}
