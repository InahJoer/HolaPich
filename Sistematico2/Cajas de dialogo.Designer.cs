namespace Sistematico2
{
    partial class ValidacioDeCampos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mtxtDato = new System.Windows.Forms.MaskedTextBox();
            this.brnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(606, 262);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(82, 22);
            this.btnvolver.TabIndex = 0;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(606, 301);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 22);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mtxtDato
            // 
            this.mtxtDato.Location = new System.Drawing.Point(18, 49);
            this.mtxtDato.Mask = "00/00/0000";
            this.mtxtDato.Name = "mtxtDato";
            this.mtxtDato.Size = new System.Drawing.Size(100, 23);
            this.mtxtDato.TabIndex = 2;
            this.mtxtDato.ValidatingType = typeof(System.DateTime);
            this.mtxtDato.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtDato_MaskInputRejected);
            // 
            // brnMostrar
            // 
            this.brnMostrar.Location = new System.Drawing.Point(134, 49);
            this.brnMostrar.Name = "brnMostrar";
            this.brnMostrar.Size = new System.Drawing.Size(75, 23);
            this.brnMostrar.TabIndex = 3;
            this.brnMostrar.Text = "mostrar";
            this.brnMostrar.UseVisualStyleBackColor = true;
            this.brnMostrar.Click += new System.EventHandler(this.brnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Gold;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.mtxtDato);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.brnMostrar);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnIngresar);
            this.splitContainer1.Panel2.Controls.Add(this.txtEdad);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtApellido);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Size = new System.Drawing.Size(560, 314);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uso MaskedTextBox";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(179, 57);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(85, 47);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar Datos";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(35, 206);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 23);
            this.txtEdad.TabIndex = 12;
            this.txtEdad.Validating += new System.ComponentModel.CancelEventHandler(this.txtEdad_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Edad";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(35, 132);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uso Validating";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ValidacioDeCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnvolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ValidacioDeCampos";
            this.Text = "Cajas_de_dialogo";
            this.Load += new System.EventHandler(this.Cajas_de_dialogo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnvolver;
        private Button btnSalir;
        private MaskedTextBox mtxtDato;
        private Button brnMostrar;
        private Label label1;
        private SplitContainer splitContainer1;
        private Label label2;
        private Button btnIngresar;
        private TextBox txtEdad;
        private Label label6;
        private TextBox txtApellido;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}