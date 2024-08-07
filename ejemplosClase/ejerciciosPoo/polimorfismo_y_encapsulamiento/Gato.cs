using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo.polimorfismo_y_encapsulamiento
{
    public class Gato : Animal
    {
        public Gato(string nombre) : base(nombre) { }

        // Implementación del método abstracto (polimorfismo)
        public override void Hablar()
        {
            Console.WriteLine($"{Nombre} dice: Miau!");
        }

    }
}
