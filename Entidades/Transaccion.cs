using System;

namespace TiendaDesarrollo
{
    public class Transaccion
    {
        // Atributos
        private int idTransaccion;
        private Cliente cliente;
        private ArticuloPorSucursal articuloPorSucursal;
        private DateTime fechaTransaccion;
        private int cantidad;
        private decimal total;

        // Constructor por defecto
        public Transaccion()
        {
            idTransaccion = 0;
            cliente = null;
            articuloPorSucursal = null;
            fechaTransaccion = DateTime.MinValue;
            cantidad = 0;
            total = 0.0m;
        }

        // Constructor con parámetros
        public Transaccion(int idTransaccion, Cliente cliente, ArticuloPorSucursal articuloPorSucursal, DateTime fechaTransaccion, int cantidad, decimal total)
        {
            this.idTransaccion = idTransaccion;
            this.cliente = cliente;
            this.articuloPorSucursal = articuloPorSucursal;
            this.fechaTransaccion = fechaTransaccion;
            this.cantidad = cantidad;
            this.total = total;
        }

        // Getters y Setters
        public int IdTransaccion
        {
            get { return idTransaccion; }
            set { idTransaccion = value; }
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

        public DateTime FechaTransaccion
        {
            get { return fechaTransaccion; }
            set { fechaTransaccion = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        // Método para imprimir información de la transacción
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID Transacción: {idTransaccion}, Cliente: {cliente.Nombre} {cliente.PrimerApellido}, Artículo: {articuloPorSucursal.Articulo.Descripcion}, Sucursal: {articuloPorSucursal.Sucursal.Nombre}, Fecha de Transacción: {fechaTransaccion.ToShortDateString()}, Cantidad: {cantidad}, Total: {total:C}");
        }

        // Destructor
        ~Transaccion()
        {
            // Código de limpieza, si es necesario
            Console.WriteLine("Destructor llamado para la transacción con ID: " + idTransaccion);
        }
    }
}
