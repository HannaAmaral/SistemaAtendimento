namespace SistemaAtendimento
{
    partial class FrmSistemaAtedimento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MnuCadastrosClientes = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            usuárioToolStripMenuItem = new ToolStripMenuItem();
            etapasToolStripMenuItem = new ToolStripMenuItem();
            statusAtendimentosToolStripMenuItem = new ToolStripMenuItem();
            atendimentosToolStripMenuItem = new ToolStripMenuItem();
            novoAtendimentoToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnConexao = new Button();
            MnuCadastrosClientes.SuspendLayout();
            SuspendLayout();
            // 
            // MnuCadastrosClientes
            // 
            MnuCadastrosClientes.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, atendimentosToolStripMenuItem, sistemaToolStripMenuItem });
            MnuCadastrosClientes.Location = new Point(0, 0);
            MnuCadastrosClientes.Name = "MnuCadastrosClientes";
            MnuCadastrosClientes.Size = new Size(799, 24);
            MnuCadastrosClientes.TabIndex = 0;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, usuárioToolStripMenuItem, etapasToolStripMenuItem, statusAtendimentosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(184, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // usuárioToolStripMenuItem
            // 
            usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            usuárioToolStripMenuItem.Size = new Size(184, 22);
            usuárioToolStripMenuItem.Text = "Usuário";
            usuárioToolStripMenuItem.Click += usuárioToolStripMenuItem_Click;
            // 
            // etapasToolStripMenuItem
            // 
            etapasToolStripMenuItem.Name = "etapasToolStripMenuItem";
            etapasToolStripMenuItem.Size = new Size(184, 22);
            etapasToolStripMenuItem.Text = "Etapas";
            etapasToolStripMenuItem.Click += etapasToolStripMenuItem_Click;
            // 
            // statusAtendimentosToolStripMenuItem
            // 
            statusAtendimentosToolStripMenuItem.Name = "statusAtendimentosToolStripMenuItem";
            statusAtendimentosToolStripMenuItem.Size = new Size(184, 22);
            statusAtendimentosToolStripMenuItem.Text = "Status Atendimentos";
            statusAtendimentosToolStripMenuItem.Click += statusAtendimentosToolStripMenuItem_Click;
            // 
            // atendimentosToolStripMenuItem
            // 
            atendimentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAtendimentoToolStripMenuItem, consultasToolStripMenuItem });
            atendimentosToolStripMenuItem.Name = "atendimentosToolStripMenuItem";
            atendimentosToolStripMenuItem.Size = new Size(94, 20);
            atendimentosToolStripMenuItem.Text = "Atendimentos";
            // 
            // novoAtendimentoToolStripMenuItem
            // 
            novoAtendimentoToolStripMenuItem.Name = "novoAtendimentoToolStripMenuItem";
            novoAtendimentoToolStripMenuItem.Size = new Size(176, 22);
            novoAtendimentoToolStripMenuItem.Text = "Novo Atendimento";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(176, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // btnConexao
            // 
            btnConexao.Location = new Point(632, 408);
            btnConexao.Name = "btnConexao";
            btnConexao.Size = new Size(144, 24);
            btnConexao.TabIndex = 1;
            btnConexao.Text = "Teste Conexão";
            btnConexao.UseVisualStyleBackColor = true;
            btnConexao.Click += btnConexao_Click;
            // 
            // FrmSistemaAtedimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 455);
            Controls.Add(btnConexao);
            Controls.Add(MnuCadastrosClientes);
            MainMenuStrip = MnuCadastrosClientes;
            Name = "FrmSistemaAtedimento";
            Text = "Sistema de Atendimento";
            MnuCadastrosClientes.ResumeLayout(false);
            MnuCadastrosClientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MnuCadastrosClientes;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem etapasToolStripMenuItem;
        private ToolStripMenuItem statusAtendimentosToolStripMenuItem;
        private ToolStripMenuItem atendimentosToolStripMenuItem;
        private ToolStripMenuItem novoAtendimentoToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnConexao;
    }
}
