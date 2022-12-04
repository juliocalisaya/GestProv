namespace GestProv.Presentacion._01_VISTAS
{
    partial class ListadoComprasVista
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
            this.label1 = new System.Windows.Forms.Label();
            this.editarCompraBTN = new System.Windows.Forms.Button();
            this.eliminarCompraBTN = new System.Windows.Forms.Button();
            this.agregarCompraBTN = new System.Windows.Forms.Button();
            this.comprasList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRealEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comprasList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(405, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPRAS";
            // 
            // editarCompraBTN
            // 
            this.editarCompraBTN.BackColor = System.Drawing.Color.Chocolate;
            this.editarCompraBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarCompraBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.editarCompraBTN.Location = new System.Drawing.Point(848, 577);
            this.editarCompraBTN.Margin = new System.Windows.Forms.Padding(4);
            this.editarCompraBTN.Name = "editarCompraBTN";
            this.editarCompraBTN.Size = new System.Drawing.Size(163, 68);
            this.editarCompraBTN.TabIndex = 9;
            this.editarCompraBTN.Text = "Editar Compra";
            this.editarCompraBTN.UseVisualStyleBackColor = false;
            this.editarCompraBTN.Click += new System.EventHandler(this.editarCompraBTN_Click);
            // 
            // eliminarCompraBTN
            // 
            this.eliminarCompraBTN.BackColor = System.Drawing.Color.Firebrick;
            this.eliminarCompraBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarCompraBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.eliminarCompraBTN.Location = new System.Drawing.Point(443, 577);
            this.eliminarCompraBTN.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarCompraBTN.Name = "eliminarCompraBTN";
            this.eliminarCompraBTN.Size = new System.Drawing.Size(163, 68);
            this.eliminarCompraBTN.TabIndex = 8;
            this.eliminarCompraBTN.Text = "Eliminar Compra";
            this.eliminarCompraBTN.UseVisualStyleBackColor = false;
            this.eliminarCompraBTN.Click += new System.EventHandler(this.eliminarCompraBTN_Click);
            // 
            // agregarCompraBTN
            // 
            this.agregarCompraBTN.BackColor = System.Drawing.Color.ForestGreen;
            this.agregarCompraBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarCompraBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.agregarCompraBTN.Location = new System.Drawing.Point(39, 577);
            this.agregarCompraBTN.Margin = new System.Windows.Forms.Padding(4);
            this.agregarCompraBTN.Name = "agregarCompraBTN";
            this.agregarCompraBTN.Size = new System.Drawing.Size(155, 68);
            this.agregarCompraBTN.TabIndex = 7;
            this.agregarCompraBTN.Text = "Nueva Compra";
            this.agregarCompraBTN.UseVisualStyleBackColor = false;
            this.agregarCompraBTN.Click += new System.EventHandler(this.agregarCompraBTN_Click);
            // 
            // comprasList
            // 
            this.comprasList.AllowUserToAddRows = false;
            this.comprasList.AllowUserToDeleteRows = false;
            this.comprasList.AutoGenerateColumns = false;
            this.comprasList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.comprasList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comprasList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn,
            this.fechaRealEntregaDataGridViewTextBoxColumn,
            this.facturaDataGridViewTextBoxColumn});
            this.comprasList.DataSource = this.comprasBindingSource;
            this.comprasList.Location = new System.Drawing.Point(39, 81);
            this.comprasList.Margin = new System.Windows.Forms.Padding(4);
            this.comprasList.Name = "comprasList";
            this.comprasList.ReadOnly = true;
            this.comprasList.RowHeadersVisible = false;
            this.comprasList.RowHeadersWidth = 51;
            this.comprasList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comprasList.Size = new System.Drawing.Size(972, 446);
            this.comprasList.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.proveedorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCompraDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEstimadaEntregaDataGridViewTextBoxColumn
            // 
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaEstimadaEntrega";
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.HeaderText = "FechaEstimadaEntrega";
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.Name = "fechaEstimadaEntregaDataGridViewTextBoxColumn";
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRealEntregaDataGridViewTextBoxColumn
            // 
            this.fechaRealEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaRealEntrega";
            this.fechaRealEntregaDataGridViewTextBoxColumn.HeaderText = "FechaRealEntrega";
            this.fechaRealEntregaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaRealEntregaDataGridViewTextBoxColumn.Name = "fechaRealEntregaDataGridViewTextBoxColumn";
            this.fechaRealEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturaDataGridViewTextBoxColumn
            // 
            this.facturaDataGridViewTextBoxColumn.DataPropertyName = "Factura";
            this.facturaDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.facturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facturaDataGridViewTextBoxColumn.Name = "facturaDataGridViewTextBoxColumn";
            this.facturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataSource = typeof(GestProv.Dominio._01_ENTIDADES.Compra);
            // 
            // ListadoComprasVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 673);
            this.Controls.Add(this.editarCompraBTN);
            this.Controls.Add(this.eliminarCompraBTN);
            this.Controls.Add(this.agregarCompraBTN);
            this.Controls.Add(this.comprasList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1042, 673);
            this.Name = "ListadoComprasVista";
            this.Text = "ListadoComprasVista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.comprasList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editarCompraBTN;
        private System.Windows.Forms.Button eliminarCompraBTN;
        private System.Windows.Forms.Button agregarCompraBTN;
        private System.Windows.Forms.DataGridView comprasList;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEstimadaEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRealEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaDataGridViewTextBoxColumn;
    }
}