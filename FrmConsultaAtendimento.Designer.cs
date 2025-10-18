namespace SistemaAtendimento
{
    partial class FrmConsultaAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaAtendimento));
            imageList1 = new ImageList(components);
            grbFiltro = new GroupBox();
            cbxFiltro = new ComboBox();
            btnPesquisar = new Button();
            txtFiltro = new TextBox();
            dgvConsultaAtendimento = new DataGridView();
            grbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-pesquisar.png");
            // 
            // grbFiltro
            // 
            grbFiltro.Controls.Add(cbxFiltro);
            grbFiltro.Controls.Add(btnPesquisar);
            grbFiltro.Controls.Add(txtFiltro);
            grbFiltro.Controls.Add(dgvConsultaAtendimento);
            grbFiltro.Location = new Point(8, 8);
            grbFiltro.Name = "grbFiltro";
            grbFiltro.Size = new Size(784, 456);
            grbFiltro.TabIndex = 5;
            grbFiltro.TabStop = false;
            grbFiltro.Text = "Filtrar por:";
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Código do Atendimento", "Nome", "CPF", "CNPJ" });
            cbxFiltro.Location = new Point(8, 24);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(168, 23);
            cbxFiltro.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.ImageIndex = 0;
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(648, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(112, 32);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "         Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(208, 24);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(408, 23);
            txtFiltro.TabIndex = 6;
            // 
            // dgvConsultaAtendimento
            // 
            dgvConsultaAtendimento.Location = new Point(8, 64);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.Size = new Size(768, 384);
            dgvConsultaAtendimento.TabIndex = 5;
            dgvConsultaAtendimento.CellContentClick += dgvConsultaAtendimento_CellContentClick;
            // 
            // FrmConsultaAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(grbFiltro);
            Name = "FrmConsultaAtendimento";
            Text = "Consulta de Atendimento";
            Load += FrmConsultaAtendimento_Load;
            grbFiltro.ResumeLayout(false);
            grbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblPesquisar;
        private TextBox textBox1;
        private Button button1;
        private ImageList imageList1;
        private GroupBox grbFiltro;
        private ComboBox cbxFiltro;
        private Button btnPesquisar;
        private TextBox txtFiltro;
        private DataGridView dgvConsultaAtendimento;
    }
}