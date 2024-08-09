using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioExamen.principiosSolid
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }

    public class ImpresoraDeUsuarios
    {
        public void ImprimirUsuario(Usuario usuario)
        {
            Console.WriteLine($"Nombre: {usuario.Nombre}, Correo: {usuario.Correo}");
        }
    }
}
