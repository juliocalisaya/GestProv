
namespace GestProv.Presentacion._01_VISTAS
{
    partial class EquipamientosVista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.equipamientosList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consultaBox = new System.Windows.Forms.GroupBox();
            this.listadoCompletoRB = new System.Windows.Forms.RadioButton();
            this.fueraDeGarantiaRB = new System.Windows.Forms.RadioButton();
            this.verFacturaBTN = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vtoGarantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientosList)).BeginInit();
            this.panel1.SuspendLayout();
            this.consultaBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.equipamientosList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 673);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // equipamientosList
            // 
            this.equipamientosList.AllowUserToAddRows = false;
            this.equipamientosList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.equipamientosList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.equipamientosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipamientosList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcion,
            this.FechaCompra,
            this.vtoGarantia,
            this.factura,
            this.categoria});
            this.equipamientosList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipamientosList.Location = new System.Drawing.Point(16, 73);
            this.equipamientosList.Margin = new System.Windows.Forms.Padding(16, 3, 16, 3);
            this.equipamientosList.MultiSelect = false;
            this.equipamientosList.Name = "equipamientosList";
            this.equipamientosList.ReadOnly = true;
            this.equipamientosList.RowHeadersVisible = false;
            this.equipamientosList.RowHeadersWidth = 51;
            this.equipamientosList.RowTemplate.Height = 24;
            this.equipamientosList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.equipamientosList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equipamientosList.Size = new System.Drawing.Size(1010, 497);
            this.equipamientosList.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipamientos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.consultaBox);
            this.panel1.Controls.Add(this.verFacturaBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 581);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 84);
            this.panel1.TabIndex = 1;
            // 
            // consultaBox
            // 
            this.consultaBox.Controls.Add(this.listadoCompletoRB);
            this.consultaBox.Controls.Add(this.fueraDeGarantiaRB);
            this.consultaBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaBox.Location = new System.Drawing.Point(20, 7);
            this.consultaBox.Margin = new System.Windows.Forms.Padding(10);
            this.consultaBox.Name = "consultaBox";
            this.consultaBox.Size = new System.Drawing.Size(622, 67);
            this.consultaBox.TabIndex = 9;
            this.consultaBox.TabStop = false;
            this.consultaBox.Text = "Consulta";
            // 
            // listadoCompletoRB
            // 
            this.listadoCompletoRB.AutoSize = true;
            this.listadoCompletoRB.Checked = true;
            this.listadoCompletoRB.Location = new System.Drawing.Point(113, 22);
            this.listadoCompletoRB.Name = "listadoCompletoRB";
            this.listadoCompletoRB.Size = new System.Drawing.Size(201, 29);
            this.listadoCompletoRB.TabIndex = 1;
            this.listadoCompletoRB.TabStop = true;
            this.listadoCompletoRB.Text = "Listado Completo";
            this.listadoCompletoRB.UseVisualStyleBackColor = true;
            this.listadoCompletoRB.CheckedChanged += new System.EventHandler(this.listadoCompletoRB_CheckedChanged);
            // 
            // fueraDeGarantiaRB
            // 
            this.fueraDeGarantiaRB.AutoSize = true;
            this.fueraDeGarantiaRB.Location = new System.Drawing.Point(384, 22);
            this.fueraDeGarantiaRB.Name = "fueraDeGarantiaRB";
            this.fueraDeGarantiaRB.Size = new System.Drawing.Size(207, 29);
            this.fueraDeGarantiaRB.TabIndex = 0;
            this.fueraDeGarantiaRB.Text = "Fuera de Garantia";
            this.fueraDeGarantiaRB.UseVisualStyleBackColor = true;
            this.fueraDeGarantiaRB.CheckedChanged += new System.EventHandler(this.fueraDeGarantiaRB_CheckedChanged);
            // 
            // verFacturaBTN
            // 
            this.verFacturaBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.verFacturaBTN.BackColor = System.Drawing.Color.DarkGreen;
            this.verFacturaBTN.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.verFacturaBTN.FlatAppearance.BorderSize = 4;
            this.verFacturaBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verFacturaBTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verFacturaBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.verFacturaBTN.Location = new System.Drawing.Point(819, 22);
            this.verFacturaBTN.Name = "verFacturaBTN";
            this.verFacturaBTN.Size = new System.Drawing.Size(191, 45);
            this.verFacturaBTN.TabIndex = 8;
            this.verFacturaBTN.Text = "Ver Factura";
            this.verFacturaBTN.UseVisualStyleBackColor = false;
            this.verFacturaBTN.Click += new System.EventHandler(this.verFacturaBTN_Click);
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // FechaCompra
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            this.FechaCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaCompra.HeaderText = "Fecha de Compra";
            this.FechaCompra.MinimumWidth = 6;
            this.FechaCompra.Name = "FechaCompra";
            this.FechaCompra.ReadOnly = true;
            this.FechaCompra.Width = 180;
            // 
            // vtoGarantia
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.vtoGarantia.DefaultCellStyle = dataGridViewCellStyle3;
            this.vtoGarantia.HeaderText = "Vto. Garantía";
            this.vtoGarantia.MinimumWidth = 6;
            this.vtoGarantia.Name = "vtoGarantia";
            this.vtoGarantia.ReadOnly = true;
            this.vtoGarantia.Width = 180;
            // 
            // factura
            // 
            this.factura.HeaderText = "Factura";
            this.factura.MinimumWidth = 6;
            this.factura.Name = "factura";
            this.factura.ReadOnly = true;
            this.factura.Visible = false;
            this.factura.Width = 125;
            // 
            // categoria
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoria.DefaultCellStyle = dataGridViewCellStyle4;
            this.categoria.HeaderText = "Categoria";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 180;
            // 
            // EquipamientosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1042, 673);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1042, 673);
            this.Name = "EquipamientosVista";
            this.Text = "EquipamientosVista";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipamientosList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.consultaBox.ResumeLayout(false);
            this.consultaBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button verFacturaBTN;
        private System.Windows.Forms.GroupBox consultaBox;
        private System.Windows.Forms.RadioButton listadoCompletoRB;
        private System.Windows.Forms.RadioButton fueraDeGarantiaRB;
        private System.Windows.Forms.DataGridView equipamientosList;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtoGarantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}