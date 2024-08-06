using ejerciciosPoo.clases_Interfaces;
using ejerciciosPoo.herencia_Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo
{
    public class Program
    {
        static void Main(string[] args)
        {

            //EJEMPLO CLASE *************************
            //Objeto de tipo superheroe
            Superhero superman = new Superhero("EJEMPLO DE SOLO CLASE = Superman", "Vuelo y Fuerza Sobrehumana", "Lex Luthor");

            // Mostrar información sobre el superhéroe
            superman.ShowInformation();


            //EJEMPLO INTERFAZ ********************
            //objeto de tipo superheroe 
            ISuperheroA spiderman = new SuperheroA("EJEMPLO DE CLASE E INTERFAZ = Spiderman", "Lanza Telarañas y Trepa Muros", "El Duende verde");

            // Mostrar información sobre el superhéroe
            spiderman.ShowInformation();


            //EJEMPLO ABSTRACCIÓN Y HERENCIA *************************
            // Crear instancias de Perro y Gato
            Animal miPerro = new Perro("Rex");
            Animal miGato = new Gato("Luna");

            // Usar los métodos implementados
            miPerro.HacerSonido();  // Output: Rex dice: ¡Guau!
            miGato.HacerSonido();   // Output: Luna dice: ¡Miau!

            // Usar el método no abstracto
            miPerro.Dormir();       // Output: El animal está durmiendo.
            miGato.Dormir();        // Output: El animal está durmiendo.





        }
    }
}
