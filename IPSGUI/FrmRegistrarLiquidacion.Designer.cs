namespace IPSGUI
{
    partial class FrmLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLiquidacion));
            this.TxtNumeroLiquidacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoAfiliacion = new System.Windows.Forms.ComboBox();
            this.DtpFechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSalarioDevengado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValorHospitalizacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.PictureBox();
            this.BtnEditar = new System.Windows.Forms.PictureBox();
            this.BtnBuscar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNumeroLiquidacion
            // 
            this.TxtNumeroLiquidacion.Location = new System.Drawing.Point(215, 92);
            this.TxtNumeroLiquidacion.Name = "TxtNumeroLiquidacion";
            this.TxtNumeroLiquidacion.Size = new System.Drawing.Size(138, 20);
            this.TxtNumeroLiquidacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número Liquidación";
            // 
            // CmbTipoAfiliacion
            // 
            this.CmbTipoAfiliacion.FormattingEnabled = true;
            this.CmbTipoAfiliacion.Items.AddRange(new object[] {
            "Contributivo",
            "Subsidiado"});
            this.CmbTipoAfiliacion.Location = new System.Drawing.Point(215, 209);
            this.CmbTipoAfiliacion.Name = "CmbTipoAfiliacion";
            this.CmbTipoAfiliacion.Size = new System.Drawing.Size(138, 21);
            this.CmbTipoAfiliacion.TabIndex = 3;
            // 
            // DtpFechaLiquidacion
            // 
            this.DtpFechaLiquidacion.Location = new System.Drawing.Point(215, 128);
            this.DtpFechaLiquidacion.Name = "DtpFechaLiquidacion";
            this.DtpFechaLiquidacion.Size = new System.Drawing.Size(209, 20);
            this.DtpFechaLiquidacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salario devengado";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Location = new System.Drawing.Point(215, 170);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(138, 20);
            this.TxtIdentificacion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo de afiliación";
            // 
            // TxtSalarioDevengado
            // 
            this.TxtSalarioDevengado.Location = new System.Drawing.Point(215, 249);
            this.TxtSalarioDevengado.Name = "TxtSalarioDevengado";
            this.TxtSalarioDevengado.Size = new System.Drawing.Size(138, 20);
            this.TxtSalarioDevengado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Idetificación Paciente";
            // 
            // TxtValorHospitalizacion
            // 
            this.TxtValorHospitalizacion.Location = new System.Drawing.Point(215, 288);
            this.TxtValorHospitalizacion.Name = "TxtValorHospitalizacion";
            this.TxtValorHospitalizacion.Size = new System.Drawing.Size(138, 20);
            this.TxtValorHospitalizacion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha Liquidación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor Servicio Hospitalización";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::IPSGUI.Properties.Resources.negocio;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(359, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(28, 23);
            this.panel5.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::IPSGUI.Properties.Resources.moneda1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(359, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 23);
            this.panel4.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::IPSGUI.Properties.Resources.huella_dactilar;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(359, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 23);
            this.panel3.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::IPSGUI.Properties.Resources.calendario;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(396, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 19);
            this.panel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IPSGUI.Properties.Resources.firmar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(359, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 23);
            this.panel1.TabIndex = 17;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.BtnGuardar.BackgroundImage = global::IPSGUI.Properties.Resources.salvar;
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.Location = new System.Drawing.Point(91, 347);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnGuardar.Size = new System.Drawing.Size(46, 43);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Registrar liquidación";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(376, 347);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(46, 43);
            this.BtnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.TabStop = false;
            this.BtnEliminar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(186, 347);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(46, 43);
            this.BtnEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEditar.TabIndex = 24;
            this.BtnEditar.TabStop = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(281, 347);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(46, 43);
            this.BtnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnBuscar.TabIndex = 25;
            this.BtnBuscar.TabStop = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Guardar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(182, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Editar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(372, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Eliminar";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Buscar
            // 
            this.Buscar.AutoSize = true;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(279, 393);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(46, 13);
            this.Buscar.TabIndex = 29;
            this.Buscar.Text = "Buscar";
            // 
            // FrmLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 444);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtValorHospitalizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSalarioDevengado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.DtpFechaLiquidacion);
            this.Controls.Add(this.CmbTipoAfiliacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNumeroLiquidacion);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liquidación";
            this.Load += new System.EventHandler(this.FrmLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtNumeroLiquidacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTipoAfiliacion;
        private System.Windows.Forms.DateTimePicker DtpFechaLiquidacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSalarioDevengado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtValorHospitalizacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox BtnEliminar;
        private System.Windows.Forms.PictureBox BtnEditar;
        private System.Windows.Forms.PictureBox BtnBuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Buscar;
    }
}

