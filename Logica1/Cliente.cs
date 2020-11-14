using Logica.Condiciones;
using Simulacion.Utilidades.Distribuciones;
using Simulacion.Utilidades.Generadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class Cliente
    {

        public int id { get; set; }
        public long TiempoLlegada { get; set; }
        public long TiempoLimite { get; set; }
        public static CondicionesCliente condIniciales { get; set; }
        private static DistribucionUniforme generador;
        public int CantidadPedido { get; set; }

        public static void SetEstadosIniciales(CondicionesCliente condicionesCliente)
        {
            condIniciales = condicionesCliente;
            generador = new DistribucionUniforme(condIniciales.aProducto, condIniciales.bProducto);//revisar
        }

        public Cliente(long tiempo, int acumulador)
        {

            id = acumulador + 1;

            TiempoLlegada = tiempo;
            TiempoLimite = tiempo + condIniciales.TiempoLimite;
            CantidadPedido = (int) generador.ObtenerVariableAleatoria();
        }


        public int ObtenerCantidadPedidos()
        {

            return CantidadPedido;
        }

        public long ObtenerTiempoLimite()
        {
            return TiempoLimite;
        }

    }
}
