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
    public partial class FormBuscarExpediente : Form
    {
        public FormBuscarExpediente()
        {
            InitializeComponent();
        }

        private void btnAbrirExpediente_Click(object sender, EventArgs e)
        {
            /*TODO send info*/
            /*MainForm expedienteForm = new MainForm();
            expedienteForm.Show();*/
            this.Close();
        }

        private void BuscarExpedienteForm_FormClosing(object sender, FormClosingEventArgs e)
        {            
        }
    }
}
