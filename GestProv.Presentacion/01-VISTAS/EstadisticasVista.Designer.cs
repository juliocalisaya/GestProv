
namespace GestProv.Presentacion._01_VISTAS
{
    partial class EstadisticasVista
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
            this.layoutGral = new System.Windows.Forms.TableLayoutPanel();
            this.layoutIzq = new System.Windows.Forms.TableLayoutPanel();
            this.ProveedoresList = new System.Windows.Forms.DataGridView();
            this.consultaBox = new System.Windows.Forms.GroupBox();
            this.mensualRB = new System.Windows.Forms.RadioButton();
            this.anualRB = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comprasPN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comprasValueLB = new System.Windows.Forms.Label();
            this.minimoValueLB = new System.Windows.Forms.Label();
            this.comprasLB = new System.Windows.Forms.Label();
            this.maximoLB = new System.Windows.Forms.Label();
            this.maximoValueLB = new System.Windows.Forms.Label();
            this.minimoLB = new System.Windows.Forms.Label();
            this.resultadosPN = new System.Windows.Forms.Panel();
            this.retrasoValueLB = new System.Windows.Forms.Label();
            this.totalValueLB = new System.Windows.Forms.Label();
            this.retrasoLB = new System.Windows.Forms.Label();
            this.totalLB = new System.Windows.Forms.Label();
            this.mesesPN = new System.Windows.Forms.TableLayoutPanel();
            this.mes8BTN = new System.Windows.Forms.Button();
            this.mes3BTN = new System.Windows.Forms.Button();
            this.mes9BTN = new System.Windows.Forms.Button();
            this.mes12BTN = new System.Windows.Forms.Button();
            this.mes5BTN = new System.Windows.Forms.Button();
            this.mes7BTN = new System.Windows.Forms.Button();
            this.mes10BTN = new System.Windows.Forms.Button();
            this.mes2BTN = new System.Windows.Forms.Button();
            this.mes4BTN = new System.Windows.Forms.Button();
            this.mes11BTN = new System.Windows.Forms.Button();
            this.mes6BTN = new System.Windows.Forms.Button();
            this.mes1BTN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreyApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutGral.SuspendLayout();
            this.layoutIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).BeginInit();
            this.consultaBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.comprasPN.SuspendLayout();
            this.resultadosPN.SuspendLayout();
            this.mesesPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutGral
            // 
            this.layoutGral.ColumnCount = 2;
            this.layoutGral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.44146F));
            this.layoutGral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.55854F));
            this.layoutGral.Controls.Add(this.layoutIzq, 0, 0);
            this.layoutGral.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.layoutGral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutGral.Location = new System.Drawing.Point(0, 0);
            this.layoutGral.Margin = new System.Windows.Forms.Padding(0);
            this.layoutGral.Name = "layoutGral";
            this.layoutGral.RowCount = 1;
            this.layoutGral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutGral.Size = new System.Drawing.Size(782, 547);
            this.layoutGral.TabIndex = 0;
            // 
            // layoutIzq
            // 
            this.layoutIzq.ColumnCount = 1;
            this.layoutIzq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutIzq.Controls.Add(this.ProveedoresList, 0, 1);
            this.layoutIzq.Controls.Add(this.consultaBox, 0, 0);
            this.layoutIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutIzq.Location = new System.Drawing.Point(0, 0);
            this.layoutIzq.Margin = new System.Windows.Forms.Padding(0);
            this.layoutIzq.Name = "layoutIzq";
            this.layoutIzq.RowCount = 3;
            this.layoutIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.2454F));
            this.layoutIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.7546F));
            this.layoutIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.layoutIzq.Size = new System.Drawing.Size(159, 547);
            this.layoutIzq.TabIndex = 0;
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
            this.ProveedoresList.Location = new System.Drawing.Point(8, 109);
            this.ProveedoresList.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.ProveedoresList.MultiSelect = false;
            this.ProveedoresList.Name = "ProveedoresList";
            this.ProveedoresList.ReadOnly = true;
            this.ProveedoresList.RowHeadersVisible = false;
            this.ProveedoresList.RowHeadersWidth = 51;
            this.ProveedoresList.RowTemplate.Height = 24;
            this.ProveedoresList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProveedoresList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProveedoresList.Size = new System.Drawing.Size(149, 419);
            this.ProveedoresList.TabIndex = 0;
            // 
            // consultaBox
            // 
            this.consultaBox.Controls.Add(this.mensualRB);
            this.consultaBox.Controls.Add(this.anualRB);
            this.consultaBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consultaBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaBox.Location = new System.Drawing.Point(8, 8);
            this.consultaBox.Margin = new System.Windows.Forms.Padding(8);
            this.consultaBox.Name = "consultaBox";
            this.consultaBox.Padding = new System.Windows.Forms.Padding(2);
            this.consultaBox.Size = new System.Drawing.Size(143, 91);
            this.consultaBox.TabIndex = 1;
            this.consultaBox.TabStop = false;
            this.consultaBox.Text = "Consulta";
            // 
            // mensualRB
            // 
            this.mensualRB.AutoSize = true;
            this.mensualRB.Location = new System.Drawing.Point(16, 62);
            this.mensualRB.Margin = new System.Windows.Forms.Padding(2);
            this.mensualRB.Name = "mensualRB";
            this.mensualRB.Size = new System.Drawing.Size(94, 24);
            this.mensualRB.TabIndex = 1;
            this.mensualRB.TabStop = true;
            this.mensualRB.Text = "Mensual";
            this.mensualRB.UseVisualStyleBackColor = true;
            // 
            // anualRB
            // 
            this.anualRB.AutoSize = true;
            this.anualRB.Location = new System.Drawing.Point(16, 33);
            this.anualRB.Margin = new System.Windows.Forms.Padding(2);
            this.anualRB.Name = "anualRB";
            this.anualRB.Size = new System.Drawing.Size(73, 24);
            this.anualRB.TabIndex = 0;
            this.anualRB.TabStop = true;
            this.anualRB.Text = "Anual";
            this.anualRB.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.comprasPN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.resultadosPN, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mesesPN, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(623, 547);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comprasPN
            // 
            this.comprasPN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comprasPN.Controls.Add(this.label1);
            this.comprasPN.Controls.Add(this.comprasValueLB);
            this.comprasPN.Controls.Add(this.minimoValueLB);
            this.comprasPN.Controls.Add(this.comprasLB);
            this.comprasPN.Controls.Add(this.maximoLB);
            this.comprasPN.Controls.Add(this.maximoValueLB);
            this.comprasPN.Controls.Add(this.minimoLB);
            this.comprasPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comprasPN.Location = new System.Drawing.Point(6, 165);
            this.comprasPN.Margin = new System.Windows.Forms.Padding(6);
            this.comprasPN.Name = "comprasPN";
            this.comprasPN.Size = new System.Drawing.Size(611, 173);
            this.comprasPN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(226, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Compras";
            // 
            // comprasValueLB
            // 
            this.comprasValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasValueLB.AutoSize = true;
            this.comprasValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.comprasValueLB.Location = new System.Drawing.Point(306, 54);
            this.comprasValueLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comprasValueLB.Name = "comprasValueLB";
            this.comprasValueLB.Size = new System.Drawing.Size(53, 33);
            this.comprasValueLB.TabIndex = 11;
            this.comprasValueLB.Text = "XX";
            // 
            // minimoValueLB
            // 
            this.minimoValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimoValueLB.AutoSize = true;
            this.minimoValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimoValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.minimoValueLB.Location = new System.Drawing.Point(375, 122);
            this.minimoValueLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minimoValueLB.Name = "minimoValueLB";
            this.minimoValueLB.Size = new System.Drawing.Size(180, 33);
            this.minimoValueLB.TabIndex = 10;
            this.minimoValueLB.Text = "$ XXXXX.XX";
            // 
            // comprasLB
            // 
            this.comprasLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comprasLB.AutoSize = true;
            this.comprasLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprasLB.ForeColor = System.Drawing.SystemColors.Control;
            this.comprasLB.Location = new System.Drawing.Point(24, 54);
            this.comprasLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comprasLB.Name = "comprasLB";
            this.comprasLB.Size = new System.Drawing.Size(306, 33);
            this.comprasLB.TabIndex = 9;
            this.comprasLB.Text = "Cantidad de Compras:";
            // 
            // maximoLB
            // 
            this.maximoLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maximoLB.AutoSize = true;
            this.maximoLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximoLB.ForeColor = System.Drawing.SystemColors.Control;
            this.maximoLB.Location = new System.Drawing.Point(24, 88);
            this.maximoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maximoLB.Name = "maximoLB";
            this.maximoLB.Size = new System.Drawing.Size(372, 33);
            this.maximoLB.TabIndex = 8;
            this.maximoLB.Text = "Monto máximo del periodo:";
            // 
            // maximoValueLB
            // 
            this.maximoValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maximoValueLB.AutoSize = true;
            this.maximoValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximoValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.maximoValueLB.Location = new System.Drawing.Point(375, 88);
            this.maximoValueLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maximoValueLB.Name = "maximoValueLB";
            this.maximoValueLB.Size = new System.Drawing.Size(180, 33);
            this.maximoValueLB.TabIndex = 6;
            this.maximoValueLB.Text = "$ XXXXX.XX";
            // 
            // minimoLB
            // 
            this.minimoLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minimoLB.AutoSize = true;
            this.minimoLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimoLB.ForeColor = System.Drawing.SystemColors.Control;
            this.minimoLB.Location = new System.Drawing.Point(24, 122);
            this.minimoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minimoLB.Name = "minimoLB";
            this.minimoLB.Size = new System.Drawing.Size(364, 33);
            this.minimoLB.TabIndex = 5;
            this.minimoLB.Text = "Monto mínimo del periodo:";
            // 
            // resultadosPN
            // 
            this.resultadosPN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resultadosPN.Controls.Add(this.retrasoValueLB);
            this.resultadosPN.Controls.Add(this.totalValueLB);
            this.resultadosPN.Controls.Add(this.retrasoLB);
            this.resultadosPN.Controls.Add(this.totalLB);
            this.resultadosPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadosPN.Location = new System.Drawing.Point(6, 350);
            this.resultadosPN.Margin = new System.Windows.Forms.Padding(6);
            this.resultadosPN.Name = "resultadosPN";
            this.resultadosPN.Size = new System.Drawing.Size(611, 173);
            this.resultadosPN.TabIndex = 1;
            // 
            // retrasoValueLB
            // 
            this.retrasoValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.retrasoValueLB.AutoSize = true;
            this.retrasoValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrasoValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.retrasoValueLB.Location = new System.Drawing.Point(460, 114);
            this.retrasoValueLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retrasoValueLB.Name = "retrasoValueLB";
            this.retrasoValueLB.Size = new System.Drawing.Size(119, 33);
            this.retrasoValueLB.TabIndex = 3;
            this.retrasoValueLB.Text = "XX Días";
            // 
            // totalValueLB
            // 
            this.totalValueLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalValueLB.AutoSize = true;
            this.totalValueLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLB.ForeColor = System.Drawing.SystemColors.Control;
            this.totalValueLB.Location = new System.Drawing.Point(391, 54);
            this.totalValueLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalValueLB.Name = "totalValueLB";
            this.totalValueLB.Size = new System.Drawing.Size(180, 33);
            this.totalValueLB.TabIndex = 2;
            this.totalValueLB.Text = "$ XXXXX.XX";
            // 
            // retrasoLB
            // 
            this.retrasoLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.retrasoLB.AutoSize = true;
            this.retrasoLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrasoLB.ForeColor = System.Drawing.SystemColors.Control;
            this.retrasoLB.Location = new System.Drawing.Point(47, 114);
            this.retrasoLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retrasoLB.Name = "retrasoLB";
            this.retrasoLB.Size = new System.Drawing.Size(438, 33);
            this.retrasoLB.TabIndex = 1;
            this.retrasoLB.Text = "Tiempo de Retraso en Entregas:";
            // 
            // totalLB
            // 
            this.totalLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLB.AutoSize = true;
            this.totalLB.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLB.ForeColor = System.Drawing.SystemColors.Control;
            this.totalLB.Location = new System.Drawing.Point(73, 54);
            this.totalLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLB.Name = "totalLB";
            this.totalLB.Size = new System.Drawing.Size(344, 33);
            this.totalLB.TabIndex = 0;
            this.totalLB.Text = "Monto Total de Compras:";
            // 
            // mesesPN
            // 
            this.mesesPN.ColumnCount = 7;
            this.mesesPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mesesPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.mesesPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mesesPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.mesesPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mesesPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.mesesPN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mesesPN.Controls.Add(this.mes8BTN, 6, 2);
            this.mesesPN.Controls.Add(this.mes3BTN, 4, 0);
            this.mesesPN.Controls.Add(this.mes9BTN, 0, 4);
            this.mesesPN.Controls.Add(this.mes12BTN, 6, 4);
            this.mesesPN.Controls.Add(this.mes5BTN, 0, 2);
            this.mesesPN.Controls.Add(this.mes7BTN, 4, 2);
            this.mesesPN.Controls.Add(this.mes10BTN, 2, 4);
            this.mesesPN.Controls.Add(this.mes2BTN, 2, 0);
            this.mesesPN.Controls.Add(this.mes4BTN, 6, 0);
            this.mesesPN.Controls.Add(this.mes11BTN, 4, 4);
            this.mesesPN.Controls.Add(this.mes6BTN, 2, 2);
            this.mesesPN.Controls.Add(this.mes1BTN, 0, 0);
            this.mesesPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesesPN.Location = new System.Drawing.Point(8, 8);
            this.mesesPN.Margin = new System.Windows.Forms.Padding(8);
            this.mesesPN.Name = "mesesPN";
            this.mesesPN.RowCount = 5;
            this.mesesPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mesesPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.mesesPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mesesPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.mesesPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mesesPN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.mesesPN.Size = new System.Drawing.Size(607, 143);
            this.mesesPN.TabIndex = 2;
            // 
            // mes8BTN
            // 
            this.mes8BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes8BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes8BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes8BTN.FlatAppearance.BorderSize = 4;
            this.mes8BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes8BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes8BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes8BTN.Location = new System.Drawing.Point(461, 52);
            this.mes8BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes8BTN.Name = "mes8BTN";
            this.mes8BTN.Size = new System.Drawing.Size(144, 38);
            this.mes8BTN.TabIndex = 14;
            this.mes8BTN.Text = "Mes";
            this.mes8BTN.UseVisualStyleBackColor = false;
            // 
            // mes3BTN
            // 
            this.mes3BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes3BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes3BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes3BTN.FlatAppearance.BorderSize = 4;
            this.mes3BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes3BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes3BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes3BTN.Location = new System.Drawing.Point(308, 2);
            this.mes3BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes3BTN.Name = "mes3BTN";
            this.mes3BTN.Size = new System.Drawing.Size(141, 38);
            this.mes3BTN.TabIndex = 13;
            this.mes3BTN.Text = "Mes";
            this.mes3BTN.UseVisualStyleBackColor = false;
            // 
            // mes9BTN
            // 
            this.mes9BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes9BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes9BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes9BTN.FlatAppearance.BorderSize = 4;
            this.mes9BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes9BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes9BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes9BTN.Location = new System.Drawing.Point(2, 102);
            this.mes9BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes9BTN.Name = "mes9BTN";
            this.mes9BTN.Size = new System.Drawing.Size(141, 39);
            this.mes9BTN.TabIndex = 12;
            this.mes9BTN.Text = "Mes";
            this.mes9BTN.UseVisualStyleBackColor = false;
            // 
            // mes12BTN
            // 
            this.mes12BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes12BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes12BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes12BTN.FlatAppearance.BorderSize = 4;
            this.mes12BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes12BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes12BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes12BTN.Location = new System.Drawing.Point(461, 102);
            this.mes12BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes12BTN.Name = "mes12BTN";
            this.mes12BTN.Size = new System.Drawing.Size(144, 39);
            this.mes12BTN.TabIndex = 11;
            this.mes12BTN.Text = "Mes";
            this.mes12BTN.UseVisualStyleBackColor = false;
            // 
            // mes5BTN
            // 
            this.mes5BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes5BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes5BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes5BTN.FlatAppearance.BorderSize = 4;
            this.mes5BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes5BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes5BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes5BTN.Location = new System.Drawing.Point(2, 52);
            this.mes5BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes5BTN.Name = "mes5BTN";
            this.mes5BTN.Size = new System.Drawing.Size(141, 38);
            this.mes5BTN.TabIndex = 10;
            this.mes5BTN.Text = "Mes";
            this.mes5BTN.UseVisualStyleBackColor = false;
            // 
            // mes7BTN
            // 
            this.mes7BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes7BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes7BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes7BTN.FlatAppearance.BorderSize = 4;
            this.mes7BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes7BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes7BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes7BTN.Location = new System.Drawing.Point(308, 52);
            this.mes7BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes7BTN.Name = "mes7BTN";
            this.mes7BTN.Size = new System.Drawing.Size(141, 38);
            this.mes7BTN.TabIndex = 9;
            this.mes7BTN.Text = "Mes";
            this.mes7BTN.UseVisualStyleBackColor = false;
            // 
            // mes10BTN
            // 
            this.mes10BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes10BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes10BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes10BTN.FlatAppearance.BorderSize = 4;
            this.mes10BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes10BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes10BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes10BTN.Location = new System.Drawing.Point(155, 102);
            this.mes10BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes10BTN.Name = "mes10BTN";
            this.mes10BTN.Size = new System.Drawing.Size(141, 39);
            this.mes10BTN.TabIndex = 8;
            this.mes10BTN.Text = "Mes";
            this.mes10BTN.UseVisualStyleBackColor = false;
            // 
            // mes2BTN
            // 
            this.mes2BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes2BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes2BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes2BTN.FlatAppearance.BorderSize = 4;
            this.mes2BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes2BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes2BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes2BTN.Location = new System.Drawing.Point(155, 2);
            this.mes2BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes2BTN.Name = "mes2BTN";
            this.mes2BTN.Size = new System.Drawing.Size(141, 38);
            this.mes2BTN.TabIndex = 7;
            this.mes2BTN.Text = "Mes";
            this.mes2BTN.UseVisualStyleBackColor = false;
            // 
            // mes4BTN
            // 
            this.mes4BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes4BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes4BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes4BTN.FlatAppearance.BorderSize = 4;
            this.mes4BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes4BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes4BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes4BTN.Location = new System.Drawing.Point(461, 2);
            this.mes4BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes4BTN.Name = "mes4BTN";
            this.mes4BTN.Size = new System.Drawing.Size(144, 38);
            this.mes4BTN.TabIndex = 6;
            this.mes4BTN.Text = "Mes";
            this.mes4BTN.UseVisualStyleBackColor = false;
            // 
            // mes11BTN
            // 
            this.mes11BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes11BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes11BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes11BTN.FlatAppearance.BorderSize = 4;
            this.mes11BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes11BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes11BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes11BTN.Location = new System.Drawing.Point(308, 102);
            this.mes11BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes11BTN.Name = "mes11BTN";
            this.mes11BTN.Size = new System.Drawing.Size(141, 39);
            this.mes11BTN.TabIndex = 5;
            this.mes11BTN.Text = "Mes";
            this.mes11BTN.UseVisualStyleBackColor = false;
            // 
            // mes6BTN
            // 
            this.mes6BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes6BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes6BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes6BTN.FlatAppearance.BorderSize = 4;
            this.mes6BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes6BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes6BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes6BTN.Location = new System.Drawing.Point(155, 52);
            this.mes6BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes6BTN.Name = "mes6BTN";
            this.mes6BTN.Size = new System.Drawing.Size(141, 38);
            this.mes6BTN.TabIndex = 3;
            this.mes6BTN.Text = "Mes";
            this.mes6BTN.UseVisualStyleBackColor = false;
            // 
            // mes1BTN
            // 
            this.mes1BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.mes1BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mes1BTN.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.mes1BTN.FlatAppearance.BorderSize = 4;
            this.mes1BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mes1BTN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes1BTN.ForeColor = System.Drawing.SystemColors.Control;
            this.mes1BTN.Location = new System.Drawing.Point(2, 2);
            this.mes1BTN.Margin = new System.Windows.Forms.Padding(2);
            this.mes1BTN.Name = "mes1BTN";
            this.mes1BTN.Size = new System.Drawing.Size(141, 38);
            this.mes1BTN.TabIndex = 3;
            this.mes1BTN.Text = "Mes";
            this.mes1BTN.UseVisualStyleBackColor = false;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(GestProv.Dominio._01_ENTIDADES.Proveedor);
            // 
            // nombreyApellidoDataGridViewTextBoxColumn
            // 
            this.nombreyApellidoDataGridViewTextBoxColumn.DataPropertyName = "NombreyApellido";
            this.nombreyApellidoDataGridViewTextBoxColumn.HeaderText = "NombreyApellido";
            this.nombreyApellidoDataGridViewTextBoxColumn.Name = "nombreyApellidoDataGridViewTextBoxColumn";
            this.nombreyApellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EstadisticasVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 547);
            this.Controls.Add(this.layoutGral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(782, 547);
            this.Name = "EstadisticasVista";
            this.Text = "EstadisticasVista";
            this.Load += new System.EventHandler(this.EstadisticasVista_Load);
            this.layoutGral.ResumeLayout(false);
            this.layoutIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).EndInit();
            this.consultaBox.ResumeLayout(false);
            this.consultaBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.comprasPN.ResumeLayout(false);
            this.comprasPN.PerformLayout();
            this.resultadosPN.ResumeLayout(false);
            this.resultadosPN.PerformLayout();
            this.mesesPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutGral;
        private System.Windows.Forms.TableLayoutPanel layoutIzq;
        private System.Windows.Forms.DataGridView ProveedoresList;
        private System.Windows.Forms.GroupBox consultaBox;
        private System.Windows.Forms.RadioButton mensualRB;
        private System.Windows.Forms.RadioButton anualRB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel comprasPN;
        private System.Windows.Forms.Panel resultadosPN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label totalLB;
        private System.Windows.Forms.Label retrasoLB;
        private System.Windows.Forms.Label totalValueLB;
        private System.Windows.Forms.Label retrasoValueLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label comprasValueLB;
        private System.Windows.Forms.Label minimoValueLB;
        private System.Windows.Forms.Label comprasLB;
        private System.Windows.Forms.Label maximoLB;
        private System.Windows.Forms.Label maximoValueLB;
        private System.Windows.Forms.Label minimoLB;
        private System.Windows.Forms.TableLayoutPanel mesesPN;
        private System.Windows.Forms.Button mes8BTN;
        private System.Windows.Forms.Button mes3BTN;
        private System.Windows.Forms.Button mes9BTN;
        private System.Windows.Forms.Button mes12BTN;
        private System.Windows.Forms.Button mes5BTN;
        private System.Windows.Forms.Button mes7BTN;
        private System.Windows.Forms.Button mes10BTN;
        private System.Windows.Forms.Button mes2BTN;
        private System.Windows.Forms.Button mes4BTN;
        private System.Windows.Forms.Button mes11BTN;
        private System.Windows.Forms.Button mes6BTN;
        private System.Windows.Forms.Button mes1BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreyApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
    }
}