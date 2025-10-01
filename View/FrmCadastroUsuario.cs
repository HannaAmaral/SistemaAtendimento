using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmCadastroUsuario : Form
    {
        private UsuarioController _usuarioController;
        public FrmCadastroUsuario()
        {
            InitializeComponent();
            _usuarioController = new UsuarioController(this);
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            _usuarioController.ListarUsuarios();
        }

        public void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        public void ExibirUsuarios(List<Usuario> usuarios)
        {
            dgvUsuario.DataSource = usuarios;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Perfil = cbxPerfil.Text,
            };
            if (!ValidarDados(usuario))
                return;

            if (string.IsNullOrEmpty(txtCodigo.Text))
                _usuarioController.Salvar(usuario);
            else
            {
                usuario.Id = Convert.ToInt32(txtCodigo.Text);
                _usuarioController.Atualizar(usuario);
            }
        }
        public bool ValidarDados(Usuario usuarios)
        {
            if (string.IsNullOrEmpty(usuarios.Nome))
            {
                ExibirMensagem("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(usuarios.Email))
            {
                ExibirMensagem("O campo Email é obrigatório.");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(usuarios.Senha))
            {
                ExibirMensagem("O campo Senha é obrigatório.");
                txtSenha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(usuarios.Perfil))
            {
                ExibirMensagem("O campo Perfil é obrigatório.");
                cbxPerfil.Focus();
                return false;
            }
            return true;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                ExibirMensagem("Selecione um Cliente");
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja excluir este Cliente?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                _usuarioController.Excluir(id);
            }
        }



        private void dgvUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DataGridView LinhaSelecionada = dgvUsuario.Rows[e.RowIndex];

                //txtCodigo.Text = LinhaSelecionada.Cells["Id"].Value.ToString();
                //txtNome.Text = LinhaSelecionada.Cells["Nome"].Value.ToString();
                //txtEmail.Text = LinhaSelecionada.Cells["Email"].Value.ToString();
                //txtSenha.Text = LinhaSelecionada.Cells["Senha"].Value.ToString();
                //cbxPerfil.Text = LinhaSelecionada.Cells["Perfil"].Value.ToString();

                //btnEditar.Enabled = true;
                //btnExcluir.Enabled = true;
                //btnNovo.Enabled = false;
                //btnCancelar.Enabled = true;
            }
        }

        private void HabilitarCampos()
        {
            txtCodigo.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtSenha.ReadOnly = false;
            cbxPerfil.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            cbxPerfil.SelectedIndex = -1;
        }

        public void DesabilitarCampos()
        {
            LimparCampos();
            txtCodigo.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtSenha.ReadOnly = true;
            cbxPerfil.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}
