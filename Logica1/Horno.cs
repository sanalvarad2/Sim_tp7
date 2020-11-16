using Logica.Condiciones;
using System;

namespace Logica
{
    public class Horno
    {
        private static CondicionesHorno condicionesHorno { get; set; }
        private int CantElementos { get; set; }

        public static void SetEstadosIniciales(CondicionesHorno condicionesIHorno)
        {
            condicionesHorno = condicionesIHorno;
        }

        public long getTiempodeCoccion(int CantidadElementos)
        {
            double t;
            double h = condicionesHorno.paso;
            double T = condicionesHorno.tempInicia;
            double tAnterior = 0.0;
            double cantMinutos = 0.0;
            this.CantElementos = CantidadElementos;

            for (t = 0.0; Math.Floor(cantMinutos / condicionesHorno.EquivalenteMinutos) < 15; t += h)
            {
                double k1 = h * (-0.5 * T + 900/(double)CantidadElementos);
                double k2 = h * (-0.5 * (T + 0.5 * k1) + 900 / (double)CantidadElementos);
                double k3 = h * (-0.5 * (T + 0.5 * k2) + 900 / (double)CantidadElementos);
                double k4 = h * (-0.5 * (T + k3) + 900 / (double)CantidadElementos);

                T += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                
                if (Math.Round(T, 4) != Math.Round(tAnterior, 4))
                {
                    cantMinutos = 0;
                }
                else
                {
                    cantMinutos += h;
                }

                tAnterior = T;
            }

            long  tiempo = (long)(t / (double)condicionesHorno.EquivalenteMinutos * 60.0);
            return tiempo;
        }

        public double getProximoEncendidoHorno()
        {
            return condicionesHorno.TiempoEntreInicio;
        }

        public int getCantidadElementosCoccion()
        {
            return CantElementos;
        }
    }
}