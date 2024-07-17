using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance.Models
{
    internal class Room:Kitchen
    {
        public void Clean()
        {
            Console.WriteLine("Come help to clean the house");
        }
    }
}
