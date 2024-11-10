using System;

namespace TiendaDesarrollo
{
    public class Usuario
    {
        // Atributos
        private int idUsuario;
        private string nombreUsuario;
        private string contrasena;
        private string rol; // Ejemplo: 'Cliente', 'Administrador'

        // Constructor por defecto
        public Usuario()
        {
            idUsuario = 0;
            nombreUsuario = string.Empty;
            contrasena = string.Empty;
            rol = string.Empty;
        }

        // Constructor con parámetros
        public Usuario(int idUsuario, string nombreUsuario, string contrasena, string rol)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.rol = rol;
        }

        // Getters y Setters
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        // Método para imprimir información del usuario
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID Usuario: {idUsuario}, Nombre de Usuario: {nombreUsuario}, Rol: {rol}");
        }

        // Destructor
        ~Usuario()
        {
            // Código de limpieza, si es necesario
            Console.WriteLine("Destructor llamado para el usuario con ID: " + idUsuario);
        }
    }
}
