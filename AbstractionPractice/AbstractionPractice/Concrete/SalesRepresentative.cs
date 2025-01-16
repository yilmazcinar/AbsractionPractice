﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractionPractice.Abstract;

namespace AbstractionPractice.Concrete
{
    internal class SalesRepresentative : BasePerson
    {

        public SalesRepresentative(string name, string lastname, string department) : base(name, lastname, department ) 
            { 
        }

        public override void Gorev()
        {
            Console.WriteLine($"\nMerhaba ben {Name} {LastName}, {Department} departmanında Satış Temsilcisi olarak çalışıyorum.\n");
        }
    }
}
