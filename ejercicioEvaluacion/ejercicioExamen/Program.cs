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
           
            Empleado empleado = new Empleado();

            // Llamar al método para que el empleado (que es una Persona) ingrese sus datos
            empleado.IngresarDatosPersona();

            // Ingresar datos específicos del empleado
            Console.Write("Digite el salario: ");
            empleado.Salario = int.Parse(Console.ReadLine());

            Console.Write("Digite los días trabajados: ");
            empleado.DiasT = int.Parse(Console.ReadLine());

            // Mostrar la información del empleado que ya digitamos
            empleado.ShowInformation();

            // Llamar al método asincrónico para simular la lectura de salario
            await empleado.LeerSalarioAsync();
        }
    }
}
