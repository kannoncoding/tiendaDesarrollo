using System;

namespace TiendaDesarrollo
{
    public class Cliente : Persona
    {
        // Atributos
        private bool activo;

        // Constructor por defecto
        public Cliente() : base()
        {
            activo = true;
        }

        // Constructor con parámetros
        public Cliente(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, bool activo)
            : base(identificacion, nombre, primerApellido, segundoApellido, fechaNacimiento)
        {
            this.activo = activo;
        }

        // Getter y Setter
        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        // Método para imprimir información del cliente
        public new void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Activo: {activo}");
        }

        // Destructor
        ~Cliente()
        {
            // Código de limpieza, si es necesario
            Console.WriteLine("Destructor llamado para el cliente con ID: " + identificacion);
        }
    }
}
