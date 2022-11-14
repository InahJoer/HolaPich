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
    public partial class MenuyBarras : Form
    {
        public MenuyBarras()
        {
            InitializeComponent();
        }

       

        private void contenedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contenedores contenedor = new Contenedores();
            this.Hide();
            contenedor.ShowDialog();
            this.Close();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidacioDeCampos menubarra = new ValidacioDeCampos();
            this.Hide();
            menubarra.ShowDialog();
            this.Close();
        }

        private void rangoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rango_Definido rango = new Rango_Definido();
            this.Hide();
            rango.ShowDialog();
            this.Close();
        }

        private void validacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CajaDeDialogo validacion = new CajaDeDialogo();
            this.Hide();
            validacion.ShowDialog();
            this.Close();
        }

        private void MenuyBarras_MouseMove(object sender, MouseEventArgs e)
        {

            toolStripStatusLabel2.Text = DateTime.Now.ToString("ddd");
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Amigo, vas a salir, estas seguro de ello?", "componentes",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsbVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void porDetrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cambio = new ColorDialog()) 
            {
                if (cambio.ShowDialog() == DialogResult.OK)
                    txtmenu.BackColor = cambio.Color;
            }
        }

        private void MenuyBarras_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button1,0,button1.Height);
        }

        private void fondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog co = new ColorDialog())
            {
                if (co.ShowDialog() == DialogResult.OK)
                    txtmenu.ForeColor = co.Color;
            }

        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
