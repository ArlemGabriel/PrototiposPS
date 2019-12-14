namespace SiMaCaDesktop
{
    partial class FormMatricula
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
            this.btnMatricular = new System.Windows.Forms.Button();
            this.btnVerInfo = new System.Windows.Forms.Button();
            this.btnDesmatricular = new System.Windows.Forms.Button();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msbtnManejoExpendientes = new System.Windows.Forms.ToolStripMenuItem();
            this.msbtnManejoGrupos = new System.Windows.Forms.ToolStripMenuItem();
            this.msbtnManejoUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMatricular
            // 
            this.btnMatricular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMatricular.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricular.Location = new System.Drawing.Point(40, 65);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(94, 31);
            this.btnMatricular.TabIndex = 6;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // btnVerInfo
            // 
            this.btnVerInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerInfo.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerInfo.Location = new System.Drawing.Point(596, 65);
            this.btnVerInfo.Name = "btnVerInfo";
            this.btnVerInfo.Size = new System.Drawing.Size(175, 31);
            this.btnVerInfo.TabIndex = 7;
            this.btnVerInfo.Text = "Información Grupo";
            this.btnVerInfo.UseVisualStyleBackColor = true;
            this.btnVerInfo.Click += new System.EventHandler(this.btnVerInfo_Click);
            // 
            // btnDesmatricular
            // 
            this.btnDesmatricular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDesmatricular.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmatricular.Location = new System.Drawing.Point(140, 65);
            this.btnDesmatricular.Name = "btnDesmatricular";
            this.btnDesmatricular.Size = new System.Drawing.Size(120, 31);
            this.btnDesmatricular.TabIndex = 9;
            this.btnDesmatricular.Text = "Desmatricular";
            this.btnDesmatricular.UseVisualStyleBackColor = true;
            this.btnDesmatricular.Click += new System.EventHandler(this.btnDesmatricular_Click);
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatricula.Location = new System.Drawing.Point(21, 34);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(94, 28);
            this.lbMatricula.TabIndex = 5;
            this.lbMatricula.Text = "Matrícula";
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Location = new System.Drawing.Point(40, 102);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.Size = new System.Drawing.Size(731, 376);
            this.dgvGrupos.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbtnManejoExpendientes,
            this.msbtnManejoGrupos,
            this.msbtnManejoUsuarios,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msbtnManejoExpendientes
            // 
            this.msbtnManejoExpendientes.Name = "msbtnManejoExpendientes";
            this.msbtnManejoExpendientes.Size = new System.Drawing.Size(141, 20);
            this.msbtnManejoExpendientes.Text = "Manejo de Expedientes";
            this.msbtnManejoExpendientes.Click += new System.EventHandler(this.msbtnManejoExpendientes_Click);
            // 
            // msbtnManejoGrupos
            // 
            this.msbtnManejoGrupos.Name = "msbtnManejoGrupos";
            this.msbtnManejoGrupos.Size = new System.Drawing.Size(116, 20);
            this.msbtnManejoGrupos.Text = "Manejo de Grupos";
            this.msbtnManejoGrupos.Click += new System.EventHandler(this.msbtnManejoGrupos_Click);
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
            // FormMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 503);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.btnVerInfo);
            this.Controls.Add(this.btnDesmatricular);
            this.Controls.Add(this.lbMatricula);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "FormMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrícula";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatriculaForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.Button btnVerInfo;
        private System.Windows.Forms.Button btnDesmatricular;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msbtnManejoExpendientes;
        private System.Windows.Forms.ToolStripMenuItem msbtnManejoGrupos;
        private System.Windows.Forms.ToolStripMenuItem msbtnManejoUsuarios;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}