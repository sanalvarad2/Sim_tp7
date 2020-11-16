using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logica.Condiciones;
using Simulacion.Utilidades.Distribuciones;

namespace Logica
{
    public class EstadoSimulacion
    {
        public long tiempo { get; set; }
        public long tiempoProximoEvento { get; set; }
        public long tiempoLlegadaProximoCliente { get; set; }
        public long tiempoFinCoccion { get; set; }
        public long tiempoProximoEncendidoHorno { get; set; }
        public Evento evento { get; set; }
        public Evento proximoEvento { get; set; }
        public Empleado empleado1 { get; set; }
        public Empleado empleado2 { get; set; }
        public int numeroEvento { get; set; }
        public int numeroCliente { get; set; }
        public List<Cliente> colaClientes { get; set; }
        public Horno horno { get; set; }
        public int stock { get; set; }
        public int clientesPerdidos { get; set; }
        Condiciones.Condiciones condicionesIniciales { get; set; }

        private EstadoSimulacion() { }

        public EstadoSimulacion(Condiciones.Condiciones condicionesIniciales)
        {
            this.condicionesIniciales = condicionesIniciales;
            Horno.SetEstadosIniciales(this.condicionesIniciales.condicionesHorno);
            Cliente.SetEstadosIniciales(this.condicionesIniciales.condicionesCliente);
            Empleado.SetEstadosIniciales(this.condicionesIniciales.condicionesEmpleado);
            tiempo = 0;
            evento = Evento.Inicio;
            tiempoProximoEncendidoHorno = 0;
            empleado1 = new Empleado(Evento.FinEmpleado1);//crear contructor
            empleado2 = new Empleado(Evento.FinEmpleado2);
            horno = new Horno();
            numeroEvento = 0;
            numeroCliente = 0;
            colaClientes = new List<Cliente>();
            stock = 0;
            clientesPerdidos = 0;
            ObtenerTiempoLlegadaProximoCliente(tiempo);
            //ObtenerTiempoFindeCoccion(tiempo);
            CalcularTiempoProximoEvento();
            


            
        }

        public void CalcularTiempoProximoEvento()
        {
            
            List<Empleado> ListaEmpleados = new List<Empleado>
            {
                empleado1,
                empleado2,              
            };

            Empleado ProximoEmpleado = ListaEmpleados.FindAll(x => !x.Libre).OrderBy(x => x.ObtenerTiempoFinDeAtencion()).FirstOrDefault();

            if (ProximoEmpleado == null)
            {
                if(tiempoLlegadaProximoCliente < tiempoFinCoccion)
                {
                    if (tiempoLlegadaProximoCliente < tiempoProximoEncendidoHorno || horno.getEstado())
                    {
                        tiempoProximoEvento = tiempoLlegadaProximoCliente;
                        proximoEvento = Evento.LlegaCliente;
                    }
                    else
                    {
                        tiempoProximoEvento = tiempoProximoEncendidoHorno;
                        proximoEvento = Evento.EncendidoHorno;
                    }

                }
                else
                {
                    if(tiempoFinCoccion < tiempoProximoEncendidoHorno || horno.getEstado())
                    {
                        tiempoProximoEvento = tiempoFinCoccion;
                        proximoEvento = Evento.FinCoccionHorno;
                    }
                    else
                    {
                        tiempoProximoEvento = tiempoProximoEncendidoHorno;
                        proximoEvento = Evento.EncendidoHorno;
                    }

                }
            }
            else
            {
                if(ProximoEmpleado.ObtenerTiempoFinDeAtencion() > tiempoLlegadaProximoCliente)
                {
                    if (tiempoLlegadaProximoCliente < tiempoFinCoccion)
                    {
                        if (tiempoLlegadaProximoCliente < tiempoProximoEncendidoHorno || horno.getEstado())
                        {
                            tiempoProximoEvento = tiempoLlegadaProximoCliente;
                            proximoEvento = Evento.LlegaCliente;
                        }
                        else
                        {
                            tiempoProximoEvento = tiempoProximoEncendidoHorno;
                            proximoEvento = Evento.EncendidoHorno;
                        }

                    }
                    else
                    {
                        if (tiempoFinCoccion < tiempoProximoEncendidoHorno || horno.getEstado())
                        {
                            tiempoProximoEvento = tiempoFinCoccion;
                            proximoEvento = Evento.FinCoccionHorno;
                        }
                        else
                        {
                            tiempoProximoEvento = tiempoProximoEncendidoHorno;
                            proximoEvento = Evento.EncendidoHorno;
                        }

                    }
                }
                else
                {
                    if (ProximoEmpleado.ObtenerTiempoFinDeAtencion() < tiempoFinCoccion)
                    {
                        if (ProximoEmpleado.ObtenerTiempoFinDeAtencion() < tiempoProximoEncendidoHorno || horno.getEstado())
                        {
                            tiempoProximoEvento = ProximoEmpleado.ObtenerTiempoFinDeAtencion();
                            proximoEvento = ProximoEmpleado.obtenerEventoEmpleado();
                        }
                        else
                        {
                            tiempoProximoEvento = tiempoProximoEncendidoHorno;
                            proximoEvento = Evento.EncendidoHorno;
                        }

                    }
                    else
                    {
                        if (tiempoFinCoccion < tiempoProximoEncendidoHorno || horno.getEstado())
                        {
                            tiempoProximoEvento = tiempoFinCoccion;
                            proximoEvento = Evento.FinCoccionHorno;
                        }
                        else
                        {
                            tiempoProximoEvento = tiempoProximoEncendidoHorno;
                            proximoEvento = Evento.EncendidoHorno;
                        }

                    }

                }
            }
            
            numeroEvento++;
        }

        public void ObtenerTiempoLlegadaProximoCliente(long tiempo)
        {
            DistribucionExponencialNegativa distribucionExponencialNegativa = new DistribucionExponencialNegativa(condicionesIniciales.condicionesCliente.lamdaLlegada);
            var t = (double)(distribucionExponencialNegativa.ObtenerVariableAleatoria());
            tiempoLlegadaProximoCliente = (long)t;
            tiempoLlegadaProximoCliente += tiempo;
        }

        public void ObtenerTiempoFindeCoccion()
        {           
            int cantProducto = stock != 0 ? condicionesIniciales.condicionesHorno.cantElementosConStock : condicionesIniciales.condicionesHorno.cantElementosSinStock;
            long tAux = horno.getTiempodeCoccion(cantProducto);
            tiempoFinCoccion = tAux + tiempo;

        }


        public void SetearTiempoProximoInicioHorno()
        {
            tiempoProximoEncendidoHorno = horno.getProximoEncendidoHorno() + tiempo;
        }

        public EstadoSimulacion Clone()
        {
            EstadoSimulacion estado = new EstadoSimulacion() {
                tiempo = tiempo,
                tiempoProximoEvento = tiempoProximoEvento,
                tiempoLlegadaProximoCliente = tiempoLlegadaProximoCliente,
                tiempoFinCoccion = tiempoFinCoccion,
                tiempoProximoEncendidoHorno = tiempoProximoEncendidoHorno,
                evento = evento,
                proximoEvento = proximoEvento,
                empleado1 = empleado1,
                empleado2 = empleado2,
                numeroEvento = numeroEvento,
                colaClientes = colaClientes,
                horno = horno,
                stock = stock,
                clientesPerdidos = clientesPerdidos,
                condicionesIniciales = condicionesIniciales,
                
            };

            return estado;
        } 
    }
}
