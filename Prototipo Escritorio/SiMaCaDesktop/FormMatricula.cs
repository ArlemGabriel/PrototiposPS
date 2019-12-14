using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiMaCaDesktop
{
    public partial class FormMatricula : Form
    {
        bool Close = true;
        public FormMatricula()
        {
            InitializeComponent();
        }


        private void msbtnManejoExpendientes_Click(object sender, EventArgs e)
        {
            FormManejoExpedientes manejoExpedientesF = new FormManejoExpedientes();
            manejoExpedientesF.Show();
            Close = false;
            this.Close();
        }

        private void msbtnManejoGrupos_Click(object sender, EventArgs e)
        {
            FormManejoGrupos manejoGruposF = new FormManejoGrupos();
            manejoGruposF.Show();
            Close = false;
            this.Close();
        }

        private void msbtnManejoUsuarios_Click(object sender, EventArgs e)
        {
            FormManejoUsuarios manejoUsuariosF = new FormManejoUsuarios();
            manejoUsuariosF.Show();
            Close = false;
            this.Close();
        }

        private void MatriculaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Close)
            {
                //Mensaje de aviso preguntando si realmente desea cerrar la ventana y volver al inicio
                DialogResult result = MessageBox.Show("Desea cerrar la aplicación", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Close = false; //Para que no pregunte 2 veces si desea salir
                    Application.Exit();
                }
                else if (result == DialogResult.No)
                {
                    //Evita que la ventana se cierre
                    e.Cancel = true;
                }
            } 
        }

        private void btnVerInfo_Click(object sender, EventArgs e)
        {
            FormInfoGrupo FInfoGrupos = new FormInfoGrupo();
            FInfoGrupos.ShowDialog();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            FormBuscarExpediente FBuscarExpediente = new FormBuscarExpediente();
            FBuscarExpediente.ShowDialog();
        }

        private void btnDesmatricular_Click(object sender, EventArgs e)
        {
            FormBuscarExpediente FBuscarExpediente = new FormBuscarExpediente();
            FBuscarExpediente.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msgAcercaDe = "Esta aplicación fue realizada como un proyecto del Instituto Tecnológico de Costa Rica por los estudiantes:\n";
            msgAcercaDe += "\nArlem Gabriel Brenes Aguilar - jogabra16@gmail.com\n";
            msgAcercaDe += "Fabián Piedra Herrera - faph.2009@gmail.com\n";
            msgAcercaDe += "\nDiciembre 2019 - Enero 2020";

            MessageBox.Show(msgAcercaDe, "Acerca de", MessageBoxButtons.OK);
        }
    }
}
