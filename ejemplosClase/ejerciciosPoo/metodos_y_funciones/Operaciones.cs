using ejerciciosPoo.herencia_Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo.metodos_y_funciones
{
    public class Operaciones
    {
        static async Task Main(string[] args)
        {

            //Se crean instancias de la clase Animal para un perro y un gato.

            Animal perro = new Animal("Perro");
            Animal gato = new Animal("Gato");

            Console.WriteLine("Alimentando a los animales...");



            // Se llama al método AlimentarAsync para cada animal
            // y se espera a que cada uno complete la operación de manera asíncrona.
            await perro.AlimentarAsync();
            await gato.AlimentarAsync();

            Console.WriteLine("Todos los animales han sido alimentados.");
        }

        
    }
}
