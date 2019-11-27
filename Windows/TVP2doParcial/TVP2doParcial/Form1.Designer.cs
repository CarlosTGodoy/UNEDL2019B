namespace TVP2doParcial
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ctnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(201, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Examen Segundo Parcial";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(119, 93);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(97, 13);
            this.lblIngreso.TabIndex = 1;
            this.lblIngreso.Text = "Ingrese la palabra: ";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(261, 90);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(176, 20);
            this.txtIngreso.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(224, 145);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ctnCalcular
            // 
            this.ctnCalcular.Location = new System.Drawing.Point(224, 228);
            this.ctnCalcular.Name = "ctnCalcular";
            this.ctnCalcular.Size = new System.Drawing.Size(75, 23);
            this.ctnCalcular.TabIndex = 4;
            this.ctnCalcular.Text = "Calcular";
            this.ctnCalcular.UseVisualStyleBackColor = true;
            this.ctnCalcular.Click += new System.EventHandler(this.ctnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 361);
            this.Controls.Add(this.ctnCalcular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button ctnCalcular;
    }
}

