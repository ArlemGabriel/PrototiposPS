namespace SiMaCaDesktop
{
    partial class FormManejoGrupos
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
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.lbGrupos = new System.Windows.Forms.Label();
            this.btnAgregarCatequista = new System.Windows.Forms.Button();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.btnQuitarCatequista = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msbtnManejoExpedientes = new System.Windows.Forms.ToolStripMenuItem();
            this.msbtnMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.msbtnManejoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(40, 102);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(731, 376);
            this.dgvGrupos.TabIndex = 0;
            // 
            // lbGrupos
            // 
            this.lbGrupos.AutoSize = true;
            this.lbGrupos.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrupos.Location = new System.Drawing.Point(21, 34);
            this.lbGrupos.Name = "lbGrupos";
            this.lbGrupos.Size = new System.Drawing.Size(170, 28);
            this.lbGrupos.TabIndex = 1;
            this.lbGrupos.Text = "Manejo de Grupos";
            // 
            // btnAgregarCatequista
            // 
            this.btnAgregarCatequista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarCatequista.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCatequista.Location = new System.Drawing.Point(290, 65);
            this.btnAgregarCatequista.Name = "btnAgregarCatequista";
            this.btnAgregarCatequista.Size = new System.Drawing.Size(145, 31);
            this.btnAgregarCatequista.TabIndex = 3;
            this.btnAgregarCatequista.Text = "Agregar Catequista";
            this.btnAgregarCatequista.UseVisualStyleBackColor = true;
            this.btnAgregarCatequista.Click += new System.EventHandler(this.btnAgregarCatequista_Click);
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarGrupo.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGrupo.Location = new System.Drawing.Point(150, 65);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(121, 31);
            this.btnEliminarGrupo.TabIndex = 3;
            this.btnEliminarGrupo.Text = "Eliminar Grupo";
            this.btnEliminarGrupo.UseVisualStyleBackColor = true;
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearGrupo.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearGrupo.Location = new System.Drawing.Point(40, 65);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(104, 31);
            this.btnCrearGrupo.TabIndex = 3;
            this.btnCrearGrupo.Text = "Crear Grupo";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            this.btnCrearGrupo.Click += new System.EventHandler(this.btnCrearGrupo_Click);
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerInfo.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInfo.Location = new System.Drawing.Point(596, 65);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(175, 31);
            this.btnVerInfo.TabIndex = 3;
            this.btnVerInfo.Text = "Información Grupo";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // btnQuitarCatequista
            // 
            this.btnQuitarCatequista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarCatequista.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarCatequista.Location = new System.Drawing.Point(441, 65);
            this.btnQuitarCatequista.Name = "btnQuitarCatequista";
            this.btnQuitarCatequista.Size = new System.Drawing.Size(136, 31);
            this.btnQuitarCatequista.TabIndex = 3;
            this.btnQuitarCatequista.Text = "Quitar Catequista";
            this.btnQuitarCatequista.UseVisualStyleBackColor = true;
            this.btnQuitarCatequista.Click += new System.EventHandler(this.btnQuitarCatequista_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbtnManejoExpedientes,
            this.msbtnMatricula,
            this.msbtnManejoUsuarios,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msbtnManejoExpedientes
            // 
            this.msbtnManejoExpedientes.Name = "msbtnManejoExpedientes";
            this.msbtnManejoExpedientes.Size = new System.Drawing.Size(141, 20);
            this.msbtnManejoExpedientes.Text = "Manejo de Expedientes";
            this.msbtnManejoExpedientes.Click += new System.EventHandler(this.msbtnManejoExpedientes_Click);
            // 
            // msbtnMatricula
            // 
            this.msbtnMatricula.Name = "msbtnMatricula";
            this.msbtnMatricula.Size = new System.Drawing.Size(69, 20);
            this.msbtnMatricula.Text = "Matrícula";
            this.msbtnMatricula.Click += new System.EventHandler(this.msbtnMatricula_Click);
            // 
            // msbtnManejoUsuarios
            // 
            this.msbtnManejoUsuarios.Name = "msbtnManejoUsuarios";
            this.msbtnManejoUsuarios.Size = new System.Drawing.Size(123, 20);
            this.msbtnManejoUsuarios.Text = "Manejo de Usuarios";
            this.msbtnManejoUsuarios.Click += new System.EventHandler(this.msbtnManejoUsuarios_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FormManejoGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 503);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCrearGrupo);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnEliminarGrupo);
            this.Controls.Add(this.btnQuitarCatequista);
            this.Controls.Add(this.btnAgregarCatequista);
            this.Controls.Add(this.lbGrupos);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "FormManejoGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Grupos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManejoGruposForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Label lbGrupos;
        private System.Windows.Forms.Button btnAgregarCatequista;
        private System.Windows.Forms.Button btnEliminarGrupo;
        private System.Windows.Forms.Button btnCrearGrupo;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.Button btnQuitarCatequista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msbtnManejoExpedientes;
        private System.Windows.Forms.ToolStripMenuItem msbtnMatricula;
        private System.Windows.Forms.ToolStripMenuItem msbtnManejoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}