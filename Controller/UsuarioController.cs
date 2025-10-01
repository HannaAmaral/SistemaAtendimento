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
    public class UsuarioController
    {
        private FrmCadastroUsuario _frmCadastroUsuario;
        private UsuarioRepository _usuarioRepository;
        public UsuarioController(FrmCadastroUsuario View)
        {
            _frmCadastroUsuario = View;
            _usuarioRepository = new UsuarioRepository();
        }

        public void ListarUsuarios()
        {
            try
            {
                var ListaUsuarios = _usuarioRepository.Listar();
                _frmCadastroUsuario.ExibirUsuarios(ListaUsuarios);
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao carregar os usuários: {ex.Message}");
            }
        }

        public void Salvar(Usuario usuarios)
        {
            try
            {
                _usuarioRepository.Inserir(usuarios);
                _frmCadastroUsuario.ExibirMensagem("Usuario cadastrado com sucesso!");
                ListarUsuarios();

                _frmCadastroUsuario.DesabilitarCampos(); // Desabilitar campos após salvar
                //Atualizar dados do grid
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao cadastrar o Usuario: {ex.Message}");
            }
        }

        public void Atualizar(Usuario usuario)
        {
            try
            {
                _usuarioRepository.Atualizar(usuario);
                _frmCadastroUsuario.ExibirMensagem("Usuario atualizado com sucesso!");
                ListarUsuarios();

                _frmCadastroUsuario.DesabilitarCampos(); // Desabilitar campos após salvar
                //Atualizar dados do grid
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao atualizar o : {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _usuarioRepository.Excluir(id);
                _frmCadastroUsuario.ExibirMensagem("Usuário excluído com sucesso!");
                ListarUsuarios();
            }
            catch (Exception ex)
            {
                _frmCadastroUsuario.ExibirMensagem($"Erro ao excluir o usuário: {ex.Message}");
            }
        }
    }  
}

