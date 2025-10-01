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

                _frmCadastroEtapa.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao cadastrar a etapa: {ex.Message}");
            }
        }

        public void Atualizar(Etapa etapa)
        {
            try
            {
                _etapaRepository.Atualizar(etapa);
                _frmCadastroEtapa.ExibirMensagem("Etapa cadastrada com sucesso!");
                ListarEtapas();

                _frmCadastroEtapa.DesabilitarCampos(); // Desabilitar campos após salvar
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao cadastrar a etapa: {ex.Message}");
            }
        }
        public void Excluir(int id)
        {
            try
            {
                _etapaRepository.Excluir(id);
                _frmCadastroEtapa.ExibirMensagem("Etapa excluída com sucesso!");
                ListarEtapas();
                _frmCadastroEtapa.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao excluir a Etapa: {ex.Message}");
            }
        }
    }
}
