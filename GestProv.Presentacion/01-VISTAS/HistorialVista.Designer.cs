
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProveedoresList = new System.Windows.Forms.DataGridView();
            this.nombreyApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.verFacturaBTN = new System.Windows.Forms.Button();
            this.titulos = new System.Windows.Forms.Label();
            this.historialList = new System.Windows.Forms.DataGridView();
            this.SucId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialList)).BeginInit();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 586F));
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProveedoresList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProveedoresList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedoresList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreyApellidoDataGridViewTextBoxColumn});
            this.ProveedoresList.DataSource = this.proveedorBindingSource;
            this.ProveedoresList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProveedoresList.Location = new System.Drawing.Point(11, 69);
            this.ProveedoresList.Margin = new System.Windows.Forms.Padding(11, 2, 3, 2);
            this.ProveedoresList.MultiSelect = false;
            this.ProveedoresList.Name = "ProveedoresList";
            this.ProveedoresList.ReadOnly = true;
            this.ProveedoresList.RowHeadersVisible = false;
            this.ProveedoresList.RowHeadersWidth = 51;
            this.ProveedoresList.RowTemplate.Height = 24;
            this.ProveedoresList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProveedoresList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProveedoresList.Size = new System.Drawing.Size(206, 582);
            this.ProveedoresList.TabIndex = 1;
            // 
            // nombreyApellidoDataGridViewTextBoxColumn
            // 
            this.nombreyApellidoDataGridViewTextBoxColumn.DataPropertyName = "NombreyApellido";
            this.nombreyApellidoDataGridViewTextBoxColumn.HeaderText = "NombreyApellido";
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
            this.panel1.Size = new System.Drawing.Size(813, 55);
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
            this.verFacturaBTN.Size = new System.Drawing.Size(191, 46);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historialList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.historialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SucId,
            this.Sucursal,
            this.FechaCompra,
            this.Monto,
            this.Entrega});
            this.historialList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historialList.Location = new System.Drawing.Point(223, 69);
            this.historialList.Margin = new System.Windows.Forms.Padding(3, 2, 11, 2);
            this.historialList.Name = "historialList";
            this.historialList.ReadOnly = true;
            this.historialList.RowHeadersVisible = false;
            this.historialList.RowHeadersWidth = 51;
            this.historialList.RowTemplate.Height = 24;
            this.historialList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.historialList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historialList.Size = new System.Drawing.Size(809, 582);
            this.historialList.TabIndex = 3;
            // 
            // SucId
            // 
            this.SucId.HeaderText = "id";
            this.SucId.MinimumWidth = 6;
            this.SucId.Name = "SucId";
            this.SucId.ReadOnly = true;
            this.SucId.Visible = false;
            this.SucId.Width = 125;
            // 
            // Sucursal
            // 
            this.Sucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.MinimumWidth = 6;
            this.Sucursal.Name = "Sucursal";
            this.Sucursal.ReadOnly = true;
            // 
            // FechaCompra
            // 
            this.FechaCompra.HeaderText = "Fecha Compra";
            this.FechaCompra.MinimumWidth = 6;
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.ReadOnly = true;
            this.FechaCompra.Width = 180;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 180;
            // 
            // Entrega
            // 
            this.Entrega.HeaderText = "Entrega";
            this.Entrega.MinimumWidth = 6;
            this.Entrega.Name = "Entrega";
            this.Entrega.ReadOnly = true;
            this.Entrega.Width = 180;
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
            this.Load += new System.EventHandler(this.HistorialVista_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ProveedoresList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titulos;
        private System.Windows.Forms.Button verFacturaBTN;
        private System.Windows.Forms.DataGridView historialList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreyApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
    }
}