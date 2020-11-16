using System;
using System.Collections.Generic;
using System.Text;
using Logica;
using System.Linq;
namespace Logica
{
    public class Simulacion
    {
        private EstadoSimulacion estadoAnterior { get; set; }
        private EstadoSimulacion estadoActual { get; set; }
        private Condiciones.Condiciones condIniciales { get; set; }

        public Simulacion(Condiciones.Condiciones condIniciales)
        {
            this.condIniciales = condIniciales;
            estadoAnterior = new EstadoSimulacion(condIniciales);
        }

        public EstadoSimulacion GenerarSimulacion()
        {
            estadoActual = (EstadoSimulacion)estadoAnterior.Clone();
            estadoActual.tiempo = estadoAnterior.tiempoProximoEvento;
            estadoActual.evento = estadoAnterior.proximoEvento;
           
            switch (estadoActual.evento)
            {
                case Evento.LlegaCliente:
                    LlegaCliente();
                    break;
            }

            return estadoAnterior;
        }

        private void LlegaCliente()
        {
            Cliente cliente = new Cliente(estadoActual.tiempo, estadoActual.numeroCliente);

            List<Empleado> ListaEmpleados = new List<Empleado>
            {
                estadoActual.empleado1,
                estadoActual.empleado2
            };

            Empleado empleado = ListaEmpleados.FindAll(x => x.Libre).FirstOrDefault();

            if(empleado != null)
            {
                empleado.SetCliente(cliente);
            }
            else
            {
                estadoActual.colaClientes.Add(cliente);
            }

            estadoActual.ObtenerTiempoLlegadaProximoCliente(estadoActual.tiempo);


        }
    }
}
