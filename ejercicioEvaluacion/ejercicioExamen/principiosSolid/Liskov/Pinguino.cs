using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamen.principiosSolid.Liskov
{
    public class Pinguino : Ave
    {
        public override void Volar()
        {
            Console.WriteLine("El pingüino no puede volar."); 
        }
    }
}
