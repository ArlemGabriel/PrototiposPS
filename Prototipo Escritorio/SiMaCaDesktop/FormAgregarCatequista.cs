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
    public partial class FormAgregarCatequista : Form
    {
        public FormAgregarCatequista()
        {
            InitializeComponent();
        }

        private void btnAbrirExpediente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha agregado el catequista al grupo correctamente", "Agregar Catequista", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
