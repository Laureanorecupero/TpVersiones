using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class Operaciones
    {
        float x { get; set; }

        float y { get; set; }
        public Operaciones()
        {
            try
            {
                x = float.Parse(Console.ReadLine());
                y = float.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.ToString());
                x = 0;
                y = 0;

            }
            catch (Exception e)
            {
                Console.WriteLine("ups" + e.Message);
            }
        }

        public float suma()
        {
            return x + y;
        }
        public float resta()
        {
            return x - y;
        }
        public float producto()
        {
            return x * y;
        }
        public float division()
        {
            return x / y;
        }
    }
}
