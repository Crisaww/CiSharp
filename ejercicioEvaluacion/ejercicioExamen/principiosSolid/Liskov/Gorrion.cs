using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamen.principiosSolid.Liskov
{
    public class Gorrion : Ave
    {
        public override void Volar()
        {
            Console.WriteLine("El gorrión está volando.");
        }
    }
}
