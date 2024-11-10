using System;

namespace TiendaDesarrollo
{
    public class ArticuloPorSucursal
    {
        // Atributos
        private Sucursal sucursal;
        private Articulo articulo;
        private int cantidad;

        // Constructor por defecto
        public ArticuloPorSucursal()
        {
            sucursal = null;
            articulo = null;
            cantidad = 0;
        }

        // Constructor con parámetros
        public ArticuloPorSucursal(Sucursal sucursal, Articulo articulo, int cantidad)
        {
            this.sucursal = sucursal;
            this.articulo = articulo;
            this.cantidad = cantidad;
        }

        // Getters y Setters
        public Sucursal Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

        public Articulo Articulo
        {
            get { return articulo; }
            set { articulo = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        // Método para imprimir información del artículo por sucursal
        public void MostrarInformacion()
        {
            Console.WriteLine($"Sucursal: {sucursal.Nombre}, Artículo: {articulo.Descripcion}, Cantidad: {cantidad}");
        }

        // Destructor
        ~ArticuloPorSucursal()
        {
            // Código de limpieza, si es necesario
            Console.WriteLine("Destructor llamado para ArticuloPorSucursal relacionado con la sucursal: " + sucursal.Nombre);
        }
    }
}
