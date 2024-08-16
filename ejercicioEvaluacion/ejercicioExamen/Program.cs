using ejercicioExamen.clases_y_atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamen
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //Datos del empleado
            Empleado empleado = new Empleado(1300000, 23);
            empleado.ShowInformation();
        }
    }
}
