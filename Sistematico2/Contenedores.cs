using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design.Behavior;

namespace Sistematico2
{
    public partial class Contenedores : Form
    {
        public Contenedores()
        {
            InitializeComponent();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Contenedores_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            splitContainer1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            splitContainer1.Visible = true;
        }
    }
}
