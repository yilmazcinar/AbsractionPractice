using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractionPractice.Abstract;

namespace AbstractionPractice.Concrete
{
    internal class SoftwareDeveloper : BasePerson
    {
        public SoftwareDeveloper(string name, string lastname, string department) : base(name, lastname, department) { }

        public override void Gorev()
        {
            Console.WriteLine($"\nMerhaba ben {Name} {LastName}, {Department} depertmanında Yazılım Geliştirici olarak çalışıyorum.\n ");
        }
    }
}
