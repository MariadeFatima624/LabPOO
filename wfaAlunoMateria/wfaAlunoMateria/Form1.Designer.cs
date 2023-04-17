namespace wfaAlunoMateria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMateria = new System.Windows.Forms.TabPage();
            this.buttonCadastrarMateria = new System.Windows.Forms.Button();
            this.tbCodigoMateria = new System.Windows.Forms.TextBox();
            this.tbNomeMateria = new System.Windows.Forms.TextBox();
            this.labelCodigoMateria = new System.Windows.Forms.Label();
            this.labelNomeMateria = new System.Windows.Forms.Label();
            this.tabPageAluno = new System.Windows.Forms.TabPage();
            this.buttonCadastrarAluno = new System.Windows.Forms.Button();
            this.tbPeriodoAluno = new System.Windows.Forms.TextBox();
            this.tbNumMatriculaAluno = new System.Windows.Forms.TextBox();
            this.tbNomeAluno = new System.Windows.Forms.TextBox();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.labelNumeroMatricula = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.tabPageMatrícula = new System.Windows.Forms.TabPage();
            this.buttonCadastroAM = new System.Windows.Forms.Button();
            this.tbCodigomateriaCadastro = new System.Windows.Forms.TextBox();
            this.tbNomeMateriaCadastro = new System.Windows.Forms.TextBox();
            this.tbNumMatriculaCadastro = new System.Windows.Forms.TextBox();
            this.tbNomeAlunoCadastro = new System.Windows.Forms.TextBox();
            this.labelCodigoMateriaCadastro = new System.Windows.Forms.Label();
            this.labelNomeMateriaCadastro = new System.Windows.Forms.Label();
            this.labelNumMatriculaCadastro = new System.Windows.Forms.Label();
            this.labelAlunoCadastro = new System.Windows.Forms.Label();
            this.tabPageRelatório = new System.Windows.Forms.TabPage();
            this.buttonRelatorio = new System.Windows.Forms.Button();
            this.listViewAlunoRelatorio = new System.Windows.Forms.ListView();
            this.listViewMateriaRelatorio = new System.Windows.Forms.ListView();
            this.listViewPesquisaRelatorio = new System.Windows.Forms.ListView();
            this.tbMatriculaAlunoRelatorio = new System.Windows.Forms.TextBox();
            this.tbNomeAlunoRelatorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageMateria.SuspendLayout();
            this.tabPageAluno.SuspendLayout();
            this.tabPageMatrícula.SuspendLayout();
            this.tabPageRelatório.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMateria);
            this.tabControl1.Controls.Add(this.tabPageAluno);
            this.tabControl1.Controls.Add(this.tabPageMatrícula);
            this.tabControl1.Controls.Add(this.tabPageRelatório);
            this.tabControl1.Location = new System.Drawing.Point(38, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMateria
            // 
            this.tabPageMateria.Controls.Add(this.buttonCadastrarMateria);
            this.tabPageMateria.Controls.Add(this.tbCodigoMateria);
            this.tabPageMateria.Controls.Add(this.tbNomeMateria);
            this.tabPageMateria.Controls.Add(this.labelCodigoMateria);
            this.tabPageMateria.Controls.Add(this.labelNomeMateria);
            this.tabPageMateria.Location = new System.Drawing.Point(4, 22);
            this.tabPageMateria.Name = "tabPageMateria";
            this.tabPageMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMateria.Size = new System.Drawing.Size(670, 376);
            this.tabPageMateria.TabIndex = 0;
            this.tabPageMateria.Text = "Matéria";
            this.tabPageMateria.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarMateria
            // 
            this.buttonCadastrarMateria.Location = new System.Drawing.Point(425, 164);
            this.buttonCadastrarMateria.Name = "buttonCadastrarMateria";
            this.buttonCadastrarMateria.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarMateria.TabIndex = 10;
            this.buttonCadastrarMateria.Text = "Cadastrar";
            this.buttonCadastrarMateria.UseVisualStyleBackColor = true;
            this.buttonCadastrarMateria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCadastrarMateria_MouseClick);
            // 
            // tbCodigoMateria
            // 
            this.tbCodigoMateria.Location = new System.Drawing.Point(76, 69);
            this.tbCodigoMateria.Name = "tbCodigoMateria";
            this.tbCodigoMateria.Size = new System.Drawing.Size(424, 20);
            this.tbCodigoMateria.TabIndex = 3;
            // 
            // tbNomeMateria
            // 
            this.tbNomeMateria.Location = new System.Drawing.Point(77, 26);
            this.tbNomeMateria.Name = "tbNomeMateria";
            this.tbNomeMateria.Size = new System.Drawing.Size(424, 20);
            this.tbNomeMateria.TabIndex = 2;
            // 
            // labelCodigoMateria
            // 
            this.labelCodigoMateria.AutoSize = true;
            this.labelCodigoMateria.Location = new System.Drawing.Point(27, 72);
            this.labelCodigoMateria.Name = "labelCodigoMateria";
            this.labelCodigoMateria.Size = new System.Drawing.Size(43, 13);
            this.labelCodigoMateria.TabIndex = 1;
            this.labelCodigoMateria.Text = "Código:";
            // 
            // labelNomeMateria
            // 
            this.labelNomeMateria.AutoSize = true;
            this.labelNomeMateria.Location = new System.Drawing.Point(32, 26);
            this.labelNomeMateria.Name = "labelNomeMateria";
            this.labelNomeMateria.Size = new System.Drawing.Size(38, 13);
            this.labelNomeMateria.TabIndex = 0;
            this.labelNomeMateria.Text = "Nome:";
            // 
            // tabPageAluno
            // 
            this.tabPageAluno.Controls.Add(this.buttonCadastrarAluno);
            this.tabPageAluno.Controls.Add(this.tbPeriodoAluno);
            this.tabPageAluno.Controls.Add(this.tbNumMatriculaAluno);
            this.tabPageAluno.Controls.Add(this.tbNomeAluno);
            this.tabPageAluno.Controls.Add(this.labelPeriodo);
            this.tabPageAluno.Controls.Add(this.labelNumeroMatricula);
            this.tabPageAluno.Controls.Add(this.labelNome);
            this.tabPageAluno.Location = new System.Drawing.Point(4, 22);
            this.tabPageAluno.Name = "tabPageAluno";
            this.tabPageAluno.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAluno.Size = new System.Drawing.Size(670, 376);
            this.tabPageAluno.TabIndex = 1;
            this.tabPageAluno.Text = "Aluno";
            this.tabPageAluno.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarAluno
            // 
            this.buttonCadastrarAluno.Location = new System.Drawing.Point(479, 210);
            this.buttonCadastrarAluno.Name = "buttonCadastrarAluno";
            this.buttonCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarAluno.TabIndex = 10;
            this.buttonCadastrarAluno.Text = "Cadastrar";
            this.buttonCadastrarAluno.UseVisualStyleBackColor = true;
            this.buttonCadastrarAluno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCadastrarAluno_MouseClick);
            // 
            // tbPeriodoAluno
            // 
            this.tbPeriodoAluno.Location = new System.Drawing.Point(130, 125);
            this.tbPeriodoAluno.Name = "tbPeriodoAluno";
            this.tbPeriodoAluno.Size = new System.Drawing.Size(424, 20);
            this.tbPeriodoAluno.TabIndex = 6;
            // 
            // tbNumMatriculaAluno
            // 
            this.tbNumMatriculaAluno.Location = new System.Drawing.Point(130, 77);
            this.tbNumMatriculaAluno.Name = "tbNumMatriculaAluno";
            this.tbNumMatriculaAluno.Size = new System.Drawing.Size(424, 20);
            this.tbNumMatriculaAluno.TabIndex = 5;
            // 
            // tbNomeAluno
            // 
            this.tbNomeAluno.Location = new System.Drawing.Point(130, 33);
            this.tbNomeAluno.Name = "tbNomeAluno";
            this.tbNomeAluno.Size = new System.Drawing.Size(424, 20);
            this.tbNomeAluno.TabIndex = 4;
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Location = new System.Drawing.Point(76, 125);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(48, 13);
            this.labelPeriodo.TabIndex = 3;
            this.labelPeriodo.Text = "Período:";
            // 
            // labelNumeroMatricula
            // 
            this.labelNumeroMatricula.AutoSize = true;
            this.labelNumeroMatricula.Location = new System.Drawing.Point(15, 80);
            this.labelNumeroMatricula.Name = "labelNumeroMatricula";
            this.labelNumeroMatricula.Size = new System.Drawing.Size(109, 13);
            this.labelNumeroMatricula.TabIndex = 2;
            this.labelNumeroMatricula.Text = "Número de matrícula:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(86, 36);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // tabPageMatrícula
            // 
            this.tabPageMatrícula.Controls.Add(this.buttonCadastroAM);
            this.tabPageMatrícula.Controls.Add(this.tbCodigomateriaCadastro);
            this.tabPageMatrícula.Controls.Add(this.tbNomeMateriaCadastro);
            this.tabPageMatrícula.Controls.Add(this.tbNumMatriculaCadastro);
            this.tabPageMatrícula.Controls.Add(this.tbNomeAlunoCadastro);
            this.tabPageMatrícula.Controls.Add(this.labelCodigoMateriaCadastro);
            this.tabPageMatrícula.Controls.Add(this.labelNomeMateriaCadastro);
            this.tabPageMatrícula.Controls.Add(this.labelNumMatriculaCadastro);
            this.tabPageMatrícula.Controls.Add(this.labelAlunoCadastro);
            this.tabPageMatrícula.Location = new System.Drawing.Point(4, 22);
            this.tabPageMatrícula.Name = "tabPageMatrícula";
            this.tabPageMatrícula.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatrícula.Size = new System.Drawing.Size(670, 376);
            this.tabPageMatrícula.TabIndex = 2;
            this.tabPageMatrícula.Text = "Matrícula";
            this.tabPageMatrícula.UseVisualStyleBackColor = true;
            // 
            // buttonCadastroAM
            // 
            this.buttonCadastroAM.Location = new System.Drawing.Point(486, 211);
            this.buttonCadastroAM.Name = "buttonCadastroAM";
            this.buttonCadastroAM.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastroAM.TabIndex = 9;
            this.buttonCadastroAM.Text = "Cadastrar";
            this.buttonCadastroAM.UseVisualStyleBackColor = true;
            this.buttonCadastroAM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCadastroAM_MouseClick);
            // 
            // tbCodigomateriaCadastro
            // 
            this.tbCodigomateriaCadastro.Location = new System.Drawing.Point(137, 121);
            this.tbCodigomateriaCadastro.Name = "tbCodigomateriaCadastro";
            this.tbCodigomateriaCadastro.Size = new System.Drawing.Size(424, 20);
            this.tbCodigomateriaCadastro.TabIndex = 8;
            // 
            // tbNomeMateriaCadastro
            // 
            this.tbNomeMateriaCadastro.Location = new System.Drawing.Point(137, 91);
            this.tbNomeMateriaCadastro.Name = "tbNomeMateriaCadastro";
            this.tbNomeMateriaCadastro.Size = new System.Drawing.Size(424, 20);
            this.tbNomeMateriaCadastro.TabIndex = 7;
            // 
            // tbNumMatriculaCadastro
            // 
            this.tbNumMatriculaCadastro.Location = new System.Drawing.Point(137, 61);
            this.tbNumMatriculaCadastro.Name = "tbNumMatriculaCadastro";
            this.tbNumMatriculaCadastro.Size = new System.Drawing.Size(424, 20);
            this.tbNumMatriculaCadastro.TabIndex = 6;
            // 
            // tbNomeAlunoCadastro
            // 
            this.tbNomeAlunoCadastro.Location = new System.Drawing.Point(137, 31);
            this.tbNomeAlunoCadastro.Name = "tbNomeAlunoCadastro";
            this.tbNomeAlunoCadastro.Size = new System.Drawing.Size(424, 20);
            this.tbNomeAlunoCadastro.TabIndex = 5;
            // 
            // labelCodigoMateriaCadastro
            // 
            this.labelCodigoMateriaCadastro.AutoSize = true;
            this.labelCodigoMateriaCadastro.Location = new System.Drawing.Point(36, 124);
            this.labelCodigoMateriaCadastro.Name = "labelCodigoMateriaCadastro";
            this.labelCodigoMateriaCadastro.Size = new System.Drawing.Size(95, 13);
            this.labelCodigoMateriaCadastro.TabIndex = 4;
            this.labelCodigoMateriaCadastro.Text = "Código da matéria:";
            // 
            // labelNomeMateriaCadastro
            // 
            this.labelNomeMateriaCadastro.AutoSize = true;
            this.labelNomeMateriaCadastro.Location = new System.Drawing.Point(41, 94);
            this.labelNomeMateriaCadastro.Name = "labelNomeMateriaCadastro";
            this.labelNomeMateriaCadastro.Size = new System.Drawing.Size(90, 13);
            this.labelNomeMateriaCadastro.TabIndex = 3;
            this.labelNomeMateriaCadastro.Text = "Nome da matéria:";
            this.labelNomeMateriaCadastro.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelNumMatriculaCadastro
            // 
            this.labelNumMatriculaCadastro.AutoSize = true;
            this.labelNumMatriculaCadastro.Location = new System.Drawing.Point(22, 64);
            this.labelNumMatriculaCadastro.Name = "labelNumMatriculaCadastro";
            this.labelNumMatriculaCadastro.Size = new System.Drawing.Size(109, 13);
            this.labelNumMatriculaCadastro.TabIndex = 2;
            this.labelNumMatriculaCadastro.Text = "Número de matrícula:";
            this.labelNumMatriculaCadastro.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelAlunoCadastro
            // 
            this.labelAlunoCadastro.AutoSize = true;
            this.labelAlunoCadastro.Location = new System.Drawing.Point(35, 34);
            this.labelAlunoCadastro.Name = "labelAlunoCadastro";
            this.labelAlunoCadastro.Size = new System.Drawing.Size(96, 13);
            this.labelAlunoCadastro.TabIndex = 1;
            this.labelAlunoCadastro.Text = "Nome do discente:";
            // 
            // tabPageRelatório
            // 
            this.tabPageRelatório.Controls.Add(this.label4);
            this.tabPageRelatório.Controls.Add(this.label3);
            this.tabPageRelatório.Controls.Add(this.buttonRelatorio);
            this.tabPageRelatório.Controls.Add(this.listViewAlunoRelatorio);
            this.tabPageRelatório.Controls.Add(this.listViewMateriaRelatorio);
            this.tabPageRelatório.Controls.Add(this.listViewPesquisaRelatorio);
            this.tabPageRelatório.Controls.Add(this.tbMatriculaAlunoRelatorio);
            this.tabPageRelatório.Controls.Add(this.tbNomeAlunoRelatorio);
            this.tabPageRelatório.Controls.Add(this.label1);
            this.tabPageRelatório.Controls.Add(this.label2);
            this.tabPageRelatório.Location = new System.Drawing.Point(4, 22);
            this.tabPageRelatório.Name = "tabPageRelatório";
            this.tabPageRelatório.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRelatório.Size = new System.Drawing.Size(670, 376);
            this.tabPageRelatório.TabIndex = 3;
            this.tabPageRelatório.Text = "Relatório";
            this.tabPageRelatório.UseVisualStyleBackColor = true;
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.Location = new System.Drawing.Point(576, 38);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(75, 23);
            this.buttonRelatorio.TabIndex = 16;
            this.buttonRelatorio.Text = "Ok";
            this.buttonRelatorio.UseVisualStyleBackColor = true;
            this.buttonRelatorio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRelatorio_MouseClick);
            // 
            // listViewAlunoRelatorio
            // 
            this.listViewAlunoRelatorio.HideSelection = false;
            this.listViewAlunoRelatorio.Location = new System.Drawing.Point(25, 185);
            this.listViewAlunoRelatorio.Name = "listViewAlunoRelatorio";
            this.listViewAlunoRelatorio.Size = new System.Drawing.Size(626, 82);
            this.listViewAlunoRelatorio.TabIndex = 15;
            this.listViewAlunoRelatorio.UseCompatibleStateImageBehavior = false;
            // 
            // listViewMateriaRelatorio
            // 
            this.listViewMateriaRelatorio.HideSelection = false;
            this.listViewMateriaRelatorio.Location = new System.Drawing.Point(25, 298);
            this.listViewMateriaRelatorio.Name = "listViewMateriaRelatorio";
            this.listViewMateriaRelatorio.Size = new System.Drawing.Size(626, 72);
            this.listViewMateriaRelatorio.TabIndex = 14;
            this.listViewMateriaRelatorio.UseCompatibleStateImageBehavior = false;
            this.listViewMateriaRelatorio.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // listViewPesquisaRelatorio
            // 
            this.listViewPesquisaRelatorio.HideSelection = false;
            this.listViewPesquisaRelatorio.Location = new System.Drawing.Point(78, 94);
            this.listViewPesquisaRelatorio.Name = "listViewPesquisaRelatorio";
            this.listViewPesquisaRelatorio.Size = new System.Drawing.Size(536, 53);
            this.listViewPesquisaRelatorio.TabIndex = 12;
            this.listViewPesquisaRelatorio.UseCompatibleStateImageBehavior = false;
            // 
            // tbMatriculaAlunoRelatorio
            // 
            this.tbMatriculaAlunoRelatorio.Location = new System.Drawing.Point(137, 55);
            this.tbMatriculaAlunoRelatorio.Name = "tbMatriculaAlunoRelatorio";
            this.tbMatriculaAlunoRelatorio.Size = new System.Drawing.Size(424, 20);
            this.tbMatriculaAlunoRelatorio.TabIndex = 10;
            // 
            // tbNomeAlunoRelatorio
            // 
            this.tbNomeAlunoRelatorio.Location = new System.Drawing.Point(137, 25);
            this.tbNomeAlunoRelatorio.Name = "tbNomeAlunoRelatorio";
            this.tbNomeAlunoRelatorio.Size = new System.Drawing.Size(424, 20);
            this.tbNomeAlunoRelatorio.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número de matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome do discente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Alunos cadastrados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Matérias cadastradas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Matérias e alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMateria.ResumeLayout(false);
            this.tabPageMateria.PerformLayout();
            this.tabPageAluno.ResumeLayout(false);
            this.tabPageAluno.PerformLayout();
            this.tabPageMatrícula.ResumeLayout(false);
            this.tabPageMatrícula.PerformLayout();
            this.tabPageRelatório.ResumeLayout(false);
            this.tabPageRelatório.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMateria;
        private System.Windows.Forms.TextBox tbCodigoMateria;
        private System.Windows.Forms.TextBox tbNomeMateria;
        private System.Windows.Forms.Label labelCodigoMateria;
        private System.Windows.Forms.Label labelNomeMateria;
        private System.Windows.Forms.TabPage tabPageAluno;
        private System.Windows.Forms.TextBox tbPeriodoAluno;
        private System.Windows.Forms.TextBox tbNumMatriculaAluno;
        private System.Windows.Forms.TextBox tbNomeAluno;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.Label labelNumeroMatricula;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TabPage tabPageMatrícula;
        private System.Windows.Forms.Label labelCodigoMateriaCadastro;
        private System.Windows.Forms.Label labelNomeMateriaCadastro;
        private System.Windows.Forms.Label labelNumMatriculaCadastro;
        private System.Windows.Forms.Label labelAlunoCadastro;
        private System.Windows.Forms.TabPage tabPageRelatório;
        private System.Windows.Forms.TextBox tbCodigomateriaCadastro;
        private System.Windows.Forms.TextBox tbNomeMateriaCadastro;
        private System.Windows.Forms.TextBox tbNumMatriculaCadastro;
        private System.Windows.Forms.TextBox tbNomeAlunoCadastro;
        private System.Windows.Forms.TextBox tbMatriculaAlunoRelatorio;
        private System.Windows.Forms.TextBox tbNomeAlunoRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewMateriaRelatorio;
        private System.Windows.Forms.ListView listViewPesquisaRelatorio;
        private System.Windows.Forms.Button buttonCadastrarMateria;
        private System.Windows.Forms.Button buttonCadastrarAluno;
        private System.Windows.Forms.Button buttonCadastroAM;
        private System.Windows.Forms.Button buttonRelatorio;
        private System.Windows.Forms.ListView listViewAlunoRelatorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

