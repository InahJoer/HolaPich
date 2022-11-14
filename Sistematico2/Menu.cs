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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMenuBarra_Click(object sender, EventArgs e)
        {
            MenuyBarras menuyBarras = new MenuyBarras();
            this.Hide();
            menuyBarras.ShowDialog();
            this.Close();
        }

        private void btnContenedores_Click(object sender, EventArgs e)
        {
            Contenedores contenedor = new Contenedores();
            this.Hide();
            contenedor.ShowDialog();
            this.Close();
        }

        private void btnValidacionCampos_Click(object sender, EventArgs e)
        {
            CajaDeDialogo validacion = new CajaDeDialogo();
            this.Hide();
            validacion.ShowDialog();
            this.Close();
        }

        private void btnRangoDef_Click(object sender, EventArgs e)
        {
            Rango_Definido rango = new Rango_Definido();
            this.Hide();
            rango.ShowDialog();
            this.Close();

        }

        private void btnCajaDailogos_Click(object sender, EventArgs e)
        {
            ValidacioDeCampos menubarra = new ValidacioDeCampos();
            this.Hide();
            menubarra.ShowDialog();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Está seguro de salir?", "Componentes",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
