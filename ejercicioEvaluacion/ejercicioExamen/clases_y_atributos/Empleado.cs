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
        public int DiasT { get; set; }


        // Constructor vacío para que los datos puedan ser ingresados por el usuario
        public Empleado()
        {

        }

        //Constructor con parametros
        public Empleado(int salario, int diasT)
        {
            Salario = salario;
            DiasT = diasT;
        }


        //Metodo para que empleado ingrese sus datos
        public void IngresarDatos()
        {
            Console.Write("Ingrese el salario: ");
            Salario = int.Parse(Console.ReadLine());

            Console.Write("Ingrese los días trabajados: ");
            DiasT = int.Parse(Console.ReadLine());
        }


        // Implementación del método CalcularSalario de la interfaz ICalculable
        public decimal CalcularSalario()
        {
            decimal valorDia = Salario / 31;
            decimal totalPagar = valorDia * DiasT;

            return totalPagar;
        }

        // Nuevo método asincrónico que simula una operación de lectura de datos del salario
        public async Task LeerSalarioAsync()
        {
            Console.WriteLine("Iniciando la lectura asincrónica del salario...");
            await Task.Delay(5000); // Simula una espera de 5 segundos
            Console.WriteLine("Lectura asincrónica del salario completada.");
            Console.WriteLine($"Total a pagar: {CalcularSalario()}");
        }


        // Sobrescribiendo el método para mostrar información
        public void ShowInformation()
        {
            base.ShowInformation(); // Llama al método de la clase base para mostrar info común
            Console.WriteLine($"Salario base: {Salario}");
            Console.WriteLine($"Dias trabajados: {DiasT}");
            
        }
    }
}


