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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

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
    }
}
