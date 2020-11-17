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

            tiempoProximoEvento = tiempoLlegadaProximoCliente;
            proximoEvento = Evento.LlegaCliente;

            if(ProximoEmpleado != null)
            {
                if (ProximoEmpleado.ObtenerTiempoFinDeAtencion() < tiempoProximoEvento)
                {
                    tiempoProximoEvento = ProximoEmpleado.ObtenerTiempoFinDeAtencion();
                    proximoEvento = ProximoEmpleado.obtenerEventoEmpleado();
                }
            }

            if (tiempoProximoEvento > tiempoFinCoccion && horno.getEstado())
            {
                tiempoProximoEvento = tiempoFinCoccion;
                proximoEvento = Evento.FinCoccionHorno;
            }

            if(tiempoProximoEvento > tiempoProximoEncendidoHorno && !horno.getEstado())
            {
                tiempoProximoEvento = tiempoProximoEncendidoHorno;
                proximoEvento = Evento.EncendidoHorno;
            }

            if(stock == 0 && !horno.getEstado())
            {
                tiempoProximoEvento = tiempo + 1 ;
                proximoEvento = Evento.EncendidoHorno;
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
            tiempoProximoEncendidoHorno = tiempoFinCoccion + horno.getProximoEncendidoHorno();

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
                numeroCliente = numeroCliente,
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
