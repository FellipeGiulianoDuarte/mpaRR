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
            nudDesc1.Maximum = Int64.MaxValue;
            nudDesc2.Maximum = Int64.MaxValue;
            nudDesc3.Maximum = Int64.MaxValue;
            nudJuros.Maximum = Int64.MaxValue;
            nudValor.Maximum = Int64.MaxValue;
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double juros = (double)nudJuros.Value / 100;
            double jurosFixo = 2 / 100;
            double valor = (double)nudValor.Value;
            double desc1 = (double)nudDesc1.Value;
            double desc2 = (double)nudDesc2.Value;
            double desc3 = (double)nudDesc3.Value;

            //valor + juros se tiver - desconto

            if(DateTime.Now > dtpVencimento.Value)
            {

            }
            else
            {
                txtbResul.Text = $"{(((valor - desc1) - desc2) - desc3)}";
            }
        }
    }
}
