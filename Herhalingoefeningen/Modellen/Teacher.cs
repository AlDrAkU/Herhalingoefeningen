using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingoefeningen.Modellen
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }

        public override string GetFullName()
        {
            return $"Teacher: {base.GetFullName()}";
        }
    }
}
