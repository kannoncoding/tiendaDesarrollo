using System;
using System.Collections.Generic;
using System.Linq;

namespace TiendaDesarrollo.Negocio

    public class LogicaCategoria
    {
        private List<Categoria> categorias;

        public LogicaCategoria()
        {
            categorias = new List<Categoria>();
        }

        // Métodos para agregar, actualizar, consultar y eliminar Categorías
        public void AgregarCategoria(Categoria categoria)
        {
            if (categorias.Any(c => c.IdCategoria == categoria.IdCategoria))
            {
                Console.WriteLine("La categoría con el mismo ID ya existe.");
            }
            else
            {
                categorias.Add(categoria);
                Console.WriteLine("Categoría agregada correctamente.");
            }
        }

        public void ActualizarCategoria(int id, string nuevoNombre, string nuevaDescripcion)
        {
            Categoria categoria = categorias.FirstOrDefault(c => c.IdCategoria == id);
            if (categoria != null)
            {
                categoria.NombreCategoria = nuevoNombre;
                categoria.Descripcion = nuevaDescripcion;
                Console.WriteLine("Categoría actualizada correctamente.");
            }
            else
            {
                Console.WriteLine("La categoría no existe.");
            }
        }

        public Categoria ConsultarCategoria(int id)
        {
            return categorias.FirstOrDefault(c => c.IdCategoria == id);
        }

        public void EliminarCategoria(int id)
        {
            Categoria categoria = categorias.FirstOrDefault(c => c.IdCategoria == id);
            if (categoria != null)
            {
                categorias.Remove(categoria);
                Console.WriteLine("Categoría eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("La categoría no existe.");
            }
        }

        public void ListarCategorias()
        {
            foreach (var categoria in categorias)
            {
                categoria.MostrarInformacion();
            }
        }
    }