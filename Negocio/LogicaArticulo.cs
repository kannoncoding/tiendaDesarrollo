using System;
using System.Collections.Generic;
using System.Linq;

namespace TiendaDesarrollo.Negocio
 public class LogicaArticulo
    {
        private List<Articulo> articulos;

        public LogicaArticulo()
        {
            articulos = new List<Articulo>();
        }

        // Métodos para agregar, actualizar, consultar y eliminar Artículos
        public void AgregarArticulo(Articulo articulo)
        {
            if (articulos.Any(a => a.IdArticulo == articulo.IdArticulo))
            {
                Console.WriteLine("El artículo con el mismo ID ya existe.");
            }
            else
            {
                articulos.Add(articulo);
                Console.WriteLine("Artículo agregado correctamente.");
            }
        }

        public void ActualizarArticulo(int id, string nuevaDescripcion, string nuevaMarca, bool activo)
        {
            Articulo articulo = articulos.FirstOrDefault(a => a.IdArticulo == id);
            if (articulo != null)
            {
                articulo.Descripcion = nuevaDescripcion;
                articulo.Marca = nuevaMarca;
                articulo.Activo = activo;
                Console.WriteLine("Artículo actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("El artículo no existe.");
            }
        }

        public Articulo ConsultarArticulo(int id)
        {
            return articulos.FirstOrDefault(a => a.IdArticulo == id);
        }

        public void EliminarArticulo(int id)
        {
            Articulo articulo = articulos.FirstOrDefault(a => a.IdArticulo == id);
            if (articulo != null)
            {
                articulos.Remove(articulo);
                Console.WriteLine("Artículo eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("El artículo no existe.");
            }
        }

        public void ListarArticulos()
        {
            foreach (var articulo in articulos)
            {
                articulo.MostrarInformacion();
            }
        }
    }