using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamen.principiosSolid.SegregacionInterfaz
{
    public class ImpresoraSimple : IImpresora
    {
        public void Imprimir()
        {
            Console.WriteLine("Imprimiendo...");
        }
    }
}
