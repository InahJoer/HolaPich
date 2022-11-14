using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico2
{
    public partial class Rango_Definido : Form
    {
        public Rango_Definido()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Está seguro de salir?", "componentes",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private Task ProcesoDatos(List<string> list, IProgress<BarraProgreso> progress)
        {
            int index = 1;
            int total = list.Count;
            var barraProgreso = new BarraProgreso();
            return Task.Run(() =>
            {
                for (int i = 0; i < total; i++)
                {
                    barraProgreso.PorcentajeCompleto = index++ * 100 / total;
                    progress.Report(barraProgreso);
                    Thread.Sleep(10);
                }
            });
        }
        private async void btnComenzar_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
                list.Add(i.ToString());
            lblEstado.Text = "Trabajando...";
            var progress = new Progress<BarraProgreso>();
            progress.ProgressChanged += (o, report) =>
            {
                lblEstado.Text = String.Format("Procesando....{0}", report.PorcentajeCompleto);
                progressBar1.Value = report.PorcentajeCompleto;
                progressBar1.Update();
            };
            await ProcesoDatos(list, progress);
            lblEstado.Text = "Hecho";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblValor.Text = trackBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Rango_Definido_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblCambioColor.ForeColor = Color.FromArgb(bar1.Value, bar3.Value, bar2.Value);
            lblRojo.Text = "Gama Rojo : " + bar1.Value.ToString();
        }

        private void bar2_Scroll(object sender, ScrollEventArgs e)
        {

            lblCambioColor.ForeColor = Color.FromArgb(bar1.Value, bar3.Value, bar2.Value);
            lblVerde.Text = "Gama Verde : " + bar2.Value.ToString();
        }

        private void bar3_Scroll(object sender, ScrollEventArgs e)
        {
            lblCambioColor.ForeColor = Color.FromArgb(bar1.Value, bar3.Value, bar2.Value);
            lblAzul.Text = "Gama Azul : " + bar3.Value.ToString();
        }
    }

}