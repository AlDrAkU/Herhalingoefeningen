using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingoefeningen.Modellen
{
    internal class Student:Person
    {
        public int Year { get; set; }

        public override string GetFullName()
        {
            return $"Student: {base.GetFullName()}";
        }
    }
}
