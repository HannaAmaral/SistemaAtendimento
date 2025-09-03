using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaAtendimento.DataBase;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.Repositories
{
    public class ClienteRepository
    {
        //quero que retorne uma lista de clientes

        public List<Clientes> Listar()
        {
            var clientes = new List<Clientes>(); //cria a lista vazia

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM clientes";//comando que quero executar no banco de dados

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();//Abre a conexao com o banco de dados

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())//Enquanto tiver dados percorre linha-a-linha
                        {
                            clientes.Add(new Clientes()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Email = linhas["email"].ToString(),
                                Cpf_Cnpj = linhas["cpf_cnpj"].ToString(),
                                TipoPessoa = linhas["tipo_pessoa"].ToString(),
                                Telefone = linhas["telefone"].ToString(),
                                Celular = linhas["celular"].ToString(),
                                Cep = linhas["cep"].ToString(),
                                endereco = linhas["endereco"].ToString(),
                                numero = linhas["numero"].ToString(),
                                complemento = linhas["complemento"].ToString(),
                                bairro = linhas["bairro"].ToString(),
                                cidade = linhas["cidade"].ToString(),
                                estado = linhas["estado"].ToString(),
                                ativo = Convert.ToBoolean(linhas["ativo"])
                            });   
                        }
                    }
                }
            }

                return clientes;
        }
    }
}
