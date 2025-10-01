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
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                _etapaController.Salvar(etapa);
            }
            else
            {
                etapa.Id = Convert.ToInt32(txtCodigo.Text);

                _etapaController.Atualizar(etapa);
            }
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

        private void dgvEtapas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow LinhaSelecionada = dgvEtapas.Rows[e.RowIndex];

                txtNome.Text = LinhaSelecionada.Cells["Nome"].Value.ToString();
                txtOrdem.Text = LinhaSelecionada.Cells["Ordem"].Value.ToString();
                bool ativo = Convert.ToBoolean(LinhaSelecionada.Cells["Ativo"].Value);
                txtCodigo.Text = LinhaSelecionada.Cells["Id"].Value.ToString();

                rdbAtivo.Checked = Convert.ToBoolean(LinhaSelecionada.Cells["Ativo"].Value);
                rdbInativo.Checked = !Convert.ToBoolean(LinhaSelecionada.Cells["Ativo"].Value);

                btnEditar.Enabled = true;
                btnNovo.Enabled = false;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void HabilitarCampos()
        {
            txtNome.ReadOnly = false;
            txtOrdem.ReadOnly = false;
            pnlSituacao.Enabled = true;

            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtOrdem.Clear();
            rdbAtivo.Checked = true;
            rdbInativo.Checked = false;
            txtCodigo.Clear();
        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtNome.ReadOnly = true;
            txtOrdem.ReadOnly = true;
            pnlSituacao.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnEditar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                ExibirMensagem("Selecione uma Etapa");
                return;
            }
            DialogResult resultado = MessageBox.Show("Deseja excluir esta Etapa?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _etapaController.Excluir(id);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }
    }
}
