namespace GestProv.Presentacion._01_VISTAS
{
    partial class ListadoOrdenesServiciosVista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEstimadaResolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRealResolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordenDeServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDeServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(267, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORDENES DE SERVICIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaSolicitudDataGridViewTextBoxColumn,
            this.fechaEstimadaResolucionDataGridViewTextBoxColumn,
            this.fechaRealResolucionDataGridViewTextBoxColumn,
            this.tecnicoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordenDeServicioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(977, 425);
            this.dataGridView1.TabIndex = 2;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaSolicitudDataGridViewTextBoxColumn
            // 
            this.fechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "FechaSolicitud";
            this.fechaSolicitudDataGridViewTextBoxColumn.HeaderText = "FechaSolicitud";
            this.fechaSolicitudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaSolicitudDataGridViewTextBoxColumn.Name = "fechaSolicitudDataGridViewTextBoxColumn";
            this.fechaSolicitudDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEstimadaResolucionDataGridViewTextBoxColumn
            // 
            this.fechaEstimadaResolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaEstimadaResolucion";
            this.fechaEstimadaResolucionDataGridViewTextBoxColumn.HeaderText = "FechaEstimadaResolucion";
            this.fechaEstimadaResolucionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaEstimadaResolucionDataGridViewTextBoxColumn.Name = "fechaEstimadaResolucionDataGridViewTextBoxColumn";
            this.fechaEstimadaResolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRealResolucionDataGridViewTextBoxColumn
            // 
            this.fechaRealResolucionDataGridViewTextBoxColumn.DataPropertyName = "FechaRealResolucion";
            this.fechaRealResolucionDataGridViewTextBoxColumn.HeaderText = "FechaRealResolucion";
            this.fechaRealResolucionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaRealResolucionDataGridViewTextBoxColumn.Name = "fechaRealResolucionDataGridViewTextBoxColumn";
            this.fechaRealResolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tecnicoDataGridViewTextBoxColumn
            // 
            this.tecnicoDataGridViewTextBoxColumn.DataPropertyName = "Tecnico";
            this.tecnicoDataGridViewTextBoxColumn.HeaderText = "Tecnico";
            this.tecnicoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tecnicoDataGridViewTextBoxColumn.Name = "tecnicoDataGridViewTextBoxColumn";
            this.tecnicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordenDeServicioBindingSource
            // 
            this.ordenDeServicioBindingSource.DataSource = typeof(GestProv.Dominio._01_ENTIDADES.OrdenDeServicio);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(696, 549);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 68);
            this.button3.TabIndex = 11;
            this.button3.Text = "Editar Orden de Servicio";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(401, 549);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 68);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar Orden de Servicio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(161, 549);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nueva Orden de Servicio";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListadoOrdenesServiciosVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 673);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1043, 673);
            this.Name = "ListadoOrdenesServiciosVista";
            this.Text = "ListadoOrdenesServicios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDeServicioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEstimadaResolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRealResolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordenDeServicioBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}