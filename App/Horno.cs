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

namespace App
{
    public partial class Horno : Form
    {
        public Horno()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgvHorno.Rows.Clear();

            double cantElem = Convert.ToDouble(txtElementos.Text);
            double h = Convert.ToDouble(txtH.Text);
            double EquvTiempo = Convert.ToDouble(txtEquiv.Text);
            double TInic = Convert.ToDouble(txtTnic.Text);

            double tAnterior = 0.0;
            double cantMinutos = 0.0;
            double T = TInic;
            double t;


            for (t = 0.0; Math.Floor(cantMinutos / EquvTiempo) < 15; t += h)
            {
                double k1 = h * (-0.5 * T + 900 / cantElem);
                double k2 = h * (-0.5 * (T + 0.5 * k1) + 900 / cantElem);
                double k3 = h * (-0.5 * (T + 0.5 * k2) + 900 / cantElem);
                double k4 = h * (-0.5 * (T + k3) + 900 / cantElem);

                dgvHorno.Rows.Add(StringifyCifra(t), StringifyCifra(T), StringifyCifra(k1), StringifyCifra(k2), StringifyCifra(k3), StringifyCifra(k4));

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

            dgvHorno.Rows.Add(StringifyCifra(t), StringifyCifra(T), "-", "-", "-", "-");

            long tiempo = (long)(t / EquvTiempo * 60.0);
            lblTiempoCalculado.Text = StringifyHora((int)tiempo);
        }

        private string StringifyHora(int tiempo)
        {
            string horas = (tiempo / 3600).ToString();
            int restoHoras = tiempo % 3600;
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
    }
}
