using System;
using System.Collections.Generic;
using System.Text;
using Logica;
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
                    break;
            }

            return estadoAnterior;
        }

    }
}
