namespace wfaPessoaFisicaJuridica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelQtdFuncionarios = new System.Windows.Forms.Label();
            this.labelFaturamento = new System.Windows.Forms.Label();
            this.labelNomeFantasia = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbCidade = new System.Windows.Forms.TextBox();
            this.txtbQtdFilhosFuncionarios = new System.Windows.Forms.TextBox();
            this.txtbSalarioFaturamento = new System.Windows.Forms.TextBox();
            this.txtbNomeFantasia = new System.Windows.Forms.TextBox();
            this.mtxtbCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.listViewPF = new System.Windows.Forms.ListView();
            this.listViewPJ = new System.Windows.Forms.ListView();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.labelQtdFilhos = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(70, 12);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbPessoaFisica.TabIndex = 0;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(236, 12);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.Location = new System.Drawing.Point(86, 51);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(37, 13);
            this.labelCNPJ.TabIndex = 2;
            this.labelCNPJ.Text = "CNPJ:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(85, 93);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(80, 135);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(43, 13);
            this.labelCidade.TabIndex = 4;
            this.labelCidade.Text = "Cidade:";
            // 
            // labelQtdFuncionarios
            // 
            this.labelQtdFuncionarios.AutoSize = true;
            this.labelQtdFuncionarios.Location = new System.Drawing.Point(33, 177);
            this.labelQtdFuncionarios.Name = "labelQtdFuncionarios";
            this.labelQtdFuncionarios.Size = new System.Drawing.Size(90, 13);
            this.labelQtdFuncionarios.TabIndex = 5;
            this.labelQtdFuncionarios.Text = "Qtd Funcionários:";
            // 
            // labelFaturamento
            // 
            this.labelFaturamento.AutoSize = true;
            this.labelFaturamento.Location = new System.Drawing.Point(54, 219);
            this.labelFaturamento.Name = "labelFaturamento";
            this.labelFaturamento.Size = new System.Drawing.Size(69, 13);
            this.labelFaturamento.TabIndex = 6;
            this.labelFaturamento.Text = "Faturamento:";
            // 
            // labelNomeFantasia
            // 
            this.labelNomeFantasia.AutoSize = true;
            this.labelNomeFantasia.Location = new System.Drawing.Point(42, 261);
            this.labelNomeFantasia.Name = "labelNomeFantasia";
            this.labelNomeFantasia.Size = new System.Drawing.Size(81, 13);
            this.labelNomeFantasia.TabIndex = 7;
            this.labelNomeFantasia.Text = "Nome Fantasia:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(129, 90);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(605, 20);
            this.txtbNome.TabIndex = 8;
            // 
            // txtbCidade
            // 
            this.txtbCidade.Location = new System.Drawing.Point(129, 132);
            this.txtbCidade.Name = "txtbCidade";
            this.txtbCidade.Size = new System.Drawing.Size(605, 20);
            this.txtbCidade.TabIndex = 9;
            // 
            // txtbQtdFilhosFuncionarios
            // 
            this.txtbQtdFilhosFuncionarios.Location = new System.Drawing.Point(129, 174);
            this.txtbQtdFilhosFuncionarios.Name = "txtbQtdFilhosFuncionarios";
            this.txtbQtdFilhosFuncionarios.Size = new System.Drawing.Size(605, 20);
            this.txtbQtdFilhosFuncionarios.TabIndex = 10;
            // 
            // txtbSalarioFaturamento
            // 
            this.txtbSalarioFaturamento.Location = new System.Drawing.Point(129, 216);
            this.txtbSalarioFaturamento.Name = "txtbSalarioFaturamento";
            this.txtbSalarioFaturamento.Size = new System.Drawing.Size(605, 20);
            this.txtbSalarioFaturamento.TabIndex = 11;
            // 
            // txtbNomeFantasia
            // 
            this.txtbNomeFantasia.Location = new System.Drawing.Point(129, 258);
            this.txtbNomeFantasia.Name = "txtbNomeFantasia";
            this.txtbNomeFantasia.Size = new System.Drawing.Size(605, 20);
            this.txtbNomeFantasia.TabIndex = 12;
            // 
            // mtxtbCPF_CNPJ
            // 
            this.mtxtbCPF_CNPJ.Location = new System.Drawing.Point(129, 48);
            this.mtxtbCPF_CNPJ.Name = "mtxtbCPF_CNPJ";
            this.mtxtbCPF_CNPJ.Size = new System.Drawing.Size(605, 20);
            this.mtxtbCPF_CNPJ.TabIndex = 13;
            // 
            // listViewPF
            // 
            this.listViewPF.HideSelection = false;
            this.listViewPF.Location = new System.Drawing.Point(22, 356);
            this.listViewPF.Name = "listViewPF";
            this.listViewPF.Size = new System.Drawing.Size(772, 70);
            this.listViewPF.TabIndex = 14;
            this.listViewPF.UseCompatibleStateImageBehavior = false;
            this.listViewPF.SelectedIndexChanged += new System.EventHandler(this.listViewPF_SelectedIndexChanged);
            // 
            // listViewPJ
            // 
            this.listViewPJ.HideSelection = false;
            this.listViewPJ.Location = new System.Drawing.Point(22, 432);
            this.listViewPJ.Name = "listViewPJ";
            this.listViewPJ.Size = new System.Drawing.Size(772, 70);
            this.listViewPJ.TabIndex = 15;
            this.listViewPJ.UseCompatibleStateImageBehavior = false;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(294, 313);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 16;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCadastrar_MouseClick);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(438, 313);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 17;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonLimpar_MouseClick);
            // 
            // labelQtdFilhos
            // 
            this.labelQtdFilhos.AutoSize = true;
            this.labelQtdFilhos.Location = new System.Drawing.Point(66, 177);
            this.labelQtdFilhos.Name = "labelQtdFilhos";
            this.labelQtdFilhos.Size = new System.Drawing.Size(57, 13);
            this.labelQtdFilhos.TabIndex = 18;
            this.labelQtdFilhos.Text = "Qtd Filhos:";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(81, 219);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(42, 13);
            this.labelSalario.TabIndex = 19;
            this.labelSalario.Text = "Salário:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(93, 51);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(30, 13);
            this.labelCPF.TabIndex = 20;
            this.labelCPF.Text = "CPF:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 525);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelQtdFilhos);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.listViewPJ);
            this.Controls.Add(this.listViewPF);
            this.Controls.Add(this.mtxtbCPF_CNPJ);
            this.Controls.Add(this.txtbNomeFantasia);
            this.Controls.Add(this.txtbSalarioFaturamento);
            this.Controls.Add(this.txtbQtdFilhosFuncionarios);
            this.Controls.Add(this.txtbCidade);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.labelNomeFantasia);
            this.Controls.Add(this.labelFaturamento);
            this.Controls.Add(this.labelQtdFuncionarios);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelCNPJ);
            this.Controls.Add(this.rbPessoaJuridica);
            this.Controls.Add(this.rbPessoaFisica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.Label labelCNPJ;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelQtdFuncionarios;
        private System.Windows.Forms.Label labelFaturamento;
        private System.Windows.Forms.Label labelNomeFantasia;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbCidade;
        private System.Windows.Forms.TextBox txtbQtdFilhosFuncionarios;
        private System.Windows.Forms.TextBox txtbSalarioFaturamento;
        private System.Windows.Forms.TextBox txtbNomeFantasia;
        private System.Windows.Forms.MaskedTextBox mtxtbCPF_CNPJ;
        private System.Windows.Forms.ListView listViewPF;
        private System.Windows.Forms.ListView listViewPJ;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Label labelQtdFilhos;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label labelCPF;
    }
}

