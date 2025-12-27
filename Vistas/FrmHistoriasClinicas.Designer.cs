namespace Vistas
{
    partial class FrmHistoriasClinicas
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTituloHistoriasClinicas = new System.Windows.Forms.Label();
            this.dgvHistoriasClinicas = new System.Windows.Forms.DataGridView();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).BeginInit();
            this.panelAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTituloHistoriasClinicas);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(964, 50);
            this.panelTitulo.TabIndex = 1;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubTitulo.Location = new System.Drawing.Point(327, 22);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(112, 15);
            this.lblSubTitulo.TabIndex = 15;
            this.lblSubTitulo.Text = "Ver historias clinicas";
            // 
            // lblTituloHistoriasClinicas
            // 
            this.lblTituloHistoriasClinicas.AutoSize = true;
            this.lblTituloHistoriasClinicas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHistoriasClinicas.ForeColor = System.Drawing.Color.White;
            this.lblTituloHistoriasClinicas.Location = new System.Drawing.Point(20, 10);
            this.lblTituloHistoriasClinicas.Name = "lblTituloHistoriasClinicas";
            this.lblTituloHistoriasClinicas.Size = new System.Drawing.Size(290, 30);
            this.lblTituloHistoriasClinicas.TabIndex = 0;
            this.lblTituloHistoriasClinicas.Text = "Gestión de Historias Clinicas";
            // 
            // dgvHistoriasClinicas
            // 
            this.dgvHistoriasClinicas.AllowUserToAddRows = false;
            this.dgvHistoriasClinicas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHistoriasClinicas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistoriasClinicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoriasClinicas.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistoriasClinicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoriasClinicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHistoriasClinicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriasClinicas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistoriasClinicas.EnableHeadersVisualStyles = false;
            this.dgvHistoriasClinicas.Location = new System.Drawing.Point(0, 103);
            this.dgvHistoriasClinicas.MultiSelect = false;
            this.dgvHistoriasClinicas.Name = "dgvHistoriasClinicas";
            this.dgvHistoriasClinicas.ReadOnly = true;
            this.dgvHistoriasClinicas.RowHeadersVisible = false;
            this.dgvHistoriasClinicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoriasClinicas.Size = new System.Drawing.Size(964, 498);
            this.dgvHistoriasClinicas.TabIndex = 3;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.White;
            this.panelAcciones.Controls.Add(this.btnAgregar);
            this.panelAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcciones.Location = new System.Drawing.Point(0, 50);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panelAcciones.Size = new System.Drawing.Size(964, 53);
            this.panelAcciones.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(25, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar historia clinica";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // FrmHistoriasClinicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 601);
            this.Controls.Add(this.dgvHistoriasClinicas);
            this.Controls.Add(this.panelAcciones);
            this.Controls.Add(this.panelTitulo);
            this.Name = "FrmHistoriasClinicas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistoriasClinicas";
            this.Load += new System.EventHandler(this.FrmHistoriasClinicas_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).EndInit();
            this.panelAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTituloHistoriasClinicas;
        private System.Windows.Forms.DataGridView dgvHistoriasClinicas;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Button btnAgregar;
    }
}