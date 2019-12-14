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
    public partial class FormCrearGrupo : Form
    {
        public FormCrearGrupo()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha creado el grupo con éxito", "Crear Grupo", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
