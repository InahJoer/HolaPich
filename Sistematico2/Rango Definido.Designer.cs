namespace Sistematico2
{
    partial class Rango_Definido
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.bar1 = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCambioColor = new System.Windows.Forms.Label();
            this.bar3 = new System.Windows.Forms.HScrollBar();
            this.bar2 = new System.Windows.Forms.HScrollBar();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(569, 226);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(82, 22);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(569, 268);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 22);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 73);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(261, 25);
            this.progressBar1.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(403, 45);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(196, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // bar1
            // 
            this.bar1.LargeChange = 0;
            this.bar1.Location = new System.Drawing.Point(57, 275);
            this.bar1.Maximum = 255;
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(216, 28);
            this.bar1.SmallChange = 0;
            this.bar1.TabIndex = 4;
            this.bar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Progress Bar";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(85, 55);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(89, 15);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Realizando...0%";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(191, 113);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(82, 22);
            this.btnComenzar.TabIndex = 7;
            this.btnComenzar.Text = "Detonar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "ScrollBar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "TrackBar";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(403, 99);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 15);
            this.lblValor.TabIndex = 13;
            this.lblValor.Text = "LABEL";
            // 
            // lblCambioColor
            // 
            this.lblCambioColor.AutoSize = true;
            this.lblCambioColor.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCambioColor.Location = new System.Drawing.Point(57, 205);
            this.lblCambioColor.Name = "lblCambioColor";
            this.lblCambioColor.Size = new System.Drawing.Size(406, 44);
            this.lblCambioColor.TabIndex = 14;
            this.lblCambioColor.Text = "GOLLL DE MESSI!!!!!!!";
            // 
            // bar3
            // 
            this.bar3.LargeChange = 0;
            this.bar3.Location = new System.Drawing.Point(57, 354);
            this.bar3.Maximum = 255;
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(216, 28);
            this.bar3.SmallChange = 0;
            this.bar3.TabIndex = 15;
            this.bar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar3_Scroll);
            // 
            // bar2
            // 
            this.bar2.LargeChange = 0;
            this.bar2.Location = new System.Drawing.Point(57, 314);
            this.bar2.Maximum = 255;
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(216, 28);
            this.bar2.SmallChange = 0;
            this.bar2.TabIndex = 16;
            this.bar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bar2_Scroll);
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRojo.Location = new System.Drawing.Point(297, 275);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(114, 25);
            this.lblRojo.TabIndex = 17;
            this.lblRojo.Text = "Gama Rojo:";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVerde.Location = new System.Drawing.Point(297, 314);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(125, 25);
            this.lblVerde.TabIndex = 18;
            this.lblVerde.Text = "Gama Verde:";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAzul.Location = new System.Drawing.Point(297, 354);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(112, 25);
            this.lblAzul.TabIndex = 19;
            this.lblAzul.Text = "Gama Azul:";
            // 
            // Rango_Definido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(765, 403);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.lblCambioColor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVolver);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rango_Definido";
            this.Text = "Rango_Definido";
            this.Load += new System.EventHandler(this.Rango_Definido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVolver;
        private Button btnSalir;
        private ProgressBar progressBar1;
        private TrackBar trackBar1;
        private HScrollBar bar1;
        private Label label1;
        private Label lblEstado;
        private Button btnComenzar;
        private Label label2;
        private Label label3;
        private Label lblValor;
        private Label lblCambioColor;
        private HScrollBar bar3;
        private HScrollBar bar2;
        private Label lblRojo;
        private Label lblVerde;
        private Label lblAzul;
    }
}