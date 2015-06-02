using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones o = new Operaciones();
            Console.WriteLine(o.suma());
            Console.WriteLine(o.resta());
            Console.WriteLine(o.producto());
            Console.WriteLine(o.division());
            Console.ReadKey();
            string aux = "chau";
        }
    }
}
