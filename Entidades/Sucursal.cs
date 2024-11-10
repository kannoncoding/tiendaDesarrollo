using System;

namespace TiendaDesarrollo
{
    public class Sucursal
    {
        // Atributos
        private int idSucursal;
        private string nombre;
        private Administrador administrador;
        private string direccion;
        private string telefono;
        private bool activo;

        // Constructor por defecto
        public Sucursal()
        {
            idSucursal = 0;
            nombre = string.Empty;
            administrador = null;
            direccion = string.Empty;
            telefono = string.Empty;
            activo = true;
        }

        // Constructor con parámetros
        public Sucursal(int idSucursal, string nombre, Administrador administrador, string direccion, string telefono, bool activo)
        {
            this.idSucursal = idSucursal;
            this.nombre = nombre;
            this.administrador = administrador;
            this.direccion = direccion;
            this.telefono = telefono;
            this.activo = activo;
        }

        // Getters y Setters
        public int IdSucursal
        {
            get { return idSucursal; }
            set { idSucursal = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Administrador Administrador
        {
            get { return administrador; }
            set { administrador = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        // Método para imprimir información de la sucursal
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {idSucursal}, Nombre: {nombre}, Administrador: {administrador.Nombre} {administrador.PrimerApellido}, Dirección: {direccion}, Teléfono: {telefono}, Activo: {activo}");
        }

        // Destructor
        ~Sucursal()
        {
            // Código de limpieza, si es necesario
            Console.WriteLine("Destructor llamado para la sucursal con ID: " + idSucursal);
        }
    }
}
