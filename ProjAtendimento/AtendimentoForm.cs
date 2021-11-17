using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjAtendimento
{
    public partial class AtendimentoForm : Form
    {
        private Guiches guiches;
        private Senhas senhas;

        public AtendimentoForm()
        {
            InitializeComponent();
        }

        private void AtendimentoForm_Load(object sender, EventArgs e)
        {
            guiches = new Guiches();
            senhas = new Senhas();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int qtdGuiches = guiches.ListaGuiches.Count;
            Guiche guiche = new Guiche(qtdGuiches);
            guiches.Adicionar(guiche);

            lblQtd.Text = (qtdGuiches + 1).ToString();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.Gerar();
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            listSenhas.Items.Clear();
            foreach(Senha senha in senhas.FilaSenhas)
            {
                listSenhas.Items.Add(senha.DadosParciais());
            }
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            int idGuiche = int.Parse(txtGuiche.Text);
            Guiche guiche = guiches.ListaGuiches.Find(guiche => guiche.Id == idGuiche);
            guiche.Chamar(senhas.FilaSenhas);
        }

        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            listAtendimentos.Items.Clear();
            List<string> senhasAtendidas = new List<string>();

            foreach(Guiche guiche in guiches.ListaGuiches)
            {
                foreach (Senha atendimento in guiche.Atendimentos)
                {
                    senhasAtendidas.Add(atendimento.DadosCompletos());
                }
            }

            senhasAtendidas.Sort();
            listAtendimentos.Items.AddRange(senhasAtendidas.ToArray());
        }
    }
}
