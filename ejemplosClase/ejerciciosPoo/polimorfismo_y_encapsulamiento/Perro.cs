using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo.polimorfismo_y_encapsulamiento
{
    public class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }

        // Implementación del método abstracto (polimorfismo)
        public override void Hablar()
        {
            Console.WriteLine($"{Nombre} dice: Guau!");
        }

    }
}
