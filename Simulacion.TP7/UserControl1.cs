using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion.TP7
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            Logica.Condiciones.Condiciones cond = new Logica.Condiciones.Condiciones()
            {
                condicionesCliente = new Logica.Condiciones.CondicionesCliente()
                {
                    TiempoLimite = (long)5 * 60,
                    aProducto = 1,
                    bProducto = 2,
                    lamdaLlegada = 1 / (3.0 * 60.0)

                },
                condicionesEmpleado = new Logica.Condiciones.CondicionesEmpleado()
                {

                },
                condicionesHorno = new Logica.Condiciones.CondicionesHorno()
                {
                    cantElementosConStock = 30,
                    cantElementosSinStock = 45,
                    EquivalenteMinutos = 1,
                    paso = 0.01,
                    tempInicia = 5.0,
                    TiempoEntreInicio = 45 *60
                    
                }
            };

            Logica.Simulacion sim = new Logica.Simulacion(cond);
            sim.GenerarSimulacion();
            sim.GenerarSimulacion();
        }
    }
}
