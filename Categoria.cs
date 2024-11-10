using System;

namespace TiendaDesarrollo
{
    public class Categoria
    {
        // Atributos
        private int idCategoria;
        private string nombreCategoria;
        private string descripcion;

        // Constructor por defecto
        public Categoria()
        {
            idCategoria = 0;
            nombreCategoria = string.Empty;
            descripcion = string.Empty;
        }

        // Constructor con parámetros
        public Categoria(int idCategoria, string nombreCategoria, string descripcion)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.descripcion = descripcion;
        }

        // Getters y Setters
        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string NombreCategoria
        {
            get { return nombreCategoria; }
            set { nombreCategoria = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        // Método para imprimir información de la categoría
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {idCategoria}, Nombre: {nombreCategoria}, Descripción: {descripcion}");
        }

        // Destructor
        ~Categoria()
        {
            // Código de limpieza, si es necesario
            Console.WriteLine("Destructor llamado para la categoría con ID: " + idCategoria);
        }
    }
}
