namespace IPSGUI
{
    partial class FrmConsultarLiquidacion
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
            this.DgvLiquidacion = new System.Windows.Forms.DataGridView();
            this.CmbTipoAfiliacion = new System.Windows.Forms.ComboBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSubsidiado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtContributivo = new System.Windows.Forms.TextBox();
            this.TxtValorTotalLiquidacion = new System.Windows.Forms.TextBox();
            this.TxtValorTotalSubsidiado = new System.Windows.Forms.TextBox();
            this.TxtValorTotalContributivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLiquidacion
            // 
            this.DgvLiquidacion.BackgroundColor = System.Drawing.Color.White;
            this.DgvLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLiquidacion.Location = new System.Drawing.Point(44, 75);
            this.DgvLiquidacion.Name = "DgvLiquidacion";
            this.DgvLiquidacion.Size = new System.Drawing.Size(686, 175);
            this.DgvLiquidacion.TabIndex = 0;
            // 
            // CmbTipoAfiliacion
            // 
            this.CmbTipoAfiliacion.FormattingEnabled = true;
            this.CmbTipoAfiliacion.Items.AddRange(new object[] {
            "Todos",
            "Contributivo",
            "Subsidiado"});
            this.CmbTipoAfiliacion.Location = new System.Drawing.Point(44, 267);
            this.CmbTipoAfiliacion.Name = "CmbTipoAfiliacion";
            this.CmbTipoAfiliacion.Size = new System.Drawing.Size(143, 21);
            this.CmbTipoAfiliacion.TabIndex = 2;
            this.CmbTipoAfiliacion.SelectedIndexChanged += new System.EventHandler(this.CmbTipoAfiliacion_SelectedIndexChanged);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(44, 319);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(49, 20);
            this.TxtTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número total de liquidaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "L. Subsidiado";
            // 
            // TxtSubsidiado
            // 
            this.TxtSubsidiado.Location = new System.Drawing.Point(534, 319);
            this.TxtSubsidiado.Name = "TxtSubsidiado";
            this.TxtSubsidiado.ReadOnly = true;
            this.TxtSubsidiado.Size = new System.Drawing.Size(49, 20);
            this.TxtSubsidiado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "L.Contributivo";
            // 
            // TxtContributivo
            // 
            this.TxtContributivo.Location = new System.Drawing.Point(288, 319);
            this.TxtContributivo.Name = "TxtContributivo";
            this.TxtContributivo.ReadOnly = true;
            this.TxtContributivo.Size = new System.Drawing.Size(49, 20);
            this.TxtContributivo.TabIndex = 7;
            // 
            // TxtValorTotalLiquidacion
            // 
            this.TxtValorTotalLiquidacion.Location = new System.Drawing.Point(44, 385);
            this.TxtValorTotalLiquidacion.Name = "TxtValorTotalLiquidacion";
            this.TxtValorTotalLiquidacion.ReadOnly = true;
            this.TxtValorTotalLiquidacion.Size = new System.Drawing.Size(143, 20);
            this.TxtValorTotalLiquidacion.TabIndex = 9;
            // 
            // TxtValorTotalSubsidiado
            // 
            this.TxtValorTotalSubsidiado.Location = new System.Drawing.Point(534, 385);
            this.TxtValorTotalSubsidiado.Name = "TxtValorTotalSubsidiado";
            this.TxtValorTotalSubsidiado.ReadOnly = true;
            this.TxtValorTotalSubsidiado.Size = new System.Drawing.Size(143, 20);
            this.TxtValorTotalSubsidiado.TabIndex = 10;
            // 
            // TxtValorTotalContributivo
            // 
            this.TxtValorTotalContributivo.Location = new System.Drawing.Point(288, 385);
            this.TxtValorTotalContributivo.Name = "TxtValorTotalContributivo";
            this.TxtValorTotalContributivo.ReadOnly = true;
            this.TxtValorTotalContributivo.Size = new System.Drawing.Size(143, 20);
            this.TxtValorTotalContributivo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Valor Total Subsidiado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor total contributivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor total liquidaciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tipo de afiliación";
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::IPSGUI.Properties.Resources.negocio;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(589, 319);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(28, 23);
            this.panel6.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::IPSGUI.Properties.Resources.negocio;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(343, 319);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(28, 23);
            this.panel5.TabIndex = 20;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::IPSGUI.Properties.Resources.moneda;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(683, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 23);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::IPSGUI.Properties.Resources.moneda;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(437, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 23);
            this.panel3.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::IPSGUI.Properties.Resources.moneda;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(193, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(28, 23);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::IPSGUI.Properties.Resources.firmar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(100, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 23);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(224, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Reporte de liquidaciones";
            // 
            // FrmConsultarLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 469);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtValorTotalContributivo);
            this.Controls.Add(this.TxtValorTotalSubsidiado);
            this.Controls.Add(this.TxtValorTotalLiquidacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtContributivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSubsidiado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.CmbTipoAfiliacion);
            this.Controls.Add(this.DgvLiquidacion);
            this.Name = "FrmConsultarLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmConsultarLiquidacion";
            this.Load += new System.EventHandler(this.FrmConsultarLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLiquidacion;
        private System.Windows.Forms.ComboBox CmbTipoAfiliacion;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSubsidiado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtContributivo;
        private System.Windows.Forms.TextBox TxtValorTotalLiquidacion;
        private System.Windows.Forms.TextBox TxtValorTotalSubsidiado;
        private System.Windows.Forms.TextBox TxtValorTotalContributivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
    }
}