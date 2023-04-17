using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaAlunoMateria
{
    public partial class Form1 : Form
    {
        Materia[] materias = new Materia[30];
        int i = 0;

        aluno[] alunos = new aluno[30];
        int j = 0;

        int t = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrarMateria_MouseClick(object sender, MouseEventArgs e)
        {
            Materia m = new Materia(tbNomeMateria.Text, tbCodigoMateria.Text);
            materias[i] = m;
            MessageBox.Show("Matéria cadastrada com sucesso!");
            i++;

            string[] materiaM = new string[2];

            materiaM[0] = m.Nome;
            materiaM[1] = m.Codigo;

            listViewMateriaRelatorio.Items.Add(new ListViewItem(materiaM));
        }
        
        private void buttonCadastrarAluno_MouseClick(object sender, MouseEventArgs e)
        {
            aluno a = new aluno(tbNomeAluno.Text, tbNumMatriculaAluno.Text, 
                                    Convert.ToInt32(tbPeriodoAluno.Text));
            alunos[j]= a;
            MessageBox.Show("Aluno(a) cadastrado(a) com sucesso!");
            j++;

            string[] alunoA = new string[3];

            alunoA[0] = a.Nome;
            alunoA[1] = a.Numero_matricula;
            alunoA[2] = Convert.ToString(a.Periodo);

            listViewAlunoRelatorio.Items.Add(new ListViewItem(alunoA));
        }
        
        private void buttonCadastroAM_MouseClick(object sender, MouseEventArgs e)
        {
            int r = 0;
            for(int b =0; b<=i; b++)
            {
                if (tbNomeAlunoCadastro.Text == alunos[b].Nome 
                    && tbNumMatriculaCadastro.Text == alunos[b].Numero_matricula) {
                    for (int c = 0; c <= j; c++)
                    {
                        if (tbNomeMateriaCadastro.Text == materias[c].Nome &&
                            tbCodigomateriaCadastro.Text == materias[c].Codigo)
                        {
                            alunos[b].Lista_materias[r] = materias[c];
                            r++;
                        }
                    }
                }
            }
            
        }
        
        private void buttonRelatorio_MouseClick(object sender, MouseEventArgs e)
        {
            for (int b = 0; b <= i; b++)
            {
                if (tbNomeAlunoRelatorio.Text == alunos[b].Nome
                    && tbMatriculaAlunoRelatorio.Text == alunos[b].Numero_matricula)
                {
                    for (int c = 0; c <= 10; c++)
                    {
                        string[] materiaAluno = new string[2];

                        materiaAluno[0] = alunos[b].Lista_materias[c].Nome;
                        materiaAluno[1] = alunos[b].Lista_materias[c].Codigo;

                        listViewPesquisaRelatorio.Items.Add(new ListViewItem(materiaAluno));
                    }
                    
                }
            }

        }

        //Geração de grades dos list view
        public void GerarGradeListViewPesquisa()
        {
            listViewPesquisaRelatorio.Columns.Add("Nome da disciplina", 150).TextAlign = HorizontalAlignment.Center;
            listViewPesquisaRelatorio.Columns.Add("Código da disciplina", 150).TextAlign = HorizontalAlignment.Center;
            listViewPesquisaRelatorio.View = View.Details;
        }

        public void GerarGradeListViewAluno()
        {
            listViewAlunoRelatorio.Columns.Add("Nome do aluno",150).TextAlign= HorizontalAlignment.Center;
            listViewAlunoRelatorio.Columns.Add("Número de matrícula", 150).TextAlign = HorizontalAlignment.Center;
            listViewAlunoRelatorio.Columns.Add("Período", 150).TextAlign = HorizontalAlignment.Center;
            listViewAlunoRelatorio.View= View.Details;
        }

        public void GerarGradesListViewMaterias()
        {
            listViewMateriaRelatorio.Columns.Add("Nome da matéria", 150).TextAlign = HorizontalAlignment.Center;
            listViewMateriaRelatorio.Columns.Add("Código", 150).TextAlign = HorizontalAlignment.Center;
            listViewMateriaRelatorio.View = View.Details;

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
