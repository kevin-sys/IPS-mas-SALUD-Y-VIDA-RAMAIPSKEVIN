namespace IPSGUI
{
    partial class FrmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevaLiquidaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaLiquidaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLiquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeLiquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicarseConElDesarroladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactaAlDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaLiquidaciónToolStripMenuItem,
            this.gestiónDeLiquidacionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevaLiquidaciónToolStripMenuItem
            // 
            this.nuevaLiquidaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaLiquidaciónToolStripMenuItem1,
            this.consultarLiquidacionesToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.nuevaLiquidaciónToolStripMenuItem.Name = "nuevaLiquidaciónToolStripMenuItem";
            this.nuevaLiquidaciónToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.nuevaLiquidaciónToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaLiquidaciónToolStripMenuItem1
            // 
            this.nuevaLiquidaciónToolStripMenuItem1.Name = "nuevaLiquidaciónToolStripMenuItem1";
            this.nuevaLiquidaciónToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.nuevaLiquidaciónToolStripMenuItem1.Text = "Nueva liquidación";
            this.nuevaLiquidaciónToolStripMenuItem1.Click += new System.EventHandler(this.nuevaLiquidaciónToolStripMenuItem1_Click);
            // 
            // consultarLiquidacionesToolStripMenuItem
            // 
            this.consultarLiquidacionesToolStripMenuItem.Name = "consultarLiquidacionesToolStripMenuItem";
            this.consultarLiquidacionesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.consultarLiquidacionesToolStripMenuItem.Text = "Consultar liquidaciones";
            this.consultarLiquidacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarLiquidacionesToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // gestiónDeLiquidacionesToolStripMenuItem
            // 
            this.gestiónDeLiquidacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.gestiónDeLiquidacionesToolStripMenuItem.Name = "gestiónDeLiquidacionesToolStripMenuItem";
            this.gestiónDeLiquidacionesToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.gestiónDeLiquidacionesToolStripMenuItem.Text = "Gestión de liquidaciones";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comunicarseConElDesarroladorToolStripMenuItem,
            this.contactaAlDesarrolladorToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ";
            // 
            // comunicarseConElDesarroladorToolStripMenuItem
            // 
            this.comunicarseConElDesarroladorToolStripMenuItem.Name = "comunicarseConElDesarroladorToolStripMenuItem";
            this.comunicarseConElDesarroladorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.comunicarseConElDesarroladorToolStripMenuItem.Text = "Información del software";
            this.comunicarseConElDesarroladorToolStripMenuItem.Click += new System.EventHandler(this.comunicarseConElDesarroladorToolStripMenuItem_Click);
            // 
            // contactaAlDesarrolladorToolStripMenuItem
            // 
            this.contactaAlDesarrolladorToolStripMenuItem.Name = "contactaAlDesarrolladorToolStripMenuItem";
            this.contactaAlDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.contactaAlDesarrolladorToolStripMenuItem.Text = "Contacta al desarrollador";
            this.contactaAlDesarrolladorToolStripMenuItem.Click += new System.EventHandler(this.contactaAlDesarrolladorToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem1
            // 
            this.salirDelSistemaToolStripMenuItem1.Name = "salirDelSistemaToolStripMenuItem1";
            this.salirDelSistemaToolStripMenuItem1.Size = new System.Drawing.Size(103, 20);
            this.salirDelSistemaToolStripMenuItem1.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem1.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 620);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevaLiquidaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaLiquidaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarLiquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeLiquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunicarseConElDesarroladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contactaAlDesarrolladorToolStripMenuItem;
    }
}