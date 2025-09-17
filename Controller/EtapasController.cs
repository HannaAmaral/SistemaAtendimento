using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class EtapaController
    {
        private FrmCadastroEtapa _frmCadastroEtapa;
        private EtapaRepository _etapaRepository;

        public EtapaController(FrmCadastroEtapa View)
        {
            _frmCadastroEtapa = View;
            _etapaRepository = new EtapaRepository();
        }   

        public void ListarEtapas()
        {
            try
            {
                var ListaEtapas = _etapaRepository.Listar();
                _frmCadastroEtapa.ExibirEtapas(ListaEtapas);
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao carregar as etapas: {ex.Message}");
            }
        }

        public void Salvar(Etapa etapa)
        {
            try
            {
                _etapaRepository.Inserir(etapa);
                _frmCadastroEtapa.ExibirMensagem("Etapa cadastrada com sucesso!");
                ListarEtapas();

                
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao cadastrar a etapa: {ex.Message}");
            }
        }
    }
}
