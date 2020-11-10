using System;
using System.Collections.Generic;
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
        public Evento evento { get; set; }
        public Evento proximoEvento { get; set; }
        public Empleado empleado1 { get; set; }
        public Empleado empleado2 { get; set; }
        public int numeroEvento { get; set; }
        public List<Cliente> colaClientes { get; set; }
        public Horno horno { get; set; }
        public int stock { get; set; }
        public int clientesPerdidos { get; set; }
        Condiciones.Condiciones condicionesIniciales { get; set; }

        private EstadoSimulacion() { }

        public EstadoSimulacion(Condiciones.Condiciones condicionesIniciales)
        {
            this.condicionesIniciales = condicionesIniciales;
            tiempo = 0;
            evento = Evento.Inicio;
            empleado1 = new Empleado(this.condicionesIniciales.condicionesEmpleado);//crear contructor
            empleado2 = new Empleado(this.condicionesIniciales.condicionesEmpleado);
            horno = new Horno(this.condicionesIniciales.condicionesHorno);
            numeroEvento = 0;
            colaClientes = new List<Cliente>();
            stock = 0;
            clientesPerdidos = 0;
            ObtenerTiempoLlegadaProximoCliente(tiempo);
            //tiempoProximoEvento =
        }


        public void ObtenerTiempoLlegadaProximoCliente(long tiempo)
        {
            DistribucionExponencialNegativa distribucionExponencialNegativa = new DistribucionExponencialNegativa(condicionesIniciales.condicionesCliente.lamdaLlegada);
            tiempoLlegadaProximoCliente = (long)(distribucionExponencialNegativa.ObtenerVariableAleatoria() * 60.0);
            tiempoLlegadaProximoCliente += tiempo;
        }

        public EstadoSimulacion Clone()
        {
            EstadoSimulacion estado = new EstadoSimulacion() {
                tiempo = tiempo,
                tiempoProximoEvento = tiempoProximoEvento,
                tiempoLlegadaProximoCliente = tiempoLlegadaProximoCliente,
                evento = evento,
                proximoEvento = proximoEvento,
                empleado1 = empleado1,
                numeroEvento = numeroEvento,
                colaClientes = colaClientes,
                horno = horno,
                stock = stock,
                clientesPerdidos = clientesPerdidos,
                condicionesIniciales = condicionesIniciales
            };

            return estado;
        } 
    }
}
