using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo.polimorfismo_y_encapsulamiento
{
    //Clase base
    public abstract class Animal
    {
        private string nombre;

        // Propiedad para obtener y establecer el nombre (encapsulamiento)
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        // Método abstracto para que las clases derivadas implementen (polimorfismo)
        public abstract void Hablar();

    }
}
