namespace Problema_1._8
{
    partial class frmCursos
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPromGral = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPromedios = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLegajos = new System.Windows.Forms.ListBox();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(188, 250);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Promedio Gral.";
            // 
            // txtPromGral
            // 
            this.txtPromGral.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtPromGral.Location = new System.Drawing.Point(416, 252);
            this.txtPromGral.Name = "txtPromGral";
            this.txtPromGral.ReadOnly = true;
            this.txtPromGral.Size = new System.Drawing.Size(75, 20);
            this.txtPromGral.TabIndex = 39;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(351, 101);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(59, 23);
            this.btnCalcular.TabIndex = 26;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(416, 192);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 27;
            this.btnMostrar.Text = "Mostrar ";
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.AutoSize = true;
            this.btnCargar.BackgroundImage = global::Problema_1._8.Properties.Resources.confirm;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(260, 188);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(85, 40);
            this.btnCargar.TabIndex = 25;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Nota 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nota 1";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(158, 188);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(41, 20);
            this.txtNota3.TabIndex = 24;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(92, 188);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(41, 20);
            this.txtNota2.TabIndex = 23;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(26, 188);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(41, 20);
            this.txtNota1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Promedios";
            // 
            // lstPromedios
            // 
            this.lstPromedios.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstPromedios.FormattingEnabled = true;
            this.lstPromedios.Location = new System.Drawing.Point(416, 70);
            this.lstPromedios.Name = "lstPromedios";
            this.lstPromedios.Size = new System.Drawing.Size(83, 95);
            this.lstPromedios.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Legajo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // lstLegajos
            // 
            this.lstLegajos.FormattingEnabled = true;
            this.lstLegajos.Location = new System.Drawing.Point(245, 70);
            this.lstLegajos.Name = "lstLegajos";
            this.lstLegajos.Size = new System.Drawing.Size(100, 95);
            this.lstLegajos.TabIndex = 30;
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(26, 70);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(192, 95);
            this.lstNombres.TabIndex = 29;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(245, 37);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(26, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 313);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPromGral);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPromedios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstLegajos);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmCursos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPromGral;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPromedios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLegajos;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

