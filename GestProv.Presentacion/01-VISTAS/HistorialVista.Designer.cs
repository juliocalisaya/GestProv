
namespace GestProv.Presentacion._01_VISTAS
{
    partial class HistorialVista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProveedoresList = new System.Windows.Forms.DataGridView();
            this.nombreyApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.verFacturaBTN = new System.Windows.Forms.Button();
            this.titulos = new System.Windows.Forms.Label();
            this.historialList = new System.Windows.Forms.DataGridView();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRealEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ProveedoresList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.historialList, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1043, 673);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ProveedoresList
            // 
            this.ProveedoresList.AllowUserToAddRows = false;
            this.ProveedoresList.AllowUserToDeleteRows = false;
            this.ProveedoresList.AutoGenerateColumns = false;
            this.ProveedoresList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProveedoresList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProveedoresList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ProveedoresList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedoresList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreyApellidoDataGridViewTextBoxColumn});
            this.ProveedoresList.DataSource = this.proveedorBindingSource;
            this.ProveedoresList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProveedoresList.Location = new System.Drawing.Point(11, 82);
            this.ProveedoresList.Margin = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.ProveedoresList.MultiSelect = false;
            this.ProveedoresList.Name = "ProveedoresList";
            this.ProveedoresList.ReadOnly = true;
            this.ProveedoresList.RowHeadersVisible = false;
            this.ProveedoresList.RowHeadersWidth = 51;
            this.ProveedoresList.RowTemplate.Height = 24;
            this.ProveedoresList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProveedoresList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProveedoresList.Size = new System.Drawing.Size(206, 569);
            this.ProveedoresList.TabIndex = 1;
            this.ProveedoresList.SelectionChanged += new System.EventHandler(this.ProveedoresList_SelectionChanged);
            // 
            // nombreyApellidoDataGridViewTextBoxColumn
            // 
            this.nombreyApellidoDataGridViewTextBoxColumn.DataPropertyName = "NombreyApellido";
            this.nombreyApellidoDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nombreyApellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreyApellidoDataGridViewTextBoxColumn.Name = "nombreyApellidoDataGridViewTextBoxColumn";
            this.nombreyApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(GestProv.Dominio._01_ENTIDADES.Proveedor);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.verFacturaBTN);
            this.panel1.Controls.Add(this.titulos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(225, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 68);
            this.panel1.TabIndex = 2;
            // 
            // verFacturaBTN
            // 
            this.verFacturaBTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verFacturaBTN.BackColor = System.Drawing.Color.DarkGreen;
            this.verFacturaBTN.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.verFacturaBTN.FlatAppearance.BorderSize = 4;
            this.verFacturaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verFacturaBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verFacturaBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.verFacturaBTN.Location = new System.Drawing.Point(616, 7);
            this.verFacturaBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verFacturaBTN.Name = "verFacturaBTN";
            this.verFacturaBTN.Size = new System.Drawing.Size(191, 59);
            this.verFacturaBTN.TabIndex = 7;
            this.verFacturaBTN.Text = "Ver Factura";
            this.verFacturaBTN.UseVisualStyleBackColor = false;
            this.verFacturaBTN.Click += new System.EventHandler(this.verFacturaBTN_Click);
            // 
            // titulos
            // 
            this.titulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulos.AutoSize = true;
            this.titulos.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulos.Location = new System.Drawing.Point(3, 14);
            this.titulos.Name = "titulos";
            this.titulos.Size = new System.Drawing.Size(312, 42);
            this.titulos.TabIndex = 0;
            this.titulos.Text = "Historial Compras";
            // 
            // historialList
            // 
            this.historialList.AllowUserToAddRows = false;
            this.historialList.AllowUserToDeleteRows = false;
            this.historialList.AutoGenerateColumns = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historialList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.historialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn,
            this.fechaRealEntregaDataGridViewTextBoxColumn,
            this.facturaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn});
            this.historialList.DataSource = this.compraBindingSource;
            this.historialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historialList.Location = new System.Drawing.Point(223, 82);
            this.historialList.Margin = new System.Windows.Forms.Padding(3, 2, 11, 2);
            this.historialList.MultiSelect = false;
            this.historialList.Name = "historialList";
            this.historialList.ReadOnly = true;
            this.historialList.RowHeadersVisible = false;
            this.historialList.RowHeadersWidth = 51;
            this.historialList.RowTemplate.Height = 24;
            this.historialList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historialList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historialList.Size = new System.Drawing.Size(809, 569);
            this.historialList.TabIndex = 3;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataSource = typeof(GestProv.Dominio._01_ENTIDADES.Compra);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "FechaCompra";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaCompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "FechaCompra";
            this.fechaCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCompraDataGridViewTextBoxColumn.Width = 180;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            this.montoDataGridViewTextBoxColumn.Width = 220;
            // 
            // fechaEstimadaEntregaDataGridViewTextBoxColumn
            // 
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaEstimadaEntrega";
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.HeaderText = "FechaEstimadaEntrega";
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.Name = "fechaEstimadaEntregaDataGridViewTextBoxColumn";
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.Visible = false;
            this.fechaEstimadaEntregaDataGridViewTextBoxColumn.Width = 180;
            // 
            // fechaRealEntregaDataGridViewTextBoxColumn
            // 
            this.fechaRealEntregaDataGridViewTextBoxColumn.DataPropertyName = "FechaRealEntrega";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaRealEntregaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.fechaRealEntregaDataGridViewTextBoxColumn.HeaderText = "Entrega";
            this.fechaRealEntregaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaRealEntregaDataGridViewTextBoxColumn.Name = "fechaRealEntregaDataGridViewTextBoxColumn";
            this.fechaRealEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaRealEntregaDataGridViewTextBoxColumn.Width = 180;
            // 
            // facturaDataGridViewTextBoxColumn
            // 
            this.facturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.facturaDataGridViewTextBoxColumn.DataPropertyName = "Factura";
            this.facturaDataGridViewTextBoxColumn.HeaderText = "Factura";
            this.facturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facturaDataGridViewTextBoxColumn.Name = "facturaDataGridViewTextBoxColumn";
            this.facturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.proveedorDataGridViewTextBoxColumn.Visible = false;
            this.proveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // HistorialVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1043, 673);
            this.Name = "HistorialVista";
            this.Text = "HistorialVista";
            this.VisibleChanged += new System.EventHandler(this.HistorialVista_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ProveedoresList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titulos;
        private System.Windows.Forms.Button verFacturaBTN;
        private System.Windows.Forms.DataGridView historialList;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreyApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEstimadaEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRealEntregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
    }
}