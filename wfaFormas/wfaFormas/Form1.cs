using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaFormas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbFormas.Image = Properties.Resources.branco;
            ocultaPainel();
            GerarGradeListViewArea();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Oculta paineis
        public void ocultaPainel()
        {
            panelCirculo.Visible = false;
            panelQuadrado.Visible = false;
            panelRetangulo.Visible = false;
            panelTriangulo.Visible = false;
        }

        //Gerar grades do ListView de Áreas
        public void GerarGradeListViewArea()
        {
            listViewFormas.Columns.Add("Nome", 120).TextAlign = HorizontalAlignment.Center;
            listViewFormas.Columns.Add("Raio", 90).TextAlign = HorizontalAlignment.Center;
            listViewFormas.Columns.Add("Lado", 90).TextAlign = HorizontalAlignment.Center;
            listViewFormas.Columns.Add("Base", 90).TextAlign = HorizontalAlignment.Center;
            listViewFormas.Columns.Add("Altura", 90).TextAlign = HorizontalAlignment.Center;
            listViewFormas.Columns.Add("Área", 90).TextAlign = HorizontalAlignment.Center;
            listViewFormas.Columns.Add("Perímetro", 90).TextAlign = HorizontalAlignment.Center;
            listViewFormas.View = View.Details;
        }

        //Limpeza de campos
        public void limpar()
        {
            tbRaio.Text = string.Empty;
            tbLadoQ.Text = string.Empty;
            tbBaseR.Text = string.Empty;    
            tbAlturaR.Text = string.Empty;
            tbBaseT.Text = string.Empty;
            tbAlturaT.Text = string.Empty;
        }

        //Configuração dos radiobuttoms
        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            pbFormas.Image = Properties.Resources.circulo;
            ocultaPainel();
            limpar();
            panelCirculo.Visible = true;
        }

        private void rbQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            pbFormas.Image = Properties.Resources.quadrado;
            ocultaPainel();
            limpar();
            panelQuadrado.Visible = true;
        }

        private void rbRetangulo_CheckedChanged(object sender, EventArgs e)
        {
            pbFormas.Image = Properties.Resources.retangulo;
            ocultaPainel();
            limpar();
            panelRetangulo.Visible = true;
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            pbFormas.Image = Properties.Resources.triangulo;
            ocultaPainel();
            limpar();
            panelTriangulo.Visible = true;
        }

        //Message boxes
        public void MensagemTelaArea(Formas _forma)
        {
            MessageBox.Show("Área:" + _forma.calcArea(), this.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void MensagemTelaPerimetro(Formas _forma)
        {
            MessageBox.Show("Perímetro:" + _forma.calcPerimetro(), this.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        public void EscolhaUmaForma()
        {
            MessageBox.Show("Você deve selecionar uma forma!", this.Text, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //Configuração do botão Área
        private void buttonArea_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbCirculo.Checked)
            {
                Formas objFormas = new Circulo("Circulo", Convert.ToDouble(tbRaio.Text));

                string[] forma = new string[7];

                forma[0] = objFormas.Nome;
                forma[1] = tbRaio.Text;
                forma[5] = Convert.ToString(objFormas.calcArea());
                forma[6] = Convert.ToString(objFormas.calcPerimetro());

                MensagemTelaArea(objFormas);
                MensagemTelaPerimetro(objFormas);

                listViewFormas.Items.Add(new ListViewItem(forma));
            }
            else if(rbQuadrado.Checked)
            {
                Formas objFormas = new Quadrado("Quadrado", Convert.ToDouble(tbLadoQ.Text));

                string[] forma = new string[7];

                forma[0] = objFormas.Nome;
                forma[2] = tbLadoQ.Text;
                forma[5] = Convert.ToString(objFormas.calcArea());
                forma[6] = Convert.ToString(objFormas.calcPerimetro());

                MensagemTelaArea(objFormas);
                MensagemTelaPerimetro(objFormas);

                listViewFormas.Items.Add(new ListViewItem(forma));
            }
            else if (rbRetangulo.Checked)
            {
                Formas objFormas = new Retangulo("Retangulo", Convert.ToDouble(tbBaseR.Text), 
                                                Convert.ToDouble(tbAlturaR.Text));

                string[] forma = new string[7];

                forma[0] = objFormas.Nome;
                forma[3] = tbBaseR.Text;
                forma[4] = tbAlturaR.Text;
                forma[5] = Convert.ToString(objFormas.calcArea());
                forma[6] = Convert.ToString(objFormas.calcPerimetro());

                MensagemTelaArea(objFormas);
                MensagemTelaPerimetro(objFormas);

                listViewFormas.Items.Add(new ListViewItem(forma));
            }
            else if(rbTriangulo.Checked)
            {
                Formas objFormas = new Triangulo("Triangulo", Convert.ToDouble(tbBaseT.Text),
                                                Convert.ToDouble(tbAlturaT.Text));

                string[] forma = new string[7];

                forma[0] = objFormas.Nome;
                forma[3] = tbBaseT.Text;
                forma[4] = tbAlturaT.Text;
                forma[5] = Convert.ToString(objFormas.calcArea());

                MensagemTelaArea(objFormas);

                listViewFormas.Items.Add(new ListViewItem(forma));
            }

        }
    }
}
