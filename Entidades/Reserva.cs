using System;

namespace TiendaDesarrollo
{
    public class Reserva
    {
        // Atributos
        private int idReserva;
        private Cliente cliente;
        private ArticuloPorSucursal articuloPorSucursal;
        private DateTime fechaReserva;

        // Constructor por defecto
        public Reserva()
        {
            idReserva = 0;
            cliente = null;
            articuloPorSucursal = null;
            fechaReserva = DateTime.MinValue;
        }

        // Constructor con parámetros
        public Reserva(int idReserva, Cliente cliente, ArticuloPorSucursal articuloPorSucursal, DateTime fechaReserva)
        {
            this.idReserva = idReserva;
            this.cliente = cliente;
            this.articuloPorSucursal = articuloPorSucursal;
            this.fechaReserva = fechaReserva;
        }

        // Getters y Setters
        public int IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public ArticuloPorSucursal ArticuloPorSucursal
        {
            get { return articuloPorSucursal; }
            set { articuloPorSucursal = value; }
        }

        public DateTime FechaReserva
        {
            get { return fechaReserva; }
            set { fechaReserva = value; }
        }

        // Método para imprimir información de la reserva
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID Reserva: {idReserva}, Cliente: {cliente.Nombre} {cliente.PrimerApellido}, Artículo: {articuloPorSucursal.Articulo.Descripcion}, Sucursal: {articuloPorSucursal.Sucursal.Nombre}, Fecha de Reserva: {fechaReserva.ToShortDateString()}");
        }

        // Destructor
        ~Reserva()
        {
            // Código de limpieza, si es necesario
            Console.WriteLine("Destructor llamado para la reserva con ID: " + idReserva);
        }
    }
}
