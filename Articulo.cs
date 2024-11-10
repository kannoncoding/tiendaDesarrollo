using System;

namespace TiendaDesarrollo
{
    public class Articulo
    {
        // Atributos
        private int idArticulo;
        private string descripcion;
        private Categoria categoria;
        private string marca;
        private bool activo;

        // Constructor por defecto
        public Articulo()
        {
            idArticulo = 0;
            descripcion = string.Empty;
            categoria = null;
            marca = string.Empty;
            activo = true;
        }

        // Constructor con parámetros
        public Articulo(int idArticulo, string descripcion, Categoria categoria, string marca, bool activo)
        {
            this.idArticulo = idArticulo;
            this.descripcion = descripcion;
            this.categoria = categoria;
            this.marca = marca;
            this.activo = activo;
        }

        // Getters y Setters
        public int IdArticulo
        {
            get { return idArticulo; }
            set { idArticulo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Categoria Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        // Método para imprimir información del artículo
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {idArticulo}, Descripción: {descripcion}, Categoría: {categoria.NombreCategoria}, Marca: {marca}, Activo: {activo}");
        }

        // Destructor
        ~Articulo()
        {
            // Código de limpieza, si es necesario
            Console.WriteLine("Destructor llamado para el artículo con ID: " + idArticulo);
        }
    }
}
