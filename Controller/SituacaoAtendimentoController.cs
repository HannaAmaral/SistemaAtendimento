using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class SituacaoAtendimentoController
    {
        private FrmCadastroStatusAtendimento _frmCadastroSituacaoAtendimento;
        private SituacaoAtendimentoRepository _situacaoAtendimentoRepository;

        public SituacaoAtendimentoController(FrmCadastroStatusAtendimento View)
        {
            _frmCadastroSituacaoAtendimento = View;
            _situacaoAtendimentoRepository = new SituacaoAtendimentoRepository();
        }

        public void ListarSituacaoAtendimento()
        {
            try
            {
                var ListaSituacaoAtendimento = _situacaoAtendimentoRepository.Listar();
                _frmCadastroSituacaoAtendimento.ExibirSituacaoAtendimento(ListaSituacaoAtendimento);
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao carregar as situações de atendimento: {ex.Message}");
            }
        }
    }
}
