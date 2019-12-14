namespace SiMaCaDesktop
{
    partial class FormBuscarExpediente
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
            this.lbBusquedaExpediente = new System.Windows.Forms.Label();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAbrirExpediente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBusquedaExpediente
            // 
            this.lbBusquedaExpediente.AutoSize = true;
            this.lbBusquedaExpediente.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBusquedaExpediente.Location = new System.Drawing.Point(21, 22);
            this.lbBusquedaExpediente.Name = "lbBusquedaExpediente";
            this.lbBusquedaExpediente.Size = new System.Drawing.Size(168, 28);
            this.lbBusquedaExpediente.TabIndex = 2;
            this.lbBusquedaExpediente.Text = "Buscar Expediente";
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(26, 84);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(491, 480);
            this.dgvGrupos.TabIndex = 3;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(22, 53);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(54, 20);
            this.lbBuscar.TabIndex = 5;
            this.lbBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(103, 53);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(181, 20);
            this.txtBuscar.TabIndex = 4;
            // 
            // btnAbrirExpediente
            // 
            this.btnAbrirExpediente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbrirExpediente.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirExpediente.Location = new System.Drawing.Point(363, 42);
            this.btnAbrirExpediente.Name = "btnAbrirExpediente";
            this.btnAbrirExpediente.Size = new System.Drawing.Size(154, 31);
            this.btnAbrirExpediente.TabIndex = 6;
            this.btnAbrirExpediente.Text = "Abrir Expediente";
            this.btnAbrirExpediente.UseVisualStyleBackColor = true;
            this.btnAbrirExpediente.Click += new System.EventHandler(this.btnAbrirExpediente_Click);
            // 
            // BuscarExpedienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 590);
            this.Controls.Add(this.btnAbrirExpediente);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvGrupos);
            this.Controls.Add(this.lbBusquedaExpediente);
            this.Name = "BuscarExpedienteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Expediente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscarExpedienteForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBusquedaExpediente;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAbrirExpediente;
    }
}