namespace Examen_Tercer_Parcial
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.gbxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.gbxDatosBancarios = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxOperacion = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxFN = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.tbxSaldo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbnOtro = new System.Windows.Forms.RadioButton();
            this.rbnConsulta = new System.Windows.Forms.RadioButton();
            this.rbnRetiro = new System.Windows.Forms.RadioButton();
            this.rbnDeposito = new System.Windows.Forms.RadioButton();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbxDatosPersonales.SuspendLayout();
            this.gbxDatosBancarios.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.gbxOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosPersonales
            // 
            this.gbxDatosPersonales.Controls.Add(this.tbxDireccion);
            this.gbxDatosPersonales.Controls.Add(this.tbxFN);
            this.gbxDatosPersonales.Controls.Add(this.tbxApellido);
            this.gbxDatosPersonales.Controls.Add(this.tbxNombre);
            this.gbxDatosPersonales.Controls.Add(this.label2);
            this.gbxDatosPersonales.Controls.Add(this.gbxSexo);
            this.gbxDatosPersonales.Controls.Add(this.lblFN);
            this.gbxDatosPersonales.Controls.Add(this.lblApellido);
            this.gbxDatosPersonales.Controls.Add(this.lblNombre);
            this.gbxDatosPersonales.Enabled = false;
            this.gbxDatosPersonales.Location = new System.Drawing.Point(25, 27);
            this.gbxDatosPersonales.Name = "gbxDatosPersonales";
            this.gbxDatosPersonales.Size = new System.Drawing.Size(606, 191);
            this.gbxDatosPersonales.TabIndex = 0;
            this.gbxDatosPersonales.TabStop = false;
            this.gbxDatosPersonales.Text = "Datos Personales";
            this.gbxDatosPersonales.Enter += new System.EventHandler(this.gbxDatosPersonales_Enter);
            // 
            // gbxDatosBancarios
            // 
            this.gbxDatosBancarios.Controls.Add(this.dateTimePicker1);
            this.gbxDatosBancarios.Controls.Add(this.tbxSaldo);
            this.gbxDatosBancarios.Controls.Add(this.tbxCantidad);
            this.gbxDatosBancarios.Controls.Add(this.gbxOperacion);
            this.gbxDatosBancarios.Controls.Add(this.label3);
            this.gbxDatosBancarios.Controls.Add(this.lblSaldo);
            this.gbxDatosBancarios.Controls.Add(this.lblCantidad);
            this.gbxDatosBancarios.Controls.Add(this.btnLimpiar);
            this.gbxDatosBancarios.Controls.Add(this.btnEjecutar);
            this.gbxDatosBancarios.Enabled = false;
            this.gbxDatosBancarios.Location = new System.Drawing.Point(25, 238);
            this.gbxDatosBancarios.Name = "gbxDatosBancarios";
            this.gbxDatosBancarios.Size = new System.Drawing.Size(592, 191);
            this.gbxDatosBancarios.TabIndex = 1;
            this.gbxDatosBancarios.TabStop = false;
            this.gbxDatosBancarios.Text = "Datos Bancarios";
            this.gbxDatosBancarios.Enter += new System.EventHandler(this.gbxDatosBancarios_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(663, 84);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(427, 37);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(108, 32);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(427, 85);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 32);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(14, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(14, 76);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(114, 13);
            this.lblFN.TabIndex = 2;
            this.lblFN.Text = "Fecha de Nacimiento: ";
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbnOtro);
            this.gbxSexo.Controls.Add(this.rbtMasculino);
            this.gbxSexo.Controls.Add(this.rbtFemenino);
            this.gbxSexo.Controls.Add(this.label1);
            this.gbxSexo.Location = new System.Drawing.Point(17, 108);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(357, 77);
            this.gbxSexo.TabIndex = 3;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Nacimiento: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dirección: ";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(31, 37);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad: ";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(31, 65);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(40, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de ejecución: ";
            // 
            // gbxOperacion
            // 
            this.gbxOperacion.Controls.Add(this.rbnConsulta);
            this.gbxOperacion.Controls.Add(this.label5);
            this.gbxOperacion.Controls.Add(this.rbnRetiro);
            this.gbxOperacion.Controls.Add(this.rbnDeposito);
            this.gbxOperacion.Location = new System.Drawing.Point(34, 125);
            this.gbxOperacion.Name = "gbxOperacion";
            this.gbxOperacion.Size = new System.Drawing.Size(357, 60);
            this.gbxOperacion.TabIndex = 4;
            this.gbxOperacion.TabStop = false;
            this.gbxOperacion.Text = "Operación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fecha de Nacimiento: ";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(67, 19);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(186, 20);
            this.tbxNombre.TabIndex = 5;
            this.tbxNombre.TextChanged += new System.EventHandler(this.tbxNombre_TextChanged);
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(66, 46);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(186, 20);
            this.tbxApellido.TabIndex = 6;
            this.tbxApellido.TextChanged += new System.EventHandler(this.tbxApellido_TextChanged);
            // 
            // tbxFN
            // 
            this.tbxFN.Location = new System.Drawing.Point(127, 73);
            this.tbxFN.Name = "tbxFN";
            this.tbxFN.Size = new System.Drawing.Size(186, 20);
            this.tbxFN.TabIndex = 7;
            this.tbxFN.TextChanged += new System.EventHandler(this.tbxFN_TextChanged);
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(407, 15);
            this.tbxDireccion.Multiline = true;
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(186, 163);
            this.tbxDireccion.TabIndex = 6;
            this.tbxDireccion.TextChanged += new System.EventHandler(this.tbxDireccion_TextChanged);
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(91, 34);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(186, 20);
            this.tbxCantidad.TabIndex = 6;
            this.tbxCantidad.TextChanged += new System.EventHandler(this.tbxCantidad_TextChanged);
            // 
            // tbxSaldo
            // 
            this.tbxSaldo.Location = new System.Drawing.Point(75, 62);
            this.tbxSaldo.Name = "tbxSaldo";
            this.tbxSaldo.ReadOnly = true;
            this.tbxSaldo.Size = new System.Drawing.Size(186, 20);
            this.tbxSaldo.TabIndex = 8;
            this.tbxSaldo.TextChanged += new System.EventHandler(this.tbxSaldo_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(17, 33);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 4;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            this.rbtFemenino.CheckedChanged += new System.EventHandler(this.rbtFemenino_CheckedChanged);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(125, 33);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 5;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.rbtMasculino_CheckedChanged);
            // 
            // rbnOtro
            // 
            this.rbnOtro.AutoSize = true;
            this.rbnOtro.Location = new System.Drawing.Point(238, 33);
            this.rbnOtro.Name = "rbnOtro";
            this.rbnOtro.Size = new System.Drawing.Size(45, 17);
            this.rbnOtro.TabIndex = 6;
            this.rbnOtro.TabStop = true;
            this.rbnOtro.Text = "Otro";
            this.rbnOtro.UseVisualStyleBackColor = true;
            this.rbnOtro.CheckedChanged += new System.EventHandler(this.rbnOtro_CheckedChanged);
            // 
            // rbnConsulta
            // 
            this.rbnConsulta.AutoSize = true;
            this.rbnConsulta.Location = new System.Drawing.Point(258, 26);
            this.rbnConsulta.Name = "rbnConsulta";
            this.rbnConsulta.Size = new System.Drawing.Size(66, 17);
            this.rbnConsulta.TabIndex = 9;
            this.rbnConsulta.TabStop = true;
            this.rbnConsulta.Text = "Consulta";
            this.rbnConsulta.UseVisualStyleBackColor = true;
            this.rbnConsulta.CheckedChanged += new System.EventHandler(this.rbnConsulta_CheckedChanged);
            // 
            // rbnRetiro
            // 
            this.rbnRetiro.AutoSize = true;
            this.rbnRetiro.Location = new System.Drawing.Point(145, 26);
            this.rbnRetiro.Name = "rbnRetiro";
            this.rbnRetiro.Size = new System.Drawing.Size(53, 17);
            this.rbnRetiro.TabIndex = 8;
            this.rbnRetiro.TabStop = true;
            this.rbnRetiro.Text = "Retiro";
            this.rbnRetiro.UseVisualStyleBackColor = true;
            this.rbnRetiro.CheckedChanged += new System.EventHandler(this.rbnRetiro_CheckedChanged);
            // 
            // rbnDeposito
            // 
            this.rbnDeposito.AutoSize = true;
            this.rbnDeposito.Location = new System.Drawing.Point(37, 26);
            this.rbnDeposito.Name = "rbnDeposito";
            this.rbnDeposito.Size = new System.Drawing.Size(67, 17);
            this.rbnDeposito.TabIndex = 7;
            this.rbnDeposito.TabStop = true;
            this.rbnDeposito.Text = "Deposito";
            this.rbnDeposito.UseVisualStyleBackColor = true;
            this.rbnDeposito.CheckedChanged += new System.EventHandler(this.rbnDeposito_CheckedChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(663, 32);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(108, 32);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxDatosBancarios);
            this.Controls.Add(this.gbxDatosPersonales);
            this.Name = "Form1";
            this.Text = "Servicios Financieros SA de CV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxDatosPersonales.ResumeLayout(false);
            this.gbxDatosPersonales.PerformLayout();
            this.gbxDatosBancarios.ResumeLayout(false);
            this.gbxDatosBancarios.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxOperacion.ResumeLayout(false);
            this.gbxOperacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox gbxDatosPersonales;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxFN;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbnOtro;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbxDatosBancarios;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbxSaldo;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.GroupBox gbxOperacion;
        private System.Windows.Forms.RadioButton rbnConsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbnRetiro;
        private System.Windows.Forms.RadioButton rbnDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
    }
}

