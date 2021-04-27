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
        private const long maxValue = Int64.MaxValue;

        public formBase()
        {
            InitializeComponent();
            //definir limites
            nudDesconto.Maximum = maxValue;
            nudJuros.Maximum = maxValue;
            nudValor.Maximum = maxValue;
            nudMora.Maximum = maxValue;
            nudResJuros.Maximum = maxValue;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            //sair do app pelo botao
            Application.Exit();
        }

        private void chkbCalendario_CheckedChanged(object sender, EventArgs e)
        {
            //botao de exibir calendario
            if (chkbCalendario.Checked == true)
            {
                //exibe
                chkbCalendario.Text = "Ocultar calendário";
                mcMes.Visible = true;
            }
            if (chkbCalendario.Checked == false)
            {
                //oculta
                chkbCalendario.Text = "Exibir calendário";
                mcMes.Visible = false;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //limpar valores
            nudResJuros.Value = 0;
            nudMora.Value = 0;
            //valores
            double valor = (double)nudValor.Value;
            double desc1 = (double)nudDesconto.Value;
            double semJ = valor - desc1;

            //datas
            DateTime DataVencimento = dtpVencimento.Value;
            DateTime DataAtual = DateTime.Now;

            //com desconto em %
            double desc2 = desc1 / 100;
            double SemJP = valor - (desc2 * valor);

            //vencimento hoje
            if(DateTime.Now.Date.CompareTo(dtpVencimento.Value.Date) == 0)
            {
                if (chkbDesconto.Checked)
                {
                    //se for em %
                    txtbResul.Text = $"R${SemJP:N2}";
                }
                else
                {
                    //se n for em %
                    txtbResul.Text = $"R${semJ:N2}";
                }
            }
            else

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

                //definicao de dados
                double ResJuros = (double)nudValor.Value * 2 / 100;
                double mora = (double)nudJuros.Value * Dias;
                nudMora.Value = (decimal)mora;
                nudResJuros.Value = (decimal)ResJuros;

                if (chkbAtrasado.Checked)
                {
                    //anular desconto
                    desc1 = 0;
                }

                if (chkbDesconto.Checked)
                {
                    //exibir desconto em %
                    double valorJ = valor * 2 / 100 + (mora) + valor - (valor * desc2);
                    txtbResul.Text = $"R${valorJ:N2}";
                }
                else
                {
                    //desconto em R$
                    double valorJ = valor * 2 / 100 + (mora) + valor - desc1;
                    txtbResul.Text = $"R${valorJ:N2}";
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
                    //pagamento adiantado com desconto em %
                    txtbResul.Text = $"R${SemJP:N2}";
                }
                else
                {
                        //pagamento adiantado com desconto em R$
                        txtbResul.Text = $"R${semJ:N2}";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //limpar campos
            nudDesconto.Value = 0;
            nudJuros.Value = (decimal)0.33;
            nudMora.Value = 0;
            nudResJuros.Value = 0;
            nudValor.Value = 0;
            txtbResul.Clear();
        }

        private void nudValor_ValueChanged(object sender, EventArgs e)
        {
            //bloquear botao de calcular enquanto nao tiver valor
            if (nudValor.Value == 0)
            {
                btnCalc.Enabled = false;
            }
            else
            {
                btnCalc.Enabled = true;
            }
        }

        private void chkbDesconto_CheckedChanged(object sender, EventArgs e)
        {
            //trocar desconto para porcentagem
            if (chkbDesconto.Checked)
            {
                nudDesconto.Maximum = 100;
                chkbDEP.Checked = true;
            }
            if (chkbDesconto.Checked == false)
            {
                chkbDEP.Checked = false;
                nudDesconto.Maximum = maxValue;
            }
        }

        private void chkbAtrasado_CheckedChanged(object sender, EventArgs e)
        {
            //botao checked
            if (chkbAtrasado.Checked)
            {
                chkbAPD.Checked = true;
            }
            if (chkbAtrasado.Checked == false)
            {
                chkbAPD.Checked = false;
            }

        }
    }
}