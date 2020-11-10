using Logica.Condiciones;
using System;

namespace Logica
{
    public class Horno
    {
        private CondicionesHorno condicionesHorno;

        public Horno(CondicionesHorno condicionesHorno)
        {
            this.condicionesHorno = condicionesHorno;
        }

        public long getTiempodeCoccion(int CantidadElementos)
        {
            double t;
            double h = condicionesHorno.paso;
            double T = condicionesHorno.tempInicia;
            int cantMinutos = 0;
            for (t = 0.0; cantMinutos == 15; t += h)
            {
                double k1 = h * (-0.5 * T + 900/(double)CantidadElementos);
                double k2 = h * (-0.5 * (T + 0.5 * k1) + 900 / (double)CantidadElementos);
                double k3 = h * (-0.5 * (T + 0.5 * k2) + 900 / (double)CantidadElementos);
                double k4 = h * (-0.5 * (T + k3) + 900 / (double)CantidadElementos);

                T += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
            }

            double tiempo = t / (double)condicionesHorno.EquivalenteMinutos * 60.0;
            return (long) tiempo;
        }
    }
}