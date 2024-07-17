using Multilevel_Inheritance.Models;

namespace Multilevel_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room();
            room.Size();
            room.Cook();
            room.Clean();
        }
    }
}
