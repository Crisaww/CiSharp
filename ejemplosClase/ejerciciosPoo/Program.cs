using ejerciciosPoo.clases_Interfaces;
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

            //Objeto de tipo superheroe
            Superhero superman = new Superhero("EJEMPLO DE SOLO CLASE = Superman", "Vuelo y Fuerza Sobrehumana", "Lex Luthor");

            // Mostrar información sobre el superhéroe
            superman.ShowInformation();






            //objeto de tipo superheroe 
            ISuperheroA spiderman = new SuperheroA("EJEMPLO DE CLASE E INTERFAZ = Spiderman", "Lanza Telarañas y Trepa Muros", "El Duende verde");

            // Mostrar información sobre el superhéroe
            spiderman.ShowInformation();


        }
    }
}
