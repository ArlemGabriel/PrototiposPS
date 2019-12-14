namespace SiMaCaDesktop
{
    partial class FormManejoUsuarios
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msbtnManejoExpedientes = new System.Windows.Forms.ToolStripMenuItem();
            this.msbtnManejoGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.msbtnMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnDesactivarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnActivarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbtnManejoExpedientes,
            this.msbtnManejoGrupos,
            this.msbtnMatricula,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msbtnManejoExpedientes
            // 
            this.msbtnManejoExpedientes.Name = "msbtnManejoExpedientes";
            this.msbtnManejoExpedientes.Size = new System.Drawing.Size(141, 20);
            this.msbtnManejoExpedientes.Text = "Manejo de Expedientes";
            this.msbtnManejoExpedientes.Click += new System.EventHandler(this.msbtnManejoExpedientes_Click);
            // 
            // msbtnManejoGrupos
            // 
            this.msbtnManejoGrupos.Name = "msbtnManejoGrupos";
            this.msbtnManejoGrupos.Size = new System.Drawing.Size(116, 20);
            this.msbtnManejoGrupos.Text = "Manejo de Grupos";
            this.msbtnManejoGrupos.Click += new System.EventHandler(this.msbtnManejoGrupos_Click);
            // 
            // msbtnMatricula
            // 
            this.msbtnMatricula.Name = "msbtnMatricula";
            this.msbtnMatricula.Size = new System.Drawing.Size(69, 20);
            this.msbtnMatricula.Text = "Matrícula";
            this.msbtnMatricula.Click += new System.EventHandler(this.msbtnMatricula_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(40, 65);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(121, 31);
            this.btnCrearUsuario.TabIndex = 10;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnDesactivarUsuario
            // 
            this.btnDesactivarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDesactivarUsuario.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarUsuario.Location = new System.Drawing.Point(625, 65);
            this.btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            this.btnDesactivarUsuario.Size = new System.Drawing.Size(146, 31);
            this.btnDesactivarUsuario.TabIndex = 11;
            this.btnDesactivarUsuario.Text = "Desactivar Usuario";
            this.btnDesactivarUsuario.UseVisualStyleBackColor = true;
            this.btnDesactivarUsuario.Click += new System.EventHandler(this.btnDesactivarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(318, 65);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(132, 31);
            this.btnEliminarUsuario.TabIndex = 12;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Visible = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnActivarUsuario
            // 
            this.btnActivarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActivarUsuario.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivarUsuario.Location = new System.Drawing.Point(485, 65);
            this.btnActivarUsuario.Name = "btnActivarUsuario";
            this.btnActivarUsuario.Size = new System.Drawing.Size(136, 31);
            this.btnActivarUsuario.TabIndex = 13;
            this.btnActivarUsuario.Text = "Activar Usuario";
            this.btnActivarUsuario.UseVisualStyleBackColor = true;
            this.btnActivarUsuario.Click += new System.EventHandler(this.btnActivarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Location = new System.Drawing.Point(167, 65);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(145, 31);
            this.btnModificarUsuario.TabIndex = 14;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.Location = new System.Drawing.Point(21, 34);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(181, 28);
            this.lbUsuarios.TabIndex = 9;
            this.lbUsuarios.Text = "Manejo de Usuarios";
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(40, 102);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(731, 376);
            this.dgvGrupos.TabIndex = 8;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscar.Location = new System.Drawing.Point(509, 40);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(54, 20);
            this.lbBuscar.TabIndex = 17;
            this.lbBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(590, 40);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(181, 20);
            this.txtBuscar.TabIndex = 16;
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FormManejoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 503);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.btnDesactivarUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnActivarUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.lbUsuarios);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "FormManejoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManejoUsuariosForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msbtnManejoExpedientes;
        private System.Windows.Forms.ToolStripMenuItem msbtnManejoGrupos;
        private System.Windows.Forms.ToolStripMenuItem msbtnMatricula;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnDesactivarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnActivarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}