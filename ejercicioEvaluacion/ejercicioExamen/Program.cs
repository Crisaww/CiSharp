using ejercicioExamen.clases_y_atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Empleado("1", "Cristi",18, "cqlle", 100000);
            persona.ShowInformation();  
        }
    }
}
