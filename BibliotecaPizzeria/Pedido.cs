using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPizzeria
{
    public class Pedido
    {
        string producto, nombre, telefono, direccion, detalle;
        int cantidad;

        public Pedido(string producto, string nombre, string telefono, string direccion, string detalle, int cantidad)
        {
            this.producto = producto;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.detalle = detalle;
            this.cantidad = cantidad;
        }

        public string Producto { get => producto; set => producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
