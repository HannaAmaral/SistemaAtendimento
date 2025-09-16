namespace SistemaAtendimento.View
{
    partial class FrmCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            grbListaUsuario = new GroupBox();
            dgvUsuario = new DataGridView();
            btnPesquisar = new Button();
            imlIcones = new ImageList(components);
            lblPesquisar = new Label();
            btnCancelar = new Button();
            txtPesquisar = new TextBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            grbDadosUsuario = new GroupBox();
            cbxPerfil = new ComboBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            lblPerfil = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            grbListaUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            grbDadosUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // grbListaUsuario
            // 
            grbListaUsuario.Controls.Add(dgvUsuario);
            grbListaUsuario.Location = new Point(8, 208);
            grbListaUsuario.Name = "grbListaUsuario";
            grbListaUsuario.Size = new Size(847, 240);
            grbListaUsuario.TabIndex = 46;
            grbListaUsuario.TabStop = false;
            grbListaUsuario.Text = "Lista de Usuários";
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Location = new Point(8, 16);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.Size = new Size(832, 216);
            dgvUsuario.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageIndex = 4;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(776, 168);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(72, 32);
            btnPesquisar.TabIndex = 44;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-editar.png");
            imlIcones.Images.SetKeyName(2, "icone-excluir.png");
            imlIcones.Images.SetKeyName(3, "icone-novo.png");
            imlIcones.Images.SetKeyName(4, "icone-pesquisar.png");
            imlIcones.Images.SetKeyName(5, "icone-salvar.png");
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(472, 160);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 45;
            lblPesquisar.Text = "Pesquisar";
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.TopLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(368, 168);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 32);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(472, 176);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(287, 23);
            txtPesquisar.TabIndex = 43;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.TopLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(272, 168);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(79, 32);
            btnExcluir.TabIndex = 41;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.TopLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(184, 168);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(71, 32);
            btnSalvar.TabIndex = 40;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.TopLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(96, 168);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(71, 32);
            btnEditar.TabIndex = 39;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(8, 168);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(71, 32);
            btnNovo.TabIndex = 38;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // grbDadosUsuario
            // 
            grbDadosUsuario.Controls.Add(cbxPerfil);
            grbDadosUsuario.Controls.Add(txtSenha);
            grbDadosUsuario.Controls.Add(lblSenha);
            grbDadosUsuario.Controls.Add(txtNome);
            grbDadosUsuario.Controls.Add(txtCodigo);
            grbDadosUsuario.Controls.Add(lblPerfil);
            grbDadosUsuario.Controls.Add(lblNome);
            grbDadosUsuario.Controls.Add(lblCodigo);
            grbDadosUsuario.Location = new Point(8, 8);
            grbDadosUsuario.Name = "grbDadosUsuario";
            grbDadosUsuario.Size = new Size(848, 144);
            grbDadosUsuario.TabIndex = 37;
            grbDadosUsuario.TabStop = false;
            grbDadosUsuario.Text = "Dados do Usuário";
            // 
            // cbxPerfil
            // 
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Location = new Point(328, 88);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(208, 23);
            cbxPerfil.TabIndex = 7;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(8, 88);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(296, 23);
            txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(8, 72);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(176, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(648, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(8, 32);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(152, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(328, 72);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 2;
            lblPerfil.Text = "Perfil";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(176, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(8, 16);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 454);
            Controls.Add(grbListaUsuario);
            Controls.Add(btnPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosUsuario);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro Usuario";
            Load += FrmCadastroUsuario_Load;
            grbListaUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            grbDadosUsuario.ResumeLayout(false);
            grbDadosUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbListaUsuario;
        private DataGridView dgvUsuario;
        private Button btnPesquisar;
        private Label lblPesquisar;
        private Button btnCancelar;
        private TextBox txtPesquisar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private GroupBox grbDadosUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label lblPerfil;
        private Label lblNome;
        private Label lblCodigo;
        private ComboBox cbxPerfil;
        private ImageList imlIcones;
    }
}