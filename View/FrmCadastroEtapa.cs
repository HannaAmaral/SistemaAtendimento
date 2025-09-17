using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroEtapa : Form
    {
        private EtapaController _etapaController;


        public FrmCadastroEtapa()
        {
            InitializeComponent();
            _etapaController = new EtapaController(this);
        }

        private void FrmCadastroEtapa_Load(object sender, EventArgs e)
        {
            _etapaController.ListarEtapas();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirEtapas(List<Etapa> etapas)
        {
            dgvEtapas.DataSource = etapas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Etapa etapa = new Etapa()
            {
                Nome = txtNome.Text,
                Ordem = Convert.ToInt32(txtOrdem.Text),
                Ativo = rdbAtivo.Checked,
            };
            if (!ValidarDados(etapa))
                return;
            _etapaController.Salvar(etapa);

        }

        public bool ValidarDados(Etapa etapa)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                ExibirMensagem("O Campo Nome obrigatório");
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtOrdem.Text))
            {
                ExibirMensagem("O Campo Ordem obrigatório");
                txtOrdem.Focus();
                return false;
            }

            if (!int.TryParse(txtOrdem.Text, out int ordem) || ordem <= 0)
            {
                ExibirMensagem("O Campo Ordem deve ser um número inteiro positivo.");
                txtOrdem.Focus();
                return false;
            }

            
            return true;
        }
    }
}
