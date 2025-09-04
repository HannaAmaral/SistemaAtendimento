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
    public class EtapaRepository
    {
        public List<Etapa> Listar()
        {
            var etapa = new List<Etapa>();

            using (var conexao = ConexaoDB.GetConexao())
            {
                string sql = "SELECT * FROM etapas";

                using (var comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();

                    using (var linhas = comando.ExecuteReader())
                    {
                        while (linhas.Read())
                        {
                            etapa.Add(new Etapa()
                            {
                                Id = Convert.ToInt32(linhas["id"]),
                                Nome = linhas["nome"].ToString(),
                                Ordem = Convert.ToInt32(linhas["ordem"]),
                                Ativo = Convert.ToBoolean(linhas["ativo"])
                            });
                        }
                    }
                }

                return etapa;
            }
        }
    }
}
