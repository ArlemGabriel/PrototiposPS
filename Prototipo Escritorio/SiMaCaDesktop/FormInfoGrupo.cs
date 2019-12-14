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
    public partial class FormInfoGrupo : Form
    {
        public FormInfoGrupo()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha modificado el grupo con éxito", "Modificar Grupo", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
