using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidadesCSharp
{
    public class producto
    {
        //Se definen los atributos de la clase producto

        private String id_producto;
        private String nombre_producto;
        private String descripcion;
        private int cantidad;
        private int precio;

        //Se hacen los getters and setters a cada entidad

        public string Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }



        //Se hace el constructor
        public producto(string id_producto, string nombre_producto, string descripcion, int cantidad, int precio)
        {
            this.Id_producto = id_producto;
            this.Nombre_producto = nombre_producto;
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        //Se hace un metodo para registrar el producto
        //public producto RegistrarProducto(string id_producto, string nombre_producto, string descripcion, int cantidad, int precio);

        


      
    }
}
