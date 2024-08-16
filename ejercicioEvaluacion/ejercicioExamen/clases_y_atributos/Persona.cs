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

        //Constructor 1 (Con parámetros)
        public Persona(string id, string nombre, int edad, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }

        //Constructor 2 (Sin parámetros)
        public Persona()
        {
            Id = "Mar";
            Nombre = "Mar";
            Edad = 18;
            Direccion = "Cra 9 #27 - 17 cambulos";
        }

        //Método que muestra los atributos de la persona
        public void ShowInformation()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
        }
    }
}
