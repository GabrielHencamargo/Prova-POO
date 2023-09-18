using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaVeiculo.Properties;

namespace wfaVeiculo
{
    public partial class Form1 : Form
    {
        public void limpar()
        {
            mtplaca.Text = "";
            tbassentoeixo.Text = "";
            tbano.Text = "";

        }
        public Form1()
        {
            InitializeComponent();
            mtplaca.Mask = "aaa-0000";

        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            if (rbcaminhao.Checked == true) 
            {
                Fcaminhao fcaminhao = new Fcaminhao(mtplaca.Text, Convert.ToInt32(tbano.Text), Convert.ToInt32(tbassentoeixo.Text));
                ListViewItem item = new ListViewItem(fcaminhao.Placa);
                item.SubItems.Add(Convert.ToString(fcaminhao.Ano));
                item.SubItems.Add("");
                item.SubItems.Add(Convert.ToString(fcaminhao.Eixos));
                item.SubItems.Add(Convert.ToString(fcaminhao.alugar()) + " R$");
                lv1.Items.Add(item);
                limpar();
            
            }
            if (rbOnibus.Checked == true)
            {
                Fonibus fonibus = new Fonibus(mtplaca.Text, Convert.ToInt32(tbano.Text), Convert.ToInt32(tbassentoeixo.Text));
                ListViewItem item = new ListViewItem(fonibus.Placa);
                item.SubItems.Add(Convert.ToString(fonibus.Ano));
                item.SubItems.Add(Convert.ToString(fonibus.Assentos));
                item.SubItems.Add("");
                item.SubItems.Add(Convert.ToString(fonibus.alugar()) + " R$");
                lv1.Items.Add(item);
                limpar();
            }
        }

        private void rbOnibus_CheckedChanged(object sender, EventArgs e)
        {
            lbaltera.Text = "Qtd assentos";
            pbimagem.Image = Resources.onibus;
        }

        private void rbcaminhao_CheckedChanged(object sender, EventArgs e)
        {
            lbaltera.Text = "Qtd eixos";
            pbimagem.Image = Resources.caminhao;
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }
    }
}
