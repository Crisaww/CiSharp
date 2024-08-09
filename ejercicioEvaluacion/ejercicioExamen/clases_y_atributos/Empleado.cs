using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamen.clases_y_atributos
{
    public class Empleado : Persona, ICalculable
    {
        public int Salario { get; set; }


        //Constructor
        public Empleado(string id, string nombre, int edad, string direccion, int salario) : base(id, nombre, edad, direccion)
        {
            Salario = salario;
        }

        // Implementación del método CalcularSalario de la interfaz ICalculable
        public int CalcularSalario()
        {

            return Salario;
        }


        // Nuevo método asincrónico que simula una operación de lectura de datos del salario
        public async Task<int> LeerSalarioAsync()
        {
            Console.WriteLine("Iniciando la lectura asincrónica del salario...");
            await Task.Delay(2000); // Simula una espera de 2 segundos
            Console.WriteLine("Lectura asincrónica del salario completada.");
            return Salario;
        }


        // Sobrescribiendo el método para mostrar información
        public override void ShowInformation()
        {
            base.ShowInformation(); // Llama al método de la clase base para mostrar info común
            Console.WriteLine($"Salario: {CalcularSalario()}");
        }
    }
}


