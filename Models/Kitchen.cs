using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance.Models
{
    internal class Kitchen:House
    {
        public void Cook()
        {
            Console.WriteLine("Prepare something to eat please!");
        }
    }
}
