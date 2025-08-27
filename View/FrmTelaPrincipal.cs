using Microsoft.Data.SqlClient;
using SistemaAtendimento.DataBase;

namespace SistemaAtendimento
{
    public partial class FrmSistemaAtedimento : Form
    {
        public FrmSistemaAtedimento()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = ConexaoDB.GetConexao())
                {
                    conexao.Open();
                    MessageBox.Show("Conexão Realizada com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Conectar:" + ex.Message);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrosClientes frmCadastrosClientes = new FrmCadastrosClientes();
            frmCadastrosClientes.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
