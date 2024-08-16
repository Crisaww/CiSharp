using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamen.clases_y_atributos
{
    public class Persona
    {
        //Atributos
        public string Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        public string Telefono { get; set; }

        //Constructor 1 (Con parámetros)
        public Persona(string id, string nombre, int edad, string direccion, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            Telefono = telefono;
        }

        //Constructor 2 (Sin parámetros) 
        public Persona()
        {
            
        }

        //Metodo para que persona ingrese datos
        public void IngresarDatosPersona()
        {
            Console.Write("Digite su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Digite su edad: ");
            Edad = int.Parse(Console.ReadLine());

            Console.Write("Digite su dirección: ");
            Direccion = Console.ReadLine();

            Console.Write("Digite su teléfono: ");
            Telefono = Console.ReadLine();

            //Id = "AE";
            //Nombre = "Mar";
            //Edad = 18;
            //Direccion = "Cra 9 #27 - 17 cambulos";
            //Telefono = "3104567351";
        }

        //Método que muestra los atributos de la persona
        public void ShowInformation()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Telefono: {Telefono}");
        }
    }
}
