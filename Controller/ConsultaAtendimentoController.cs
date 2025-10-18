using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;

namespace SistemaAtendimento.Controller
{
    internal class ConsultaAtendimentoController
    {
        private FrmConsultaAtendimento _frmconsultaAtendimento;
        private AtendimentoRepository _atendimentoRepository;

        public ConsultaAtendimentoController(FrmConsultaAtendimento view)
        {
            _frmconsultaAtendimento = view;
            _atendimentoRepository = new AtendimentoRepository();
        }

        public void ListarAtendimento(string termo = "", string condicao = "")
        {
            try
            {
                 var listarClientes = _atendimentoRepository.Listar(termo, condicao);
                _frmconsultaAtendimento.ExibirAtendimento(listarClientes);
            }
            catch (Exception ex)
            {
                _frmconsultaAtendimento.ExibirMensagem($"Erro ao listar atendimentos: {ex.Message}");
            }
        }
    }
}

