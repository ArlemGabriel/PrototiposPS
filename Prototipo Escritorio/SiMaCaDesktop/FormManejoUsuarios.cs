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
    public partial class FormManejoUsuarios : Form
    {
        bool Close = true;
        public FormManejoUsuarios()
        {
            InitializeComponent();
        }

        private void msbtnManejoExpedientes_Click(object sender, EventArgs e)
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

        private void msbtnMatricula_Click(object sender, EventArgs e)
        {
            FormMatricula matriculaForm = new FormMatricula();
            matriculaForm.Show();
            Close = false;
            this.Close();
        }

        private void ManejoUsuariosForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Se ha eliminado el usuario correctamente", "Eliminación", MessageBoxButtons.OK);
            } 
        }

        private void btnActivarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea activar la cuenta del usuario seleccionado?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Se ha activado la cuenta correctamente", "Activación", MessageBoxButtons.OK);
            } 
        }

        private void btnDesactivarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea desactivar la cuenta del usuario seleccionado?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Se ha desactivado la cuenta correctamente", "Desactivación", MessageBoxButtons.OK);
            } 
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            FormCrearUsuario FCrearUsuario = new FormCrearUsuario();
            FCrearUsuario.ShowDialog();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            FormCrearUsuario FCrearUsuario = new FormCrearUsuario();
            FCrearUsuario.ShowDialog();
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
