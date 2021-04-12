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
            nudDesconto.Maximum = Int64.MaxValue;
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
            //valores
            double valor = (double)nudValor.Value;
            double desc1 = (double)nudDesconto.Value;
            double semJ = valor - desc1;

            //datas
            DateTime DataVencimento = dtpVencimento.Value;
            DateTime DataAtual = DateTime.Now;

            double desc2 = desc1 / 100;
            double SemJP = valor - (desc2 * valor);

            try
            {
                //data pra trás
                int Anos = new DateTime(DateTime.Now.Subtract(DataVencimento).Ticks).Year - 1;
                DateTime AnosT = DataVencimento.AddYears(Anos);
                int Meses = 0;
                for (int n = 1; n <= 12; n++)
                {
                    if (AnosT.AddMonths(n) == DataAtual)
                    {
                        Meses = n;
                        break;
                    }
                    else if (AnosT.AddMonths(n) >= DataAtual)
                    {
                        Meses = n - 1;
                        break;
                    }
                }
                int Dias = DataAtual.Subtract(AnosT.AddMonths(Meses)).Days;

                if (chkbAtrasado.Checked)
                {
                    desc1 = 0;
                }

                if (chkbDesconto.Checked)
                {
                    double valorJ = valor * 2 / 100 + ((double)nudJuros.Value * Dias) + valor - (valor * desc2);
                    txtbResul.Text = $"R${valorJ.ToString("N2")}";
                }
                else
                {
                    double valorJ = valor * 2 / 100 + ((double)nudJuros.Value * Dias) + valor - desc1;
                    txtbResul.Text = $"R${valorJ.ToString("N2")}";
                }

            }
            catch
            {
                //data pra frente
                int Anos = new DateTime(DateTime.Now.Subtract(DataAtual).Ticks).Year - 1;
                DateTime AnosT = DataAtual.AddYears(Anos);
                int Meses = 0;
                for (int n = 1; n <= 12; n++)
                {
                    if (AnosT.AddMonths(n) == DataVencimento)
                    {
                        Meses = n;
                        break;
                    }
                    else if (AnosT.AddMonths(n) >= DataVencimento)
                    {
                        Meses = n - 1;
                        break;
                    }
                }
                int Dias = DataVencimento.Subtract(AnosT.AddMonths(Meses)).Days;

                if (chkbDesconto.Checked)
                {
                    txtbResul.Text = $"R${SemJP.ToString("N2")}";
                }
                else
                {
                    txtbResul.Text = $"R${semJ.ToString("N2")}";
                }
            }
        }
    }
}
