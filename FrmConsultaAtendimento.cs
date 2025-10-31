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

namespace SistemaAtendimento
{
    public partial class FrmConsultaAtendimento : Form
    {
        ConsultaAtendimentoController _consultaAtendimentoController;
        public FrmConsultaAtendimento()
        {
            InitializeComponent();
            _consultaAtendimentoController = new ConsultaAtendimentoController(this);
        }

        private void FrmConsultaAtendimento_Load(object sender, EventArgs e)
        {
            _consultaAtendimentoController.ListarAtendimento();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema de Atendimento");
        }
        public void ExibirAtendimento(List<Atendimentos> atendimentos)
        {
            dgvConsultaAtendimento.DataSource = atendimentos;
        }

        private void dgvConsultaAtendimento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbFiltro_Enter(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string termo = txtFiltro.Text.Trim();
            string filtro = cbxFiltro.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Selecione um filtro.");
                return;
            }

            string condicao;
            if (filtro == "Código do Atendimento") condicao = "codigo";
            else if (filtro == "Nome") condicao = "nome";
            else if (filtro == "CPF") condicao = "cpf";
            else if (filtro == "CNPJ") condicao = "cnpj";
            else condicao = filtro.ToLower();

            _consultaAtendimentoController.ListarAtendimento(termo, condicao);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
