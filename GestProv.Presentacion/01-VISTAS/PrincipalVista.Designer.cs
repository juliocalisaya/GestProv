namespace GestProv.Presentacion
{
    partial class PrincipalVista
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeTecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTécnicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeComprasToolStripMenuItem,
            this.ordenesDeServicioToolStripMenuItem,
            this.gestionDeProveedoresToolStripMenuItem,
            this.gestionDeTecnicosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónDeComprasToolStripMenuItem
            // 
            this.gestiónDeComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeComprasToolStripMenuItem});
            this.gestiónDeComprasToolStripMenuItem.Name = "gestiónDeComprasToolStripMenuItem";
            this.gestiónDeComprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.gestiónDeComprasToolStripMenuItem.Text = "Compras";
            // 
            // listadoDeComprasToolStripMenuItem
            // 
            this.listadoDeComprasToolStripMenuItem.Name = "listadoDeComprasToolStripMenuItem";
            this.listadoDeComprasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listadoDeComprasToolStripMenuItem.Text = "Listado de Compras";
            this.listadoDeComprasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeComprasToolStripMenuItem_Click);
            // 
            // ordenesDeServicioToolStripMenuItem
            // 
            this.ordenesDeServicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeOSToolStripMenuItem});
            this.ordenesDeServicioToolStripMenuItem.Name = "ordenesDeServicioToolStripMenuItem";
            this.ordenesDeServicioToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.ordenesDeServicioToolStripMenuItem.Text = "Ordenes de Servicio";
            // 
            // listadoDeOSToolStripMenuItem
            // 
            this.listadoDeOSToolStripMenuItem.Name = "listadoDeOSToolStripMenuItem";
            this.listadoDeOSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listadoDeOSToolStripMenuItem.Text = "Listado de O.S.";
            this.listadoDeOSToolStripMenuItem.Click += new System.EventHandler(this.listadoDeOSToolStripMenuItem_Click);
            // 
            // gestionDeProveedoresToolStripMenuItem
            // 
            this.gestionDeProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeProveedoresToolStripMenuItem});
            this.gestionDeProveedoresToolStripMenuItem.Name = "gestionDeProveedoresToolStripMenuItem";
            this.gestionDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.gestionDeProveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // listadoDeProveedoresToolStripMenuItem
            // 
            this.listadoDeProveedoresToolStripMenuItem.Name = "listadoDeProveedoresToolStripMenuItem";
            this.listadoDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.listadoDeProveedoresToolStripMenuItem.Text = "Listado de Proveedores";
            this.listadoDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProveedoresToolStripMenuItem_Click);
            // 
            // gestionDeTecnicosToolStripMenuItem
            // 
            this.gestionDeTecnicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeTécnicosToolStripMenuItem1});
            this.gestionDeTecnicosToolStripMenuItem.Name = "gestionDeTecnicosToolStripMenuItem";
            this.gestionDeTecnicosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.gestionDeTecnicosToolStripMenuItem.Text = "Técnicos";
            // 
            // listadoDeTécnicosToolStripMenuItem1
            // 
            this.listadoDeTécnicosToolStripMenuItem1.Name = "listadoDeTécnicosToolStripMenuItem1";
            this.listadoDeTécnicosToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.listadoDeTécnicosToolStripMenuItem1.Text = "Listado de Técnicos";
            this.listadoDeTécnicosToolStripMenuItem1.Click += new System.EventHandler(this.listadoDeTécnicosToolStripMenuItem1_Click);
            // 
            // PrincipalVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalVista";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeTecnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTécnicosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeOSToolStripMenuItem;
    }
}

