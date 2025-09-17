using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;

namespace SistemaAtendimento.Controller
{
    public class ClienteController
    {
        private FrmCadastrosClientes  _frmCadastrosClientes;  // Referência ao formulário de cadastro de clientes
        private ClienteRepository _clienteRepository; // Repositório para operações de dados de clientes

        public ClienteController(FrmCadastrosClientes View) // Construtor recebe a view do formulário de clientes 
        {
            _frmCadastrosClientes = View; // Inicializa a referência da view
            _clienteRepository = new ClienteRepository(); // Inicializa o repositório de clientes
        }

        public void ListarClientes() // Método para listar clientes
        {
            try //o comando é executado, mas se der erro jogar para baixo
            {
                var ListarClientes = _clienteRepository.Listar();
                _frmCadastrosClientes.ExibirClientes(ListarClientes);  
            }
            catch (Exception ex) //se ocorrer erro vem pra aqui
            {
                _frmCadastrosClientes.ExibirMensagem($"Erro ao carregar os clientes: {ex.Message}");
            }


        
        }
        public void Salvar(Clientes cliente)
        {
            try
            {
                _clienteRepository.Inserir(cliente);
                _frmCadastrosClientes.ExibirMensagem("Cliente cadastrado com sucesso!");
                ListarClientes();

                _frmCadastrosClientes.DesabilitarCampos(); // Desabilitar campos após salvar
                //Atualizar dados do grid
            }
            catch (Exception ex)
            {
                _frmCadastrosClientes.ExibirMensagem($"Erro ao cadastrar o cliente: {ex.Message}");
            }
        }
    }   
}
