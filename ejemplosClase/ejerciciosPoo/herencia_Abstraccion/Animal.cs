using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo.herencia_Abstraccion
{
    public abstract class Animal
    {
        // Propiedades y métodos abstractos
        public abstract string Nombre { get; set; }
        public abstract void HacerSonido();

        // Método no abstracto
        public void Dormir()
        {
            Console.WriteLine("El animal está durmiendo.");
        }

        internal abstract void Hablar();
    }
}
