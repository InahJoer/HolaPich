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
    public partial class ValidacioDeCampos : Form
    {
        public ValidacioDeCampos()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
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

        private void mtxtDato_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Cajas_de_dialogo_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void brnMostrar_Click(object sender, EventArgs e)
        {
            label1.Text = mtxtDato.Text;
            label1.Visible = true;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            BorrarMensaje();
            if (ValidadCampos())
            {
                MessageBox.Show("Datos Ingresados Correctamente");
            }
           

        }

        private bool ValidadCampos()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingresar nombre");
            }
            if (txtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Ingresar nombre");
            }
            if (txtEdad.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtEdad, "Ingresar nombre");
            }
            return ok;

        }
        private void BorrarMensaje()
        {
            errorProvider1.SetError(txtNombre, "");
            errorProvider1.SetError(txtApellido, "");
            errorProvider1.SetError(txtEdad, "");
        }

        private void txtEdad_Validating(object sender, CancelEventArgs e)
        {
            int num;
            if(!int.TryParse(txtEdad.Text,out num))
            {
                errorProvider1.SetError(txtEdad, "Ingrese valor en numeros");
            }
            else
            {
                errorProvider1.SetError(txtEdad, "");
            }
        }
    }
}
