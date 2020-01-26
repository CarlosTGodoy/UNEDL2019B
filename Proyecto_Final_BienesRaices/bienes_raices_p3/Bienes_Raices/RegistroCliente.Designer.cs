namespace Bienes_Raices
{
    partial class RegistroCliente
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.tbxMovimiento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.tbxPais = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.tbxCelular = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxNombreS = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(336, 37);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(0, 35);
            this.lblRegistro.TabIndex = 45;
            // 
            // tbxMovimiento
            // 
            this.tbxMovimiento.Location = new System.Drawing.Point(274, 398);
            this.tbxMovimiento.Name = "tbxMovimiento";
            this.tbxMovimiento.Size = new System.Drawing.Size(47, 20);
            this.tbxMovimiento.TabIndex = 97;
            this.tbxMovimiento.TextChanged += new System.EventHandler(this.tbxMovimiento_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(102, 359);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 96;
            this.label14.Text = "Renta casas: 1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 95;
            this.label13.Text = "Venta casa: 3 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 94;
            this.label12.Text = "Tipo de movimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(210, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 93;
            this.label11.Text = "Renta depto.: 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "Venta depto: 4";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Aguascalientes",
            "",
            "Baja California",
            "",
            "Baja California Sur",
            "",
            "Campeche",
            "",
            "Chiapas",
            "",
            "Chihuahua",
            "",
            "Coahuila",
            "",
            "Colima",
            "",
            "Distrito Federal",
            "",
            "Durango",
            "",
            "Estado de México",
            "",
            "Guanajuato",
            "",
            "Guerrero",
            "",
            "Hidalgo",
            "",
            "Jalisco",
            "",
            "Michoacán",
            "",
            "Morelos",
            "",
            "Nayarit",
            "",
            "Nuevo León",
            "",
            "Oaxaca",
            "",
            "Puebla",
            "",
            "Querétaro",
            "",
            "Quintana Roo",
            "",
            "San Luis Potosí",
            "",
            "Sinaloa",
            "",
            "Sonora",
            "",
            "Tabasco",
            "",
            "Tamaulipas",
            "",
            "Tlaxcala",
            "",
            "Veracruz",
            "",
            "Yucatán",
            "",
            "Zacatecas"});
            this.cbxEstado.Location = new System.Drawing.Point(369, 285);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(193, 21);
            this.cbxEstado.TabIndex = 91;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // tbxPais
            // 
            this.tbxPais.Location = new System.Drawing.Point(153, 278);
            this.tbxPais.Name = "tbxPais";
            this.tbxPais.Size = new System.Drawing.Size(100, 20);
            this.tbxPais.TabIndex = 90;
            this.tbxPais.Text = "Mexico";
            this.tbxPais.TextChanged += new System.EventHandler(this.tbxPais_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Pais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Correo electronico";
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.Location = new System.Drawing.Point(187, 182);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(375, 20);
            this.tbxCorreo.TabIndex = 84;
            this.tbxCorreo.TextChanged += new System.EventHandler(this.tbxCorreo_TextChanged);
            // 
            // tbxCelular
            // 
            this.tbxCelular.Location = new System.Drawing.Point(153, 222);
            this.tbxCelular.Name = "tbxCelular";
            this.tbxCelular.Size = new System.Drawing.Size(100, 20);
            this.tbxCelular.TabIndex = 83;
            this.tbxCelular.Text = "(33)";
            this.tbxCelular.TextChanged += new System.EventHandler(this.tbxCelular_TextChanged);
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(369, 225);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(193, 20);
            this.tbxTelefono.TabIndex = 82;
            this.tbxTelefono.Text = "(33)";
            this.tbxTelefono.TextChanged += new System.EventHandler(this.tbxTelefono_TextChanged);
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(153, 141);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(409, 20);
            this.tbxApellido.TabIndex = 80;
            this.tbxApellido.TextChanged += new System.EventHandler(this.tbxApellido_TextChanged);
            // 
            // tbxNombreS
            // 
            this.tbxNombreS.Location = new System.Drawing.Point(424, 95);
            this.tbxNombreS.Name = "tbxNombreS";
            this.tbxNombreS.Size = new System.Drawing.Size(138, 20);
            this.tbxNombreS.TabIndex = 79;
            this.tbxNombreS.TextChanged += new System.EventHandler(this.tbxNombreS_TextChanged);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(153, 95);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(149, 20);
            this.tbxNombre.TabIndex = 78;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Apellido(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Segundo Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(573, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 73;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(308, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 35);
            this.label15.TabIndex = 72;
            this.label15.Text = "Registro";
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.tbxMovimiento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.tbxPais);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCorreo);
            this.Controls.Add(this.tbxCelular);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.tbxNombreS);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblRegistro);
            this.Name = "RegistroCliente";
            this.Text = "Registro Cliente";
            this.Load += new System.EventHandler(this.RegistroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox tbxMovimiento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox tbxPais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCorreo;
        private System.Windows.Forms.TextBox tbxCelular;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombreS;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
    }
}