using Logica.Condiciones;
using Simulacion.Utilidades.Distribuciones;
using System;

namespace Logica
{
    public class Empleado
    {
        private static CondicionesEmpleado condicionesInicialesEmpleado { get; set; }
        private static DistribucionUniforme generador { get; set; }
        public bool Libre { get; set; }
        public Cliente cliente { get; set; }
        public long TiempoFinAtencion { get; set; }
        public Evento eventoFinAtencion { get; set; }

        public Empleado(Evento eventoFinAtencion)
        {
            Libre = true;
            this.eventoFinAtencion = eventoFinAtencion;
            generador = new DistribucionUniforme(condicionesInicialesEmpleado.aEmpleado, condicionesInicialesEmpleado.bEmpleado);
        }

        public long ObtenerTiempoFinDeAtencion()
        {
            return TiempoFinAtencion;
        }

        public static void SetEstadosIniciales(CondicionesEmpleado condicionesEmpleado)
        {
            condicionesInicialesEmpleado = condicionesEmpleado;
        }

        public Evento obtenerEventoEmpleado()
        {
            return eventoFinAtencion;
        }

        public void finalizarAtencion()
        {
            cliente = null;

        }

        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
            Libre = false;
            generarTiempoAtencion();
        }

        private void generarTiempoAtencion()
        {
            TiempoFinAtencion = (long)generador.ObtenerVariableAleatoria();
        }
    }
}