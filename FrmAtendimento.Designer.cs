namespace SistemaAtendimento
{
    partial class FrmAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtendimento));
            lblAtendimento = new Label();
            txtCodigoAtendimento = new TextBox();
            grbDadosCliente = new GroupBox();
            btnFinalizarAtendimento = new Button();
            imageList1 = new ImageList(components);
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            txtObservacoesAtendimento = new TextBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            lblObservacoesCliente = new Label();
            lblSituacaoAtendimento = new Label();
            dtpAbertura = new DateTimePicker();
            lblDataAbertura = new Label();
            lblNome = new Label();
            lblCodigoCliente = new Label();
            cbxSituacaoAtendimento = new ComboBox();
            cbxNomeCliente = new ComboBox();
            txtCodigoCliente = new TextBox();
            grbEtapaAtendimento = new GroupBox();
            dgvEtapaAtendimento = new DataGridView();
            btnAdicionarEtapa = new Button();
            btnExcluirEtapa = new Button();
            txtObservacoesEtapa = new TextBox();
            lblObservacoesEtapa = new Label();
            lblEtapaAtendimento = new Label();
            cbxEtapaAtendimento = new ComboBox();
            btnPesquisarAtendimento = new Button();
            grbDadosCliente.SuspendLayout();
            grbEtapaAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapaAtendimento).BeginInit();
            SuspendLayout();
            // 
            // lblAtendimento
            // 
            lblAtendimento.AutoSize = true;
            lblAtendimento.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAtendimento.Location = new Point(552, 24);
            lblAtendimento.Name = "lblAtendimento";
            lblAtendimento.Size = new Size(115, 21);
            lblAtendimento.TabIndex = 0;
            lblAtendimento.Text = "Atendimento:";
            // 
            // txtCodigoAtendimento
            // 
            txtCodigoAtendimento.Font = new Font("Segoe UI", 12F);
            txtCodigoAtendimento.Location = new Point(672, 16);
            txtCodigoAtendimento.Name = "txtCodigoAtendimento";
            txtCodigoAtendimento.Size = new Size(104, 29);
            txtCodigoAtendimento.TabIndex = 1;
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(btnFinalizarAtendimento);
            grbDadosCliente.Controls.Add(btnCancelar);
            grbDadosCliente.Controls.Add(btnExcluir);
            grbDadosCliente.Controls.Add(btnEditar);
            grbDadosCliente.Controls.Add(txtObservacoesAtendimento);
            grbDadosCliente.Controls.Add(btnNovo);
            grbDadosCliente.Controls.Add(btnSalvar);
            grbDadosCliente.Controls.Add(lblObservacoesCliente);
            grbDadosCliente.Controls.Add(lblSituacaoAtendimento);
            grbDadosCliente.Controls.Add(dtpAbertura);
            grbDadosCliente.Controls.Add(lblDataAbertura);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(lblCodigoCliente);
            grbDadosCliente.Controls.Add(cbxSituacaoAtendimento);
            grbDadosCliente.Controls.Add(cbxNomeCliente);
            grbDadosCliente.Controls.Add(txtCodigoCliente);
            grbDadosCliente.Location = new Point(8, 48);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(784, 264);
            grbDadosCliente.TabIndex = 2;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente";
            // 
            // btnFinalizarAtendimento
            // 
            btnFinalizarAtendimento.Enabled = false;
            btnFinalizarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizarAtendimento.ImageIndex = 6;
            btnFinalizarAtendimento.ImageList = imageList1;
            btnFinalizarAtendimento.Location = new Point(600, 216);
            btnFinalizarAtendimento.Name = "btnFinalizarAtendimento";
            btnFinalizarAtendimento.Size = new Size(168, 32);
            btnFinalizarAtendimento.TabIndex = 20;
            btnFinalizarAtendimento.Text = "          Finalizar Atendimento";
            btnFinalizarAtendimento.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-cancelar.png");
            imageList1.Images.SetKeyName(1, "icone-editar.png");
            imageList1.Images.SetKeyName(2, "icone-excluir.png");
            imageList1.Images.SetKeyName(3, "icone-novo.png");
            imageList1.Images.SetKeyName(4, "icone-pesquisar.png");
            imageList1.Images.SetKeyName(5, "icone-salvar.png");
            imageList1.Images.SetKeyName(6, "finalizar.png");
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(424, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 32);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "       Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(320, 216);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 32);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "         Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(112, 216);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 32);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "       Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtObservacoesAtendimento
            // 
            txtObservacoesAtendimento.Location = new Point(240, 104);
            txtObservacoesAtendimento.Multiline = true;
            txtObservacoesAtendimento.Name = "txtObservacoesAtendimento";
            txtObservacoesAtendimento.Size = new Size(528, 96);
            txtObservacoesAtendimento.TabIndex = 16;
            // 
            // btnNovo
            // 
            btnNovo.Enabled = false;
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(8, 216);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 32);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "      Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(216, 216);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 32);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "       Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblObservacoesCliente
            // 
            lblObservacoesCliente.AutoSize = true;
            lblObservacoesCliente.Location = new Point(240, 88);
            lblObservacoesCliente.Name = "lblObservacoesCliente";
            lblObservacoesCliente.Size = new Size(74, 15);
            lblObservacoesCliente.TabIndex = 13;
            lblObservacoesCliente.Text = "Observações";
            // 
            // lblSituacaoAtendimento
            // 
            lblSituacaoAtendimento.AutoSize = true;
            lblSituacaoAtendimento.Location = new Point(8, 88);
            lblSituacaoAtendimento.Name = "lblSituacaoAtendimento";
            lblSituacaoAtendimento.Size = new Size(142, 15);
            lblSituacaoAtendimento.TabIndex = 9;
            lblSituacaoAtendimento.Text = "Situação do Atendimento";
            // 
            // dtpAbertura
            // 
            dtpAbertura.Location = new Point(560, 40);
            dtpAbertura.Name = "dtpAbertura";
            dtpAbertura.Size = new Size(208, 23);
            dtpAbertura.TabIndex = 8;
            // 
            // lblDataAbertura
            // 
            lblDataAbertura.AutoSize = true;
            lblDataAbertura.Location = new Point(560, 24);
            lblDataAbertura.Name = "lblDataAbertura";
            lblDataAbertura.Size = new Size(80, 15);
            lblDataAbertura.TabIndex = 7;
            lblDataAbertura.Text = "Data Abertura";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(112, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(8, 24);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(72, 15);
            lblCodigoCliente.TabIndex = 5;
            lblCodigoCliente.Text = "Cód. Cliente";
            // 
            // cbxSituacaoAtendimento
            // 
            cbxSituacaoAtendimento.FormattingEnabled = true;
            cbxSituacaoAtendimento.Location = new Point(8, 104);
            cbxSituacaoAtendimento.Name = "cbxSituacaoAtendimento";
            cbxSituacaoAtendimento.Size = new Size(208, 23);
            cbxSituacaoAtendimento.TabIndex = 3;
            // 
            // cbxNomeCliente
            // 
            cbxNomeCliente.FormattingEnabled = true;
            cbxNomeCliente.Location = new Point(112, 40);
            cbxNomeCliente.Name = "cbxNomeCliente";
            cbxNomeCliente.Size = new Size(424, 23);
            cbxNomeCliente.TabIndex = 1;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(8, 40);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(88, 23);
            txtCodigoCliente.TabIndex = 0;
            // 
            // grbEtapaAtendimento
            // 
            grbEtapaAtendimento.Controls.Add(dgvEtapaAtendimento);
            grbEtapaAtendimento.Controls.Add(btnAdicionarEtapa);
            grbEtapaAtendimento.Controls.Add(btnExcluirEtapa);
            grbEtapaAtendimento.Controls.Add(txtObservacoesEtapa);
            grbEtapaAtendimento.Controls.Add(lblObservacoesEtapa);
            grbEtapaAtendimento.Controls.Add(lblEtapaAtendimento);
            grbEtapaAtendimento.Controls.Add(cbxEtapaAtendimento);
            grbEtapaAtendimento.Location = new Point(8, 336);
            grbEtapaAtendimento.Name = "grbEtapaAtendimento";
            grbEtapaAtendimento.Size = new Size(784, 296);
            grbEtapaAtendimento.TabIndex = 3;
            grbEtapaAtendimento.TabStop = false;
            grbEtapaAtendimento.Text = "Etapa do Atendimento";
            // 
            // dgvEtapaAtendimento
            // 
            dgvEtapaAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapaAtendimento.Location = new Point(320, 24);
            dgvEtapaAtendimento.Name = "dgvEtapaAtendimento";
            dgvEtapaAtendimento.Size = new Size(440, 256);
            dgvEtapaAtendimento.TabIndex = 20;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageIndex = 3;
            btnAdicionarEtapa.ImageList = imageList1;
            btnAdicionarEtapa.Location = new Point(8, 248);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(136, 32);
            btnAdicionarEtapa.TabIndex = 19;
            btnAdicionarEtapa.Text = "      Adicionar Etapa";
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.Enabled = false;
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageIndex = 0;
            btnExcluirEtapa.ImageList = imageList1;
            btnExcluirEtapa.Location = new Point(168, 248);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.Size = new Size(136, 32);
            btnExcluirEtapa.TabIndex = 18;
            btnExcluirEtapa.Text = "      Excluir Etapa";
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // txtObservacoesEtapa
            // 
            txtObservacoesEtapa.Location = new Point(8, 112);
            txtObservacoesEtapa.Multiline = true;
            txtObservacoesEtapa.Name = "txtObservacoesEtapa";
            txtObservacoesEtapa.Size = new Size(296, 128);
            txtObservacoesEtapa.TabIndex = 17;
            // 
            // lblObservacoesEtapa
            // 
            lblObservacoesEtapa.AutoSize = true;
            lblObservacoesEtapa.Location = new Point(8, 96);
            lblObservacoesEtapa.Name = "lblObservacoesEtapa";
            lblObservacoesEtapa.Size = new Size(74, 15);
            lblObservacoesEtapa.TabIndex = 12;
            lblObservacoesEtapa.Text = "Observações";
            // 
            // lblEtapaAtendimento
            // 
            lblEtapaAtendimento.AutoSize = true;
            lblEtapaAtendimento.Location = new Point(8, 32);
            lblEtapaAtendimento.Name = "lblEtapaAtendimento";
            lblEtapaAtendimento.Size = new Size(126, 15);
            lblEtapaAtendimento.TabIndex = 11;
            lblEtapaAtendimento.Text = "Etapa do Atendimento";
            // 
            // cbxEtapaAtendimento
            // 
            cbxEtapaAtendimento.FormattingEnabled = true;
            cbxEtapaAtendimento.Location = new Point(8, 48);
            cbxEtapaAtendimento.Name = "cbxEtapaAtendimento";
            cbxEtapaAtendimento.Size = new Size(296, 23);
            cbxEtapaAtendimento.TabIndex = 10;
            // 
            // btnPesquisarAtendimento
            // 
            btnPesquisarAtendimento.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisarAtendimento.ImageIndex = 4;
            btnPesquisarAtendimento.ImageList = imageList1;
            btnPesquisarAtendimento.Location = new Point(8, 8);
            btnPesquisarAtendimento.Name = "btnPesquisarAtendimento";
            btnPesquisarAtendimento.Size = new Size(176, 32);
            btnPesquisarAtendimento.TabIndex = 17;
            btnPesquisarAtendimento.Text = "         Pesquisar Atendimento";
            btnPesquisarAtendimento.UseVisualStyleBackColor = true;
            btnPesquisarAtendimento.Click += btnPesquisarAtendimento_Click;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 638);
            Controls.Add(btnPesquisarAtendimento);
            Controls.Add(grbEtapaAtendimento);
            Controls.Add(grbDadosCliente);
            Controls.Add(txtCodigoAtendimento);
            Controls.Add(lblAtendimento);
            Name = "FrmAtendimento";
            Text = "Atendimento";
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            grbEtapaAtendimento.ResumeLayout(false);
            grbEtapaAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapaAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAtendimento;
        private TextBox txtCodigoAtendimento;
        private GroupBox grbDadosCliente;
        private Label lblCodigoCliente;
        private ComboBox cbxSituacaoAtendimento;
        private ComboBox cbxNomeCliente;
        private TextBox txtCodigoCliente;
        private Label lblSituacaoAtendimento;
        private DateTimePicker dtpAbertura;
        private Label lblDataAbertura;
        private Label lblNome;
        private ImageList imageList1;
        private Button btnSalvar;
        private Label lblObservacoesCliente;
        private GroupBox grbEtapaAtendimento;
        private Label lblObservacoesEtapa;
        private Label lblEtapaAtendimento;
        private ComboBox cbxEtapaAtendimento;
        private Button btnNovo;
        private TextBox txtObservacoesAtendimento;
        private Button btnAdicionarEtapa;
        private Button btnExcluirEtapa;
        private TextBox txtObservacoesEtapa;
        private DataGridView dgvEtapaAtendimento;
        private Button btnPesquisarAtendimento;
        private Button btnFinalizarAtendimento;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnEditar;
    }
}