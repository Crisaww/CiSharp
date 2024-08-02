using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo.clases_Interfaces
{
    public class SuperheroA : ISuperheroA
    {

        //Propiedades
        public string NameHero { get; set; }
        public string SuperPowers { get; set; }
        public string PrincipalEnemy { get; set; }

        //Constructor
        public SuperheroA (string nameHero, string superPowers, string principalEnemy)
        {
            NameHero = nameHero;
            SuperPowers = superPowers;
            PrincipalEnemy = principalEnemy;
        }

        //Se implementa el metodo de la interfaz

        public void ShowInformation()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Name: {NameHero}");
            Console.WriteLine($"Super Power: {SuperPowers}");
            Console.WriteLine($"Principal Enemy: {PrincipalEnemy}");
        }

    }
}
