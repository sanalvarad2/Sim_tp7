using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace App
{
    public partial class Colas : Form
    {
        public Colas()
        {
            InitializeComponent();
        }

        private void Colas_Load(object sender, EventArgs e)
        {
            Logica.Condiciones.Condiciones condiciones = new Logica.Condiciones.Condiciones()
            {
                condicionesCliente = new Logica.Condiciones.CondicionesCliente()
                {
                    aProducto = 1,
                    bProducto = 3,
                    lamdaLlegada = 1/ (3 * 60.0),
                    TiempoLimite = 5 * 60
                },

                condicionesEmpleado = new Logica.Condiciones.CondicionesEmpleado()
                {
                    aEmpleado = (double)0.5 * 60.0,
                    bEmpleado = (double)1.5 * 60.0
                },

                condicionesHorno = new Logica.Condiciones.CondicionesHorno()
                {
                    cantElementosConStock = 30,
                    cantElementosSinStock = 45,
                    EquivalenteMinutos = 2,
                    paso = 0.05,
                    tempInicia = 5,
                    TiempoEntreInicio = 45 * 60
                }
            };

            Simulacion sim = new Simulacion(condiciones);
            sim.GenerarSimulacion();
            sim.GenerarSimulacion();
        }
    }
}
