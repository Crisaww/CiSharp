using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo.herencia_Abstraccion
{
    public class Perro : Animal
    {
        public override string Nombre { get; set; }

        public Perro(string nombre)
        {
            Nombre = nombre;
        }

        // Implementación del método abstracto
        public override void HacerSonido()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"{Nombre} dice: ¡Guau!");
        }
    }
}
