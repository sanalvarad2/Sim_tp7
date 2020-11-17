using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Logica.Condiciones;

namespace App
{
    public partial class Colas : Form
    {
        private Simulacion sim { get; set; }
        public Colas()
        {
            InitializeComponent();
        }

        private void Colas_Load(object sender, EventArgs e)
        {         
        }

        private void btnGenerarSimulacionDiaria_Click(object sender, EventArgs e)
        {
            Horno app = new Horno();
            this.Hide();
            app.ShowDialog();
            this.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            lblPorcClientePerdido.Visible = false;
            dgvSimulacion.Rows.Clear();
            dgvSimulacion.Enabled = false;
            btnGenerar.Visible = false;
            progressBar.Visible = true;

            Condiciones cIniciales = ObtenerCondiciones();
            sim = new Simulacion(cIniciales);
            AgregarFila(sim.estadoAnterior);

            int i = 0;
            EstadoSimulacion s = sim.estadoAnterior;
            while (i <= Convert.ToInt32(txtCantSim.Text))
            {
                s = sim.GenerarSimulacion();
                if(s.numeroEvento >= Convert.ToInt32(txtSimApartir.Text) && s.numeroEvento<= Convert.ToInt32(txtSimApartir.Text) + 50)
                {
                    AgregarFila(s);
                }
                else if(s.numeroEvento % Convert.ToInt32(txtMostrarCada.Text) == 0){
                    AgregarFila(s);
                }

                if (i == Convert.ToInt32(txtCantSim.Text) / 10)
                {
                    progressBar.Value = 10;
                }
                if (i == Convert.ToInt32(txtCantSim.Text) / 10 * 2)
                {
                    progressBar.Value = 20;
                }
                if (i == Convert.ToInt32(txtCantSim.Text) / 10 * 3)
                {
                    progressBar.Value = 30;
                }
                if (i == Convert.ToInt32(txtCantSim.Text) / 10 * 4)
                {
                    progressBar.Value = 40;
                }
                if (i == Convert.ToInt32(txtCantSim.Text) / 10 * 5)
                {
                    progressBar.Value = 50;
                }
                if (i == Convert.ToInt32(txtCantSim.Text) / 60)
                {
                    progressBar.Value = 60;
                }
                if (i == Convert.ToInt32(txtCantSim.Text) / 10 * 7)
                {
                    progressBar.Value = 70;
                }
                if (i == Convert.ToInt32(txtCantSim.Text) / 10 * 8)
                {
                    progressBar.Value = 80;
                }
                if (i == Convert.ToInt32(txtCantSim.Text) / 10 * 9)
                {
                    progressBar.Value = 90;
                }
                if (i == Convert.ToInt32(txtCantSim.Text))
                {
                    progressBar.Value = 100;
                }
                i++;
            }
            lblPorcClientePerdido.Visible = true;
            lblPorcClientePerdido.Text = StringifyCifra((double)(s.clientesPerdidos / (double)s.numeroCliente) * 100) +"%";
            progressBar.Visible = false;
            btnGenerar.Visible = true;
            dgvSimulacion.Enabled = true;


        }

        private string StringifyCifra(double cifra)
        {
            var nfi = new NumberFormatInfo
            {
                NumberDecimalSeparator = ",",
                NumberGroupSeparator = "."
            };

            string resultado = cifra.ToString("#,##0.0000", nfi);

            return resultado;
        }

        private void AgregarFila(EstadoSimulacion estado)
        {
            int numeroEvento = estado.numeroEvento;
            Evento evento = estado.evento;
            string reloj = StringifyHora(estado.tiempo);
            string tiempoProximoCliente = StringifyHora(estado.tiempoLlegadaProximoCliente);
            int stock = estado.stock;
            int colaClientes = estado.colaClientes.Count();
            int clientesPerdidos = estado.clientesPerdidos;

            #region Empleado1
            string emp1Estado = estado.empleado1.Libre ? "Libre" : "Ocupado";
            string emp1NroCliente = estado.empleado1.Libre ? "-" : estado.empleado1.cliente.id.ToString();
            string emp1CantElem = estado.empleado1.Libre ? "-" : estado.empleado1.cliente.CantidadPedido.ToString();
            string emp1tiempoAtencion = estado.empleado1.Libre ? "-" : StringifyHora(estado.empleado1.TiempoFinAtencion);
            #endregion

            #region Empleado2
            string emp2Estado = estado.empleado2.Libre ? "Libre" : "Ocupado";
            string emp2NroCliente = estado.empleado2.Libre ? "-" : estado.empleado2.cliente.id.ToString();
            string emp2CantElem = estado.empleado2.Libre ? "-" : estado.empleado2.cliente.CantidadPedido.ToString();
            string emp2tiempoAtencion = estado.empleado2.Libre ? "-": StringifyHora(estado.empleado2.TiempoFinAtencion);
            #endregion

            #region Horno
            string hornoEstado = estado.horno.getEstado() ? "Encendido" : "Apagado";
            string hornoTiempoCoccion = estado.horno.getEstado() ? StringifyHora(estado.tiempoFinCoccion) : "-";
            string hornoCantElementos = estado.horno.getEstado() ? estado.horno.getCantidadElementosCoccion().ToString() : "-";
            #endregion


            dgvSimulacion.Rows.Add(numeroEvento, evento, reloj, tiempoProximoCliente, stock, colaClientes, clientesPerdidos, emp1Estado, emp1NroCliente, emp1CantElem, emp1tiempoAtencion,
                emp2Estado, emp2NroCliente, emp2CantElem, emp2tiempoAtencion, hornoEstado, hornoTiempoCoccion, hornoCantElementos);
        }

        private Condiciones ObtenerCondiciones()
        {

            Condiciones cond = new Condiciones()
            {
                condicionesCliente = new CondicionesCliente()
                {
                    aProducto = Convert.ToInt32(txtaCliente.Text),
                    bProducto = Convert.ToInt32(txtbCliente.Text) + 1 ,
                    lamdaLlegada = 1 / (Convert.ToDouble(txtMediaCliente.Text) * 60.0),
                    TiempoLimite = (long)(Convert.ToDouble(txttiempoLimite.Text) * 60)
                },

                condicionesEmpleado = new CondicionesEmpleado()
                {
                    aEmpleado = (double)Convert.ToDouble(txtAEmpleado.Text) * 60.0,
                    bEmpleado = (double)Convert.ToDouble(txtBEmpleado.Text) * 60.0
                },

                condicionesHorno = new CondicionesHorno()
                {
                    cantElementosConStock = Convert.ToInt32(txtHornoCantStock.Text),
                    cantElementosSinStock = Convert.ToInt32(txtHornoCantSStock.Text),
                    EquivalenteMinutos = Convert.ToDouble(txtEquivalenciaEnMinutos.Text),
                    paso = Convert.ToDouble(txtPaso.Text),
                    tempInicia = Convert.ToDouble(txtHornoTinic.Text),
                    TiempoEntreInicio = (long)(Convert.ToDouble(txtHornoTiempoInicio.Text) * 60)
                }
            };

            lblEquiv.Text = StringifyCifra(cond.condicionesHorno.EquivalenteMinutos / cond.condicionesHorno.paso);
            return cond;
        }

        private string StringifyHora(long tiempo)
        {
            string horas = (tiempo / 3600).ToString();
            long restoHoras = tiempo % 3600;
            string minutos = (restoHoras / 60).ToString();
            string segundos = (restoHoras % 60).ToString();

            if (horas.Length < 2)
                horas = "0" + horas;

            if (minutos.Length < 2)
                minutos = "0" + minutos;

            if (segundos.Length < 2)
                segundos = "0" + segundos;

            return horas + ":" + minutos + ":" + segundos;
        }

    }
}
