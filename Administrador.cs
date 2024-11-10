using System;

namespace TiendaDesarrollo
{
    public class Administrador
    {
        // Atributos
        private int identificacion;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;

        // Constructor por defecto
        public Administrador()
        {
            identificacion = 0;
            nombre = string.Empty;
            primerApellido = string.Empty;
            segundoApellido = string.Empty;
            fechaNacimiento = DateTime.MinValue;
            fechaIngreso = DateTime.MinValue;
        }

        // Constructor con parámetros
        public Administrador(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaIngreso)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaIngreso = fechaIngreso;
        }

        // Getters y Setters
        public int Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        // Método para imprimir información del administrador
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {identificacion}, Nombre: {nombre} {primerApellido} {segundoApellido}, Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}, Fecha de Ingreso: {fechaIngreso.ToShortDateString()}");
        }

        // Destructor
        ~Administrador()
        {
            // Código de limpieza, si es necesario
            Console.WriteLine("Destructor llamado para el administrador con ID: " + identificacion);
        }
    }
}
