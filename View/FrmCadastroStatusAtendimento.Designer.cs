namespace SistemaAtendimento.View
{
    partial class FrmCadastroStatusAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroStatusAtendimento));
            grbListaSituacaoAtendimento = new GroupBox();
            dgvUsuario = new DataGridView();
            btnPesquisar = new Button();
            lblPesquisar = new Label();
            btnCancelar = new Button();
            txtPesquisar = new TextBox();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            grbSituacaoAtendimento = new GroupBox();
            pnlSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            txtOrdem = new TextBox();
            lblCor = new Label();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            lblNome = new Label();
            lblCodigo = new Label();
            imlIcones = new ImageList(components);
            grbListaSituacaoAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            grbSituacaoAtendimento.SuspendLayout();
            pnlSituacao.SuspendLayout();
            SuspendLayout();
            // 
            // grbListaSituacaoAtendimento
            // 
            grbListaSituacaoAtendimento.Controls.Add(dgvUsuario);
            grbListaSituacaoAtendimento.Location = new Point(11, 207);
            grbListaSituacaoAtendimento.Name = "grbListaSituacaoAtendimento";
            grbListaSituacaoAtendimento.Size = new Size(847, 240);
            grbListaSituacaoAtendimento.TabIndex = 66;
            grbListaSituacaoAtendimento.TabStop = false;
            grbListaSituacaoAtendimento.Text = "Lista de Situação do Atendimento";
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
            btnPesquisar.Location = new Point(779, 167);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(72, 32);
            btnPesquisar.TabIndex = 64;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(475, 159);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 65;
            lblPesquisar.Text = "Pesquisar";
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.TopLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(371, 168);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 32);
            btnCancelar.TabIndex = 62;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(475, 175);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(287, 23);
            txtPesquisar.TabIndex = 63;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.TopLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(275, 167);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(79, 32);
            btnExcluir.TabIndex = 61;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.TopLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(187, 167);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(71, 32);
            btnSalvar.TabIndex = 60;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleRight;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.TopLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(99, 167);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(71, 32);
            btnEditar.TabIndex = 59;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(11, 167);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(71, 32);
            btnNovo.TabIndex = 58;
            btnNovo.Text = "Novo";
            btnNovo.TextAlign = ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // grbSituacaoAtendimento
            // 
            grbSituacaoAtendimento.Controls.Add(pnlSituacao);
            grbSituacaoAtendimento.Controls.Add(lblSituacao);
            grbSituacaoAtendimento.Controls.Add(txtOrdem);
            grbSituacaoAtendimento.Controls.Add(lblCor);
            grbSituacaoAtendimento.Controls.Add(txtNome);
            grbSituacaoAtendimento.Controls.Add(txtCodigo);
            grbSituacaoAtendimento.Controls.Add(lblNome);
            grbSituacaoAtendimento.Controls.Add(lblCodigo);
            grbSituacaoAtendimento.Location = new Point(11, 7);
            grbSituacaoAtendimento.Name = "grbSituacaoAtendimento";
            grbSituacaoAtendimento.Size = new Size(848, 144);
            grbSituacaoAtendimento.TabIndex = 57;
            grbSituacaoAtendimento.TabStop = false;
            grbSituacaoAtendimento.Text = "Situação do Atendimento";
            // 
            // pnlSituacao
            // 
            pnlSituacao.Controls.Add(rdbInativo);
            pnlSituacao.Controls.Add(rdbAtivo);
            pnlSituacao.Location = new Point(320, 80);
            pnlSituacao.Name = "pnlSituacao";
            pnlSituacao.Size = new Size(128, 32);
            pnlSituacao.TabIndex = 30;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(64, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 3;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 2;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(320, 64);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 31;
            lblSituacao.Text = "Situação";
            // 
            // txtOrdem
            // 
            txtOrdem.Location = new Point(8, 88);
            txtOrdem.Name = "txtOrdem";
            txtOrdem.Size = new Size(296, 23);
            txtOrdem.TabIndex = 3;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(8, 72);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 6;
            lblCor.Text = "Cor";
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
            // FrmCadastroStatusAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 454);
            Controls.Add(grbListaSituacaoAtendimento);
            Controls.Add(btnPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(txtPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbSituacaoAtendimento);
            Name = "FrmCadastroStatusAtendimento";
            Text = "Cadastro Status Atendimento";
            grbListaSituacaoAtendimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            grbSituacaoAtendimento.ResumeLayout(false);
            grbSituacaoAtendimento.PerformLayout();
            pnlSituacao.ResumeLayout(false);
            pnlSituacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbListaSituacaoAtendimento;
        private DataGridView dgvUsuario;
        private Button btnPesquisar;
        private Label lblPesquisar;
        private Button btnCancelar;
        private TextBox txtPesquisar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private GroupBox grbSituacaoAtendimento;
        private Panel pnlSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblSituacao;
        private TextBox txtOrdem;
        private Label lblCor;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label lblNome;
        private Label lblCodigo;
        private ImageList imlIcones;
    }
}