using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baseRR
{
    public partial class formBase : Form
    {
        public formBase()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formBase_Load(object sender, EventArgs e)
        {

        }

        private void nudJuros_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkbCalendario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbCalendario.Checked == true)
            {
                chkbCalendario.Text = "Ocultar calendário";
                mcMes.Visible = true;
            }
            if (chkbCalendario.Checked == false)
            {
                chkbCalendario.Text = "Exibir calendário";
                mcMes.Visible = false;
            }
        }
    }
}
