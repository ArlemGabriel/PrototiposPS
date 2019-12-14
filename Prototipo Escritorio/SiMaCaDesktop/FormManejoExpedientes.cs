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
    public partial class FormManejoExpedientes : Form
    {
        bool Close = true;
        public FormManejoExpedientes()
        {
            InitializeComponent();
        }

        private void msbtnManejoGrupos_Click(object sender, EventArgs e)
        {
            FormManejoGrupos manejoGruposF = new FormManejoGrupos();
            manejoGruposF.Show();
            Close = false;
            this.Close();
        }

        private void msbtnMatricula_Click(object sender, EventArgs e)
        {
            FormMatricula matriculaForm = new FormMatricula();
            matriculaForm.Show();
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

        private void btnBuscarExpediente_Click(object sender, EventArgs e)
        {
            FormBuscarExpediente buscarExpedienteF = new FormBuscarExpediente();
            buscarExpedienteF.ShowDialog();
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string msgSuccess = "Se ha registrado exitosamente el nuevo expediente";
            string msgError = "Ocurrio un error al intentar registrar el nuevo expediente";
            string msgExists = "El expediente ya existe, si desea cambiarlo intente con el botón Modificar";

            string title = "Registro";

            MessageBoxButtons buttons= MessageBoxButtons.OK;

            MessageBox.Show(msgSuccess,title,buttons);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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
