using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPessoaFisicaJuridica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gerarGradeListViewPF();
            gerarGradeListViewPJ();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Organização de labels e text boxes
        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            labelCPF.Visible = true;
            labelCNPJ.Visible = false;
            labelQtdFilhos.Visible = true;
            labelQtdFuncionarios.Visible = false;
            labelSalario.Visible = true;
            labelFaturamento.Visible = false;
            labelNomeFantasia.Visible = false;
            txtbNomeFantasia.Visible=false;
            mtxtbCPF_CNPJ.Mask = "000,000,000-00";

        }
        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            labelCNPJ.Visible = true;
            labelCPF.Visible = false;
            labelQtdFuncionarios.Visible = true;
            labelQtdFilhos.Visible = false;
            labelFaturamento.Visible = true;
            labelSalario.Visible = false;
            labelNomeFantasia.Visible = true;
            txtbNomeFantasia.Visible = true;
            mtxtbCPF_CNPJ.Mask = "00,000,000/0000-00";
        }


        //Gerando as grades dos list view
        public void gerarGradeListViewPF()
        {
            listViewPF.Columns.Add("CPF", 150).TextAlign = HorizontalAlignment.Center;
            listViewPF.Columns.Add("Nome", 100).TextAlign = HorizontalAlignment.Center;
            listViewPF.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            listViewPF.Columns.Add("Qtd Filhos", 100).TextAlign = HorizontalAlignment.Center;
            listViewPF.Columns.Add("Salário M", 100).TextAlign = HorizontalAlignment.Center;
            listViewPF.Columns.Add("Crédito", 100).TextAlign= HorizontalAlignment.Center;
            listViewPF.View = View.Details;
        }

        public void gerarGradeListViewPJ()
        {
            listViewPJ.Columns.Add("CNPJ", 150).TextAlign = HorizontalAlignment.Center;
            listViewPJ.Columns.Add("Nome", 100).TextAlign = HorizontalAlignment.Center;
            listViewPJ.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            listViewPJ.Columns.Add("Qtd Funcionários", 100).TextAlign = HorizontalAlignment.Center;
            listViewPJ.Columns.Add("Faturamento", 100).TextAlign = HorizontalAlignment.Center;
            listViewPJ.Columns.Add("Crédito", 100).TextAlign = HorizontalAlignment.Center;
            listViewPJ.Columns.Add("Nome Fantasia", 150).TextAlign = HorizontalAlignment.Center;
            listViewPJ.View = View.Details;
        }

        private void listViewPF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Configuração do botão "Limpar"
        private void buttonLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            mtxtbCPF_CNPJ.Text = "";
            txtbNome.Text ="";
            txtbCidade.Text = "";
            txtbQtdFilhosFuncionarios.Text = "";
            txtbSalarioFaturamento.Text = "";
            txtbNomeFantasia.Text = "";
        }

        private void buttonCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbPessoaFisica.Checked)
            {
                MessageBox.Show("Cadastro Pessoa FÍSICA");

                //Criação de um objeto Pessoa Física
                PessoaFisica pf = new PessoaFisica(txtbNome.Text, txtbCidade.Text,mtxtbCPF_CNPJ.Text,
                                                   Convert.ToInt32(txtbQtdFilhosFuncionarios.Text), 
                                                   Convert.ToDouble(txtbSalarioFaturamento.Text));

                //Criação de array para armazenar os dados de pf
                string[] clientePF = new string[6];

                clientePF[0] = pf.Cpf;
                clientePF[1] = pf.Nome;
                clientePF[2] = pf.Cidade;
                clientePF[3] = Convert.ToString(pf.QtdFilhos);
                clientePF[4] = Convert.ToString(pf.Salario);
                clientePF[5] = Convert.ToString(pf.CalcCredito());

                //Inserção do array em uma nova linha do list view
                listViewPF.Items.Add(new ListViewItem(clientePF));

            }
            else if (rbPessoaJuridica.Checked)
            {
                MessageBox.Show("Cadastro Pessoa JURÍDICA");

                //Criação de um objeto Pessoa Jurídica
                PessoaJuridica pj = new PessoaJuridica(txtbNome.Text, txtbCidade.Text, mtxtbCPF_CNPJ.Text,
                                                   Convert.ToInt32(txtbQtdFilhosFuncionarios.Text),
                                                   Convert.ToDouble(txtbSalarioFaturamento.Text),
                                                   txtbNomeFantasia.Text);

                //Criação de array para armazenar os dados de pj
                string[] clientePJ = new string[7];

                clientePJ[0] = pj.Cnpj;
                clientePJ[1] = pj.Nome;
                clientePJ[2] = pj.Cidade;
                clientePJ[3] = Convert.ToString(pj.QtdFuncionarios);
                clientePJ[4] = Convert.ToString(pj.Faturamento);
                clientePJ[5] = Convert.ToString(pj.CalcCredito());
                clientePJ[6] = pj.NomeFantasia;

                //Inserção do array em uma nova linha do list view
                listViewPJ.Items.Add(new ListViewItem(clientePJ));
            }
            else
            {
                MessageBox.Show("SEM SELEÇÃO");
            }
        }
    }

}
