using System;
using System.Collections.Generic;

namespace TiendaDesarrollo
{
    public class Inventario
    {
        // Atributos
        private List<ArticuloPorSucursal> listaArticulosPorSucursal;

        // Constructor por defecto
        public Inventario()
        {
            listaArticulosPorSucursal = new List<ArticuloPorSucursal>();
        }

        // Métodos para gestionar el inventario

        // Agregar un artículo al inventario
        public void AgregarArticulo(ArticuloPorSucursal articuloPorSucursal)
        {
            listaArticulosPorSucursal.Add(articuloPorSucursal);
            Console.WriteLine("Artículo agregado al inventario.");
        }

        // Remover un artículo del inventario
        public void RemoverArticulo(ArticuloPorSucursal articuloPorSucursal)
        {
            if (listaArticulosPorSucursal.Contains(articuloPorSucursal))
            {
                listaArticulosPorSucursal.Remove(articuloPorSucursal);
                Console.WriteLine("Artículo removido del inventario.");
            }
            else
            {
                Console.WriteLine("El artículo no se encuentra en el inventario.");
            }
        }

        // Actualizar la cantidad de un artículo en el inventario
        public void ActualizarCantidad(ArticuloPorSucursal articuloPorSucursal, int nuevaCantidad)
        {
            if (listaArticulosPorSucursal.Contains(articuloPorSucursal))
            {
                articuloPorSucursal.Cantidad = nuevaCantidad;
                Console.WriteLine("Cantidad actualizada para el artículo en la sucursal.");
            }
            else
            {
                Console.WriteLine("El artículo no se encuentra en el inventario.");
            }
        }

        // Mostrar todos los artículos del inventario
        public void MostrarInventario()
        {
            foreach (var articuloPorSucursal in listaArticulosPorSucursal)
            {
                articuloPorSucursal.MostrarInformacion();
            }
        }
    }
}
