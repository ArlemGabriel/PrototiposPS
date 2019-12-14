namespace SiMaCaDesktop
{
    partial class FormAgregarCatequista
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
            this.lbAddCatequista = new System.Windows.Forms.Label();
            this.btnAbrirExpediente = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvCatequistas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatequistas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAddCatequista
            // 
            this.lbAddCatequista.AutoSize = true;
            this.lbAddCatequista.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddCatequista.Location = new System.Drawing.Point(21, 25);
            this.lbAddCatequista.Name = "lbAddCatequista";
            this.lbAddCatequista.Size = new System.Drawing.Size(250, 28);
            this.lbAddCatequista.TabIndex = 4;
            this.lbAddCatequista.Text = "Agregar Catequista a Grupo";
            // 
            // btnAbrirExpediente
            // 
            this.btnAbrirExpediente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbrirExpediente.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirExpediente.Location = new System.Drawing.Point(363, 47);
            this.btnAbrirExpediente.Name = "btnAbrirExpediente";
            this.btnAbrirExpediente.Size = new System.Drawing.Size(154, 31);
            this.btnAbrirExpediente.TabIndex = 10;
            this.btnAbrirExpediente.Text = "Agregar Catequista";
            this.btnAbrirExpediente.UseVisualStyleBackColor = true;
            this.btnAbrirExpediente.Click += new System.EventHandler(this.btnAbrirExpediente_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(22, 58);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(54, 20);
            this.lbBuscar.TabIndex = 9;
            this.lbBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(103, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(181, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // dgvCatequistas
            // 
            this.dgvCatequistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatequistas.Location = new System.Drawing.Point(26, 89);
            this.dgvCatequistas.Name = "dgvCatequistas";
            this.dgvCatequistas.Size = new System.Drawing.Size(491, 480);
            this.dgvCatequistas.TabIndex = 7;
            // 
            // FormAgregarCatequista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 590);
            this.Controls.Add(this.btnAbrirExpediente);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvCatequistas);
            this.Controls.Add(this.lbAddCatequista);
            this.Name = "FormAgregarCatequista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Catequista a Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatequistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddCatequista;
        private System.Windows.Forms.Button btnAbrirExpediente;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvCatequistas;
    }
}