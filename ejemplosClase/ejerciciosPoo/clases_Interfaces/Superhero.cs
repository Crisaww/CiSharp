using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosPoo.clases_Interfaces
{
    public class Superhero
    {
        //Atributos
        public string NameHero { get; set; }
        public string SuperPowers { get; set; }
        public string PrincipalEnemy { get; set; }

        //Constructores

        public Superhero(string nameHero, string superPowers, string principalEnemy)
        {
            NameHero = nameHero;
            SuperPowers = superPowers;
            PrincipalEnemy = principalEnemy;
        }

        //Método que muestra los atributos del superhéroe
        public void ShowInformation()
        {
            
            Console.WriteLine($"Name: {NameHero}");
            Console.WriteLine($"Super Power: {SuperPowers}");
            Console.WriteLine($"Principal Enemy: {PrincipalEnemy}");
        }    
    }


}
