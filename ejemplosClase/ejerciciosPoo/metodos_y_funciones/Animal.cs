using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo.metodos_y_funciones
{
    internal class Animal
    {
        public string Nombre { get; private set; }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        // Método asíncrono para alimentar al animal

        //El método AlimentarAsync es asíncrono y simula la alimentación del animal
        //con un retraso de 2 segundos utilizando await Task.Delay(2000).
        public async Task AlimentarAsync()
        {
            Console.WriteLine($"Alimentando a {Nombre}...");

            // Simula un retraso de 2 segundos para alimentar al animal
            await Task.Delay(2000);

            Console.WriteLine($"{Nombre} ha sido alimentado.");
        }
    }
}
