using System;
using System.Collections.Generic;
using System.Text;
using Logica;
using System.Linq;
namespace Logica
{
    public class Simulacion
    {
        public EstadoSimulacion estadoAnterior { get; set; }
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
           

            if(estadoActual.stock == 0 && estadoActual.colaClientes.Count()!=0)
            {
                estadoActual.clientesPerdidos += estadoActual.colaClientes.Count();
                estadoActual.colaClientes.Clear();
            }



            switch (estadoActual.evento)
            {
                case Evento.LlegaCliente:
                    LlegaCliente();
                    break;
                case Evento.EncendidoHorno:
                    EncendidoHorno();
                    break;
                case Evento.FinCoccionHorno:
                    FinConccionHorno();
                    break;
                case Evento.FinEmpleado1:
                    FinAtencion(estadoActual.empleado1);
                    break;
                case Evento.FinEmpleado2:
                    FinAtencion(estadoActual.empleado2);
                    break;
            }


            estadoActual.CalcularTiempoProximoEvento();
            estadoAnterior = estadoActual;
            return estadoAnterior;
        }

        private void FinAtencion(Empleado empleado)
        {
            if (estadoActual.stock >= empleado.cliente.CantidadPedido)
                estadoActual.stock -= empleado.cliente.CantidadPedido;
            else
                estadoActual.stock = 0;

            if (estadoActual.colaClientes.Count != 0)
            {
                Cliente cliente = estadoActual.colaClientes.First();
                estadoActual.colaClientes.RemoveAt(0);
                empleado.SetCliente(cliente, estadoActual.tiempo);
            }
            else
            {
                empleado.finalizarAtencion();
            }
            
        }

        private void FinConccionHorno()
        {
            estadoActual.horno.setEstado(false);
            int elem = estadoActual.horno.getCantidadElementosCoccion();
            estadoActual.stock += elem;
        }

        private void EncendidoHorno()
        {
            estadoActual.ObtenerTiempoFindeCoccion();
        }

        private void LlegaCliente()
        {
            Cliente cliente = new Cliente(estadoActual.tiempo, estadoActual.numeroCliente);
            estadoActual.numeroCliente++;

            if(estadoActual.stock == 0)
            {
                if (estadoActual.horno.getEstado())
                {
                    if (estadoActual.tiempoFinCoccion > cliente.TiempoLimite)
                        estadoActual.clientesPerdidos++;
                }
            }
            else
            {
                List<Empleado> ListaEmpleados = new List<Empleado>
            {
                estadoActual.empleado1,
                estadoActual.empleado2
            };

                Empleado empleado = ListaEmpleados.FindAll(x => x.Libre).FirstOrDefault();

                if (empleado != null)
                {
                    empleado.SetCliente(cliente, estadoActual.tiempo);
                }
                else
                {
                    estadoActual.colaClientes.Add(cliente);
                }
            }

            estadoActual.ObtenerTiempoLlegadaProximoCliente(estadoActual.tiempo);


        }
    }
}
