
namespace GestProv.Presentacion._01_VISTAS
{
    partial class CalificacionesVista
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProveedoresList = new System.Windows.Forms.DataGridView();
            this.nombreyApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.resultadosPN = new System.Windows.Forms.Panel();
            this.ordenesPenalizacionValueLB = new System.Windows.Forms.Label();
            this.ordenesPenalizacionLB = new System.Windows.Forms.Label();
            this.demoraOrdenesValueLB = new System.Windows.Forms.Label();
            this.cantidadOrdenesValueLB = new System.Windows.Forms.Label();
            this.demorasOrdenesLB = new System.Windows.Forms.Label();
            this.cantidadOrdenesServicioLB = new System.Windows.Forms.Label();
            this.comprasPN = new System.Windows.Forms.Panel();
            this.comprasValueLB = new System.Windows.Forms.Label();
            this.comprasPenalizacionValueLB = new System.Windows.Forms.Label();
            this.comprasLB = new System.Windows.Forms.Label();
            this.comprasRetrasosLB = new System.Windows.Forms.Label();
            this.comprasRetrasoValueLB = new System.Windows.Forms.Label();
            this.comprasPenalizacionLB = new System.Windows.Forms.Label();
            this.tituloLB = new System.Windows.Forms.Label();
            this.calificacionValueLB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.resultadosPN.SuspendLayout();
            this.comprasPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ProveedoresList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 547);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.ProveedoresList.Location = new System.Drawing.Point(8, 10);
            this.ProveedoresList.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.ProveedoresList.MultiSelect = false;
            this.ProveedoresList.Name = "ProveedoresList";
            this.ProveedoresList.ReadOnly = true;
            this.ProveedoresList.RowHeadersVisible = false;
            this.ProveedoresList.RowHeadersWidth = 51;
            this.ProveedoresList.RowTemplate.Height = 24;
            this.ProveedoresList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProveedoresList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProveedoresList.Size = new System.Drawing.Size(155, 519);
            this.ProveedoresList.TabIndex = 2;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.resultadosPN, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.comprasPN, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tituloLB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.calificacionValueLB, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(165, 8);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 523);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // resultadosPN
            // 
            this.resultadosPN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resultadosPN.Controls.Add(this.ordenesPenalizacionValueLB);
            this.resultadosPN.Controls.Add(this.ordenesPenalizacionLB);
            this.resultadosPN.Controls.Add(this.demoraOrdenesValueLB);
            this.resultadosPN.Controls.Add(this.cantidadOrdenesValueLB);
            this.resultadosPN.Controls.Add(this.demorasOrdenesLB);
            this.resultadosPN.Controls.Add(this.cantidadOrdenesServicioLB);
            this.resultadosPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadosPN.Location = new System.Drawing.Point(6, 363);
            this.resultadosPN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultadosPN.Name = "resultadosPN";
            this.resultadosPN.Size = new System.Drawing.Size(605, 160);
            this.resultadosPN.TabIndex = 3;
            // 
            // ordenesPenalizacionValueLB
            // 
            this.ordenesPenalizacionValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordenesPenalizacionValueLB.AutoSize = true;
            this.ordenesPenalizacionValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenesPenalizacionValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.ordenesPenalizacionValueLB.Location = new System.Drawing.Point(348, 114);
            this.ordenesPenalizacionValueLB.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.ordenesPenalizacionValueLB.Name = "ordenesPenalizacionValueLB";
            this.ordenesPenalizacionValueLB.Size = new System.Drawing.Size(152, 33);
            this.ordenesPenalizacionValueLB.TabIndex = 12;
            this.ordenesPenalizacionValueLB.Text = "XX Puntos";
            // 
            // ordenesPenalizacionLB
            // 
            this.ordenesPenalizacionLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordenesPenalizacionLB.AutoSize = true;
            this.ordenesPenalizacionLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenesPenalizacionLB.ForeColor = System.Drawing.SystemColors.Control;
            this.ordenesPenalizacionLB.Location = new System.Drawing.Point(148, 114);
            this.ordenesPenalizacionLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ordenesPenalizacionLB.Name = "ordenesPenalizacionLB";
            this.ordenesPenalizacionLB.Size = new System.Drawing.Size(188, 33);
            this.ordenesPenalizacionLB.TabIndex = 11;
            this.ordenesPenalizacionLB.Text = "Penalización:";
            // 
            // demoraOrdenesValueLB
            // 
            this.demoraOrdenesValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demoraOrdenesValueLB.AutoSize = true;
            this.demoraOrdenesValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demoraOrdenesValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.demoraOrdenesValueLB.Location = new System.Drawing.Point(523, 69);
            this.demoraOrdenesValueLB.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.demoraOrdenesValueLB.Name = "demoraOrdenesValueLB";
            this.demoraOrdenesValueLB.Size = new System.Drawing.Size(53, 33);
            this.demoraOrdenesValueLB.TabIndex = 3;
            this.demoraOrdenesValueLB.Text = "XX";
            // 
            // cantidadOrdenesValueLB
            // 
            this.cantidadOrdenesValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantidadOrdenesValueLB.AutoSize = true;
            this.cantidadOrdenesValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadOrdenesValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.cantidadOrdenesValueLB.Location = new System.Drawing.Point(511, 24);
            this.cantidadOrdenesValueLB.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.cantidadOrdenesValueLB.Name = "cantidadOrdenesValueLB";
            this.cantidadOrdenesValueLB.Size = new System.Drawing.Size(53, 33);
            this.cantidadOrdenesValueLB.TabIndex = 2;
            this.cantidadOrdenesValueLB.Text = "XX";
            // 
            // demorasOrdenesLB
            // 
            this.demorasOrdenesLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.demorasOrdenesLB.AutoSize = true;
            this.demorasOrdenesLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demorasOrdenesLB.ForeColor = System.Drawing.SystemColors.Control;
            this.demorasOrdenesLB.Location = new System.Drawing.Point(52, 69);
            this.demorasOrdenesLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.demorasOrdenesLB.Name = "demorasOrdenesLB";
            this.demorasOrdenesLB.Size = new System.Drawing.Size(475, 33);
            this.demorasOrdenesLB.TabIndex = 1;
            this.demorasOrdenesLB.Text = "Cantidad de Servicios con demora:";
            // 
            // cantidadOrdenesServicioLB
            // 
            this.cantidadOrdenesServicioLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cantidadOrdenesServicioLB.AutoSize = true;
            this.cantidadOrdenesServicioLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadOrdenesServicioLB.ForeColor = System.Drawing.SystemColors.Control;
            this.cantidadOrdenesServicioLB.Location = new System.Drawing.Point(62, 24);
            this.cantidadOrdenesServicioLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cantidadOrdenesServicioLB.Name = "cantidadOrdenesServicioLB";
            this.cantidadOrdenesServicioLB.Size = new System.Drawing.Size(456, 33);
            this.cantidadOrdenesServicioLB.TabIndex = 0;
            this.cantidadOrdenesServicioLB.Text = "Cantidad de Ordenes de Servicio:";
            // 
            // comprasPN
            // 
            this.comprasPN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comprasPN.Controls.Add(this.comprasValueLB);
            this.comprasPN.Controls.Add(this.comprasPenalizacionValueLB);
            this.comprasPN.Controls.Add(this.comprasLB);
            this.comprasPN.Controls.Add(this.comprasRetrasosLB);
            this.comprasPN.Controls.Add(this.comprasRetrasoValueLB);
            this.comprasPN.Controls.Add(this.comprasPenalizacionLB);
            this.comprasPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comprasPN.Location = new System.Drawing.Point(6, 195);
            this.comprasPN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.comprasPN.Name = "comprasPN";
            this.comprasPN.Size = new System.Drawing.Size(605, 160);
            this.comprasPN.TabIndex = 2;
            // 
            // comprasValueLB
            // 
            this.comprasValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasValueLB.AutoSize = true;
            this.comprasValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.comprasValueLB.Location = new System.Drawing.Point(439, 27);
            this.comprasValueLB.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.comprasValueLB.Name = "comprasValueLB";
            this.comprasValueLB.Size = new System.Drawing.Size(53, 33);
            this.comprasValueLB.TabIndex = 11;
            this.comprasValueLB.Text = "XX";
            // 
            // comprasPenalizacionValueLB
            // 
            this.comprasPenalizacionValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasPenalizacionValueLB.AutoSize = true;
            this.comprasPenalizacionValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasPenalizacionValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.comprasPenalizacionValueLB.Location = new System.Drawing.Point(355, 113);
            this.comprasPenalizacionValueLB.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.comprasPenalizacionValueLB.Name = "comprasPenalizacionValueLB";
            this.comprasPenalizacionValueLB.Size = new System.Drawing.Size(152, 33);
            this.comprasPenalizacionValueLB.TabIndex = 10;
            this.comprasPenalizacionValueLB.Text = "XX Puntos";
            // 
            // comprasLB
            // 
            this.comprasLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasLB.AutoSize = true;
            this.comprasLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasLB.ForeColor = System.Drawing.SystemColors.Control;
            this.comprasLB.Location = new System.Drawing.Point(130, 27);
            this.comprasLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comprasLB.Name = "comprasLB";
            this.comprasLB.Size = new System.Drawing.Size(306, 33);
            this.comprasLB.TabIndex = 9;
            this.comprasLB.Text = "Cantidad de Compras:";
            // 
            // comprasRetrasosLB
            // 
            this.comprasRetrasosLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasRetrasosLB.AutoSize = true;
            this.comprasRetrasosLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasRetrasosLB.ForeColor = System.Drawing.SystemColors.Control;
            this.comprasRetrasosLB.Location = new System.Drawing.Point(62, 71);
            this.comprasRetrasosLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comprasRetrasosLB.Name = "comprasRetrasosLB";
            this.comprasRetrasosLB.Size = new System.Drawing.Size(459, 33);
            this.comprasRetrasosLB.TabIndex = 8;
            this.comprasRetrasosLB.Text = "Cantidad de Retrasos de Entrega:";
            // 
            // comprasRetrasoValueLB
            // 
            this.comprasRetrasoValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasRetrasoValueLB.AutoSize = true;
            this.comprasRetrasoValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasRetrasoValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.comprasRetrasoValueLB.Location = new System.Drawing.Point(523, 71);
            this.comprasRetrasoValueLB.Margin = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.comprasRetrasoValueLB.Name = "comprasRetrasoValueLB";
            this.comprasRetrasoValueLB.Size = new System.Drawing.Size(53, 33);
            this.comprasRetrasoValueLB.TabIndex = 6;
            this.comprasRetrasoValueLB.Text = "XX";
            // 
            // comprasPenalizacionLB
            // 
            this.comprasPenalizacionLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasPenalizacionLB.AutoSize = true;
            this.comprasPenalizacionLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasPenalizacionLB.ForeColor = System.Drawing.SystemColors.Control;
            this.comprasPenalizacionLB.Location = new System.Drawing.Point(148, 113);
            this.comprasPenalizacionLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comprasPenalizacionLB.Name = "comprasPenalizacionLB";
            this.comprasPenalizacionLB.Size = new System.Drawing.Size(188, 33);
            this.comprasPenalizacionLB.TabIndex = 5;
            this.comprasPenalizacionLB.Text = "Penalización:";
            // 
            // tituloLB
            // 
            this.tituloLB.AutoSize = true;
            this.tituloLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tituloLB.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLB.Location = new System.Drawing.Point(2, 0);
            this.tituloLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLB.Name = "tituloLB";
            this.tituloLB.Size = new System.Drawing.Size(613, 49);
            this.tituloLB.TabIndex = 0;
            this.tituloLB.Text = "Calificación";
            this.tituloLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calificacionValueLB
            // 
            this.calificacionValueLB.AutoSize = true;
            this.calificacionValueLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calificacionValueLB.Font = new System.Drawing.Font("Arial Black", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calificacionValueLB.Location = new System.Drawing.Point(2, 57);
            this.calificacionValueLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calificacionValueLB.Name = "calificacionValueLB";
            this.calificacionValueLB.Size = new System.Drawing.Size(613, 130);
            this.calificacionValueLB.TabIndex = 1;
            this.calificacionValueLB.Text = "100";
            this.calificacionValueLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalificacionesVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 547);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(782, 547);
            this.Name = "CalificacionesVista";
            this.Text = "CalificacionesVista";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalificacionesVista_FormClosing);
            this.Load += new System.EventHandler(this.CalificacionesVista_Load);
            this.VisibleChanged += new System.EventHandler(this.CalificacionesVista_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.resultadosPN.ResumeLayout(false);
            this.resultadosPN.PerformLayout();
            this.comprasPN.ResumeLayout(false);
            this.comprasPN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView ProveedoresList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label tituloLB;
        private System.Windows.Forms.Label calificacionValueLB;
        private System.Windows.Forms.Panel comprasPN;
        private System.Windows.Forms.Label comprasValueLB;
        private System.Windows.Forms.Label comprasPenalizacionValueLB;
        private System.Windows.Forms.Label comprasLB;
        private System.Windows.Forms.Label comprasRetrasosLB;
        private System.Windows.Forms.Label comprasRetrasoValueLB;
        private System.Windows.Forms.Label comprasPenalizacionLB;
        private System.Windows.Forms.Panel resultadosPN;
        private System.Windows.Forms.Label demoraOrdenesValueLB;
        private System.Windows.Forms.Label cantidadOrdenesValueLB;
        private System.Windows.Forms.Label demorasOrdenesLB;
        private System.Windows.Forms.Label cantidadOrdenesServicioLB;
        private System.Windows.Forms.Label ordenesPenalizacionValueLB;
        private System.Windows.Forms.Label ordenesPenalizacionLB;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreyApellidoDataGridViewTextBoxColumn;
    }
}