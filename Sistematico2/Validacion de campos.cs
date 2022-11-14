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
    public partial class CajaDeDialogo : Form
    {
        public CajaDeDialogo()
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

        private void CajaDeDialogo_Load(object sender, EventArgs e)
        {

        }
        
       




        private void button1_Click(object sender, EventArgs e)
        {
            CapturarDatos();
            ListViewItem fila = new ListViewItem(ContedoresDialogo.Nombre);
            fila.SubItems.Add(ContedoresDialogo.Apellido);
            fila.SubItems.Add(ContedoresDialogo.Carnet);
            fila.SubItems.Add(ContedoresDialogo.Carrera);
            fila.SubItems.Add(ContedoresDialogo.Telefono.ToString());
            fila.SubItems.Add(ContedoresDialogo.Pais);
            listView1.Items.Add(fila);

        }

        private void CapturarDatos()
        {
            ContedoresDialogo.Nombre = txtNombre.Text;
            ContedoresDialogo.Apellido = txtApellido.Text;
            ContedoresDialogo.Carnet = txtCarnet.Text;
            ContedoresDialogo.Telefono = int.Parse(txtTelefono.Text);
            ContedoresDialogo.Carrera = txtCarrera.Text;
            ContedoresDialogo.Pais = txtPais.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Datos");
            treeView1.Nodes[0].Nodes.Add("Personales");
            treeView1.Nodes[0].Nodes.Add("Universidad");
            treeView1.Nodes[0].Nodes[0].Nodes.Add(ContedoresDialogo.Nombre);
            treeView1.Nodes[0].Nodes[0].Nodes.Add(ContedoresDialogo.Apellido);
            treeView1.Nodes[0].Nodes[0].Nodes.Add(ContedoresDialogo.Telefono.ToString());
            treeView1.Nodes[0].Nodes[0].Nodes.Add(ContedoresDialogo.Pais);
            treeView1.Nodes[0].Nodes[1].Nodes.Add(ContedoresDialogo.Carnet);
            treeView1.Nodes[0].Nodes[1].Nodes.Add(ContedoresDialogo.Carrera);
            treeView1.EndUpdate();
        }
    }
}
