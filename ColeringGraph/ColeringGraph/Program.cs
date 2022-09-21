using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeringGraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Colering colering = new Colering();
            colering.Search(7, new int[8]);
            Console.ReadKey();
        }
    }
}
