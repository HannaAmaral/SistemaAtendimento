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
    }
}
