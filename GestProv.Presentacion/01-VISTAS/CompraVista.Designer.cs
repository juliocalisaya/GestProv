
namespace GestProv.Presentacion._01_VISTAS
{
    partial class CompraVista
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
            this.limpiarBTN = new System.Windows.Forms.Button();
            this.cancelarBTN = new System.Windows.Forms.Button();
            this.guardarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proveedorCB = new System.Windows.Forms.ComboBox();
            this.sucursalCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaRealEntregaLB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fechaCompraValueTB = new System.Windows.Forms.TextBox();
            this.montoValueTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.facturaPathTB = new System.Windows.Forms.TextBox();
            this.seleccionarFacturaBTN = new System.Windows.Forms.Button();
            this.fechaEsperadaEntregaTB = new System.Windows.Forms.TextBox();
            this.fechaRealEntregaTB = new System.Windows.Forms.TextBox();
            this.comprasList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasGarantiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comprasList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // limpiarBTN
            // 
            this.limpiarBTN.Location = new System.Drawing.Point(62, 576);
            this.limpiarBTN.Margin = new System.Windows.Forms.Padding(4);
            this.limpiarBTN.Name = "limpiarBTN";
            this.limpiarBTN.Size = new System.Drawing.Size(156, 41);
            this.limpiarBTN.TabIndex = 11;
            this.limpiarBTN.Text = "Limpiar";
            this.limpiarBTN.UseVisualStyleBackColor = true;
            this.limpiarBTN.Click += new System.EventHandler(this.limpiarBTN_Click);
            // 
            // cancelarBTN
            // 
            this.cancelarBTN.Location = new System.Drawing.Point(990, 576);
            this.cancelarBTN.Margin = new System.Windows.Forms.Padding(4);
            this.cancelarBTN.Name = "cancelarBTN";
            this.cancelarBTN.Size = new System.Drawing.Size(156, 41);
            this.cancelarBTN.TabIndex = 12;
            this.cancelarBTN.Text = "Cancelar";
            this.cancelarBTN.UseVisualStyleBackColor = true;
            this.cancelarBTN.Click += new System.EventHandler(this.cancelarBTN_Click);
            // 
            // guardarBTN
            // 
            this.guardarBTN.Location = new System.Drawing.Point(532, 576);
            this.guardarBTN.Margin = new System.Windows.Forms.Padding(4);
            this.guardarBTN.Name = "guardarBTN";
            this.guardarBTN.Size = new System.Drawing.Size(156, 41);
            this.guardarBTN.TabIndex = 10;
            this.guardarBTN.Text = "Guardar";
            this.guardarBTN.UseVisualStyleBackColor = true;
            this.guardarBTN.Click += new System.EventHandler(this.guardarBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(654, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sucursal:";
            // 
            // proveedorCB
            // 
            this.proveedorCB.DataSource = this.proveedoresBindingSource;
            this.proveedorCB.DisplayMember = "NombreyApellido";
            this.proveedorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedorCB.FormattingEnabled = true;
            this.proveedorCB.Location = new System.Drawing.Point(201, 22);
            this.proveedorCB.Name = "proveedorCB";
            this.proveedorCB.Size = new System.Drawing.Size(352, 33);
            this.proveedorCB.TabIndex = 15;
            this.proveedorCB.SelectedIndexChanged += new System.EventHandler(this.proveedorCB_SelectedIndexChanged);
            // 
            // sucursalCB
            // 
            this.sucursalCB.DataSource = this.sucursalBindingSource;
            this.sucursalCB.DisplayMember = "NombreCalle";
            this.sucursalCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucursalCB.FormattingEnabled = true;
            this.sucursalCB.Location = new System.Drawing.Point(794, 22);
            this.sucursalCB.Name = "sucursalCB";
            this.sucursalCB.Size = new System.Drawing.Size(352, 33);
            this.sucursalCB.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(57, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha de Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(57, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha Estimada de Entrega:";
            // 
            // fechaRealEntregaLB
            // 
            this.fechaRealEntregaLB.AutoSize = true;
            this.fechaRealEntregaLB.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fechaRealEntregaLB.Location = new System.Drawing.Point(622, 200);
            this.fechaRealEntregaLB.Name = "fechaRealEntregaLB";
            this.fechaRealEntregaLB.Size = new System.Drawing.Size(277, 29);
            this.fechaRealEntregaLB.TabIndex = 19;
            this.fechaRealEntregaLB.Text = "Fecha Real de Entrega:";
            this.fechaRealEntregaLB.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(681, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Monto:";
            // 
            // fechaCompraValueTB
            // 
            this.fechaCompraValueTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCompraValueTB.Location = new System.Drawing.Point(300, 73);
            this.fechaCompraValueTB.MaxLength = 10;
            this.fechaCompraValueTB.Name = "fechaCompraValueTB";
            this.fechaCompraValueTB.Size = new System.Drawing.Size(167, 34);
            this.fechaCompraValueTB.TabIndex = 21;
            this.fechaCompraValueTB.Text = "dd-mm-aaaa";
            this.fechaCompraValueTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // montoValueTB
            // 
            this.montoValueTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoValueTB.Location = new System.Drawing.Point(794, 69);
            this.montoValueTB.Name = "montoValueTB";
            this.montoValueTB.Size = new System.Drawing.Size(252, 34);
            this.montoValueTB.TabIndex = 22;
            this.montoValueTB.Text = "$0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(57, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Factura:";
            // 
            // facturaPathTB
            // 
            this.facturaPathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturaPathTB.Location = new System.Drawing.Point(169, 129);
            this.facturaPathTB.MaxLength = 10;
            this.facturaPathTB.Name = "facturaPathTB";
            this.facturaPathTB.ReadOnly = true;
            this.facturaPathTB.Size = new System.Drawing.Size(714, 34);
            this.facturaPathTB.TabIndex = 24;
            // 
            // seleccionarFacturaBTN
            // 
            this.seleccionarFacturaBTN.Location = new System.Drawing.Point(989, 122);
            this.seleccionarFacturaBTN.Margin = new System.Windows.Forms.Padding(4);
            this.seleccionarFacturaBTN.Name = "seleccionarFacturaBTN";
            this.seleccionarFacturaBTN.Size = new System.Drawing.Size(157, 41);
            this.seleccionarFacturaBTN.TabIndex = 25;
            this.seleccionarFacturaBTN.Text = "Seleccionar Factura";
            this.seleccionarFacturaBTN.UseVisualStyleBackColor = true;
            this.seleccionarFacturaBTN.Click += new System.EventHandler(this.seleccionarFacturaBTN_Click);
            // 
            // fechaEsperadaEntregaTB
            // 
            this.fechaEsperadaEntregaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEsperadaEntregaTB.Location = new System.Drawing.Point(396, 196);
            this.fechaEsperadaEntregaTB.MaxLength = 10;
            this.fechaEsperadaEntregaTB.Name = "fechaEsperadaEntregaTB";
            this.fechaEsperadaEntregaTB.Size = new System.Drawing.Size(167, 34);
            this.fechaEsperadaEntregaTB.TabIndex = 26;
            this.fechaEsperadaEntregaTB.Text = "dd-mm-aaaa";
            this.fechaEsperadaEntregaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fechaRealEntregaTB
            // 
            this.fechaRealEntregaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaRealEntregaTB.Location = new System.Drawing.Point(905, 196);
            this.fechaRealEntregaTB.MaxLength = 10;
            this.fechaRealEntregaTB.Name = "fechaRealEntregaTB";
            this.fechaRealEntregaTB.Size = new System.Drawing.Size(167, 34);
            this.fechaRealEntregaTB.TabIndex = 27;
            this.fechaRealEntregaTB.Text = "dd-mm-aaaa";
            this.fechaRealEntregaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fechaRealEntregaTB.Visible = false;
            // 
            // comprasList
            // 
            this.comprasList.AutoGenerateColumns = false;
            this.comprasList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.comprasList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comprasList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.diasGarantiaDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.compraDataGridViewTextBoxColumn});
            this.comprasList.DataSource = this.equipamientoBindingSource;
            this.comprasList.Location = new System.Drawing.Point(62, 254);
            this.comprasList.Margin = new System.Windows.Forms.Padding(4);
            this.comprasList.Name = "comprasList";
            this.comprasList.RowHeadersVisible = false;
            this.comprasList.RowHeadersWidth = 51;
            this.comprasList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.comprasList.Size = new System.Drawing.Size(1084, 299);
            this.comprasList.TabIndex = 28;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // diasGarantiaDataGridViewTextBoxColumn
            // 
            this.diasGarantiaDataGridViewTextBoxColumn.DataPropertyName = "DiasGarantia";
            this.diasGarantiaDataGridViewTextBoxColumn.HeaderText = "DiasGarantia";
            this.diasGarantiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diasGarantiaDataGridViewTextBoxColumn.Name = "diasGarantiaDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.DataSource = this.categoriasBindingSource;
            this.categoriaDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(GestProv.Dominio._01_ENTIDADES.Categoria);
            // 
            // compraDataGridViewTextBoxColumn
            // 
            this.compraDataGridViewTextBoxColumn.DataPropertyName = "Compra";
            this.compraDataGridViewTextBoxColumn.HeaderText = "Compra";
            this.compraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compraDataGridViewTextBoxColumn.Name = "compraDataGridViewTextBoxColumn";
            this.compraDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipamientoBindingSource
            // 
            this.equipamientoBindingSource.DataSource = typeof(GestProv.Dominio._01_ENTIDADES.Equipamiento);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(GestProv.Dominio._01_ENTIDADES.Proveedor);
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataSource = typeof(GestProv.Dominio._01_ENTIDADES.Sucursal);
            // 
            // CompraVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 630);
            this.Controls.Add(this.comprasList);
            this.Controls.Add(this.fechaRealEntregaTB);
            this.Controls.Add(this.fechaEsperadaEntregaTB);
            this.Controls.Add(this.seleccionarFacturaBTN);
            this.Controls.Add(this.facturaPathTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.montoValueTB);
            this.Controls.Add(this.fechaCompraValueTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fechaRealEntregaLB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sucursalCB);
            this.Controls.Add(this.proveedorCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limpiarBTN);
            this.Controls.Add(this.cancelarBTN);
            this.Controls.Add(this.guardarBTN);
            this.Name = "CompraVista";
            this.Text = "CompraVista";
            ((System.ComponentModel.ISupportInitialize)(this.comprasList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button limpiarBTN;
        private System.Windows.Forms.Button cancelarBTN;
        private System.Windows.Forms.Button guardarBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox proveedorCB;
        private System.Windows.Forms.ComboBox sucursalCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fechaRealEntregaLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fechaCompraValueTB;
        private System.Windows.Forms.TextBox montoValueTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox facturaPathTB;
        private System.Windows.Forms.Button seleccionarFacturaBTN;
        private System.Windows.Forms.TextBox fechaEsperadaEntregaTB;
        private System.Windows.Forms.TextBox fechaRealEntregaTB;
        private System.Windows.Forms.DataGridView comprasList;
        private System.Windows.Forms.BindingSource equipamientoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasGarantiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn compraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
    }
}