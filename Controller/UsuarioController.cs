using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }  
}

