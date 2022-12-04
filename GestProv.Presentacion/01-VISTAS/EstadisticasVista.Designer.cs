
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layoutGral = new System.Windows.Forms.TableLayoutPanel();
            this.layoutIzq = new System.Windows.Forms.TableLayoutPanel();
            this.ProveedoresList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layoutGral.SuspendLayout();
            this.layoutIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutGral
            // 
            this.layoutGral.ColumnCount = 2;
            this.layoutGral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.44146F));
            this.layoutGral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.55854F));
            this.layoutGral.Controls.Add(this.layoutIzq, 0, 0);
            this.layoutGral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutGral.Location = new System.Drawing.Point(0, 0);
            this.layoutGral.Margin = new System.Windows.Forms.Padding(0);
            this.layoutGral.Name = "layoutGral";
            this.layoutGral.RowCount = 1;
            this.layoutGral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutGral.Size = new System.Drawing.Size(1042, 673);
            this.layoutGral.TabIndex = 0;
            // 
            // layoutIzq
            // 
            this.layoutIzq.ColumnCount = 1;
            this.layoutIzq.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutIzq.Controls.Add(this.ProveedoresList, 0, 1);
            this.layoutIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutIzq.Location = new System.Drawing.Point(0, 0);
            this.layoutIzq.Margin = new System.Windows.Forms.Padding(0);
            this.layoutIzq.Name = "layoutIzq";
            this.layoutIzq.RowCount = 3;
            this.layoutIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.92273F));
            this.layoutIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.07727F));
            this.layoutIzq.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutIzq.Size = new System.Drawing.Size(213, 673);
            this.layoutIzq.TabIndex = 0;
            // 
            // ProveedoresList
            // 
            this.ProveedoresList.AllowUserToAddRows = false;
            this.ProveedoresList.AllowUserToDeleteRows = false;
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
            this.Id,
            this.Descripcion});
            this.ProveedoresList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProveedoresList.Location = new System.Drawing.Point(3, 159);
            this.ProveedoresList.MultiSelect = false;
            this.ProveedoresList.Name = "ProveedoresList";
            this.ProveedoresList.ReadOnly = true;
            this.ProveedoresList.RowHeadersVisible = false;
            this.ProveedoresList.RowHeadersWidth = 51;
            this.ProveedoresList.RowTemplate.Height = 24;
            this.ProveedoresList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProveedoresList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProveedoresList.Size = new System.Drawing.Size(207, 490);
            this.ProveedoresList.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Proveedores";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EstadisticasVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 673);
            this.Controls.Add(this.layoutGral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1042, 673);
            this.Name = "EstadisticasVista";
            this.Text = "EstadisticasVista";
            this.layoutGral.ResumeLayout(false);
            this.layoutIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutGral;
        private System.Windows.Forms.TableLayoutPanel layoutIzq;
        private System.Windows.Forms.DataGridView ProveedoresList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}