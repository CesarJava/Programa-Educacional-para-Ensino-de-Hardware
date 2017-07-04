using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trabalho_Interdisciplinar.Business;
using System.IO;
using Trabalho_Interdisciplinar.DAO;

namespace Trabalho_Interdisciplinar___Placa_de_Video
{
    public partial class QuizDificil : Form
    {
        public QuizDificil()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rbtnAlternativaA.Show();
            rbtnAlternativaB.Show();
            rbtnAlternativaC.Show();
            button3.Hide();
            button1.Hide();
            Random num = new Random();
            int x = num.Next(1, 10);

            String _caminho = Application.StartupPath.ToString();


            AcessarArquivo pergunta = new AcessarArquivo(Path.Combine(_caminho, "Dificil/perguntasdificeis.txt"));
            lblPergunta.Text = pergunta.ProcurarPerguntas(x.ToString());

            AcessarArquivo alternativaA = new AcessarArquivo(Path.Combine(_caminho, "Dificil/alternativasAdificeis.txt"));
            lblAlternativaA.Text = alternativaA.ProcurarPerguntas(x.ToString());

            AcessarArquivo alternativaB = new AcessarArquivo(Path.Combine(_caminho, "Dificil/alternativasBdificeis.txt"));
            lblAlternativaB.Text = alternativaB.ProcurarPerguntas(x.ToString());

            AcessarArquivo alternativaC = new AcessarArquivo(Path.Combine(_caminho, "Dificil/alternativasCdificeis.txt"));
            lblAlternativaC.Text = alternativaC.ProcurarPerguntas(x.ToString());

            AcessarArquivo resposta = new AcessarArquivo(Path.Combine(_caminho, "Dificil/respostasdificeis.txt"));
            string resp = resposta.ProcurarPerguntas(x.ToString());
            label6.Text = resp;

            label1.Text = "1";

        }

        private void QuizDificil_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Hide();
            label2.Text = "";
            label2.Hide();
            label3.Text = "";
            label3.Hide();
            label4.Text = "";
            label4.Hide();
            label5.Text = "";
            label5.Hide();
            rbtnAlternativaA.Hide();
            rbtnAlternativaB.Hide();
            rbtnAlternativaC.Hide();
            label6.Hide();
            lblPontuacao.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Show();


            string var = label6.Text;
            //verifica se as respostas estão corretas
            if (rbtnAlternativaA.Checked && label6.Text == "A")
            {
                int contador = Convert.ToInt16(lblPontuacao.Text) + 1;
                lblPontuacao.Text = contador.ToString();
                lblAlternativaA.ForeColor = Color.Green;
            }

            if (rbtnAlternativaB.Checked && label6.Text == "B")
            {
                int contador = Convert.ToInt16(lblPontuacao.Text) + 1;
                lblPontuacao.Text = contador.ToString();
                lblAlternativaB.ForeColor = Color.Green;
            }

            if (rbtnAlternativaC.Checked && label6.Text == "C")
            {
                int contador = Convert.ToInt16(lblPontuacao.Text) + 1;
                lblPontuacao.Text = contador.ToString();
                lblAlternativaC.ForeColor = Color.Green;
            }

            //verifica se as respostas estão erradas
            if (var == "A" && rbtnAlternativaA.Checked == false)
            {
                lblAlternativaA.ForeColor = Color.Red;
            }

            if (var == "B" && rbtnAlternativaB.Checked == false)
            {
                lblAlternativaB.ForeColor = Color.Red;
            }
            if (var == "C" && rbtnAlternativaC.Checked == false)
            {
                lblAlternativaC.ForeColor = Color.Red;
            }

            label6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            lblAlternativaA.ForeColor = Color.Black;
            lblAlternativaB.ForeColor = Color.Black;
            lblAlternativaC.ForeColor = Color.Black;

            Random num = new Random();
            int x = num.Next(1, 10);
            if ((x.ToString() == label1.Text) || (x.ToString() == label2.Text) || (x.ToString() == label3.Text) || (x.ToString() == label4.Text) || (x.ToString() == label5.Text))
            {
                while ((x.ToString() == label1.Text) || (x.ToString() == label2.Text) || (x.ToString() == label3.Text) || (x.ToString() == label4.Text) || (x.ToString() == label5.Text))
                {
                    x = num.Next(1, 10);
                }
            }


            String _caminho = Application.StartupPath.ToString();

            AcessarArquivo pergunta = new AcessarArquivo(Path.Combine(_caminho, "Dificil/perguntasdificeis.txt"));
            lblPergunta.Text = pergunta.ProcurarPerguntas(x.ToString());

            AcessarArquivo alternativaA = new AcessarArquivo(Path.Combine(_caminho, "Dificil/alternativasAdificeis.txt"));
            lblAlternativaA.Text = alternativaA.ProcurarPerguntas(x.ToString());

            AcessarArquivo alternativaB = new AcessarArquivo(Path.Combine(_caminho, "Dificil/alternativasBdificeis.txt"));
            lblAlternativaB.Text = alternativaB.ProcurarPerguntas(x.ToString());

            AcessarArquivo alternativaC = new AcessarArquivo(Path.Combine(_caminho, "Dificil/alternativasCdificeis.txt"));
            lblAlternativaC.Text = alternativaC.ProcurarPerguntas(x.ToString());

            AcessarArquivo resposta = new AcessarArquivo(Path.Combine(_caminho, "Dificil/respostasdificeis.txt"));
            string resp = resposta.ProcurarPerguntas(x.ToString());
            label6.Text = resp;




            if (label1.Text == "")
            {
                label1.Text = x.ToString();
            }
            else
            {
                if (label2.Text == "")
                {
                    label2.Text = x.ToString();
                }

                else
                {
                    if (label3.Text == "")
                    {
                        label3.Text = x.ToString();
                    }

                    else
                    {
                        if (label4.Text == "")
                        {
                            label4.Text = x.ToString();
                        }

                        else
                        {
                            if (label5.Text == "")
                            {
                                label5.Text = x.ToString();
                            }

                            else
                            {
                                if (lblPontuacao.Text == "")
                                {
                                    lblPontuacao.Text = "0";
                                }

                                lblAlternativaA.Text = "";
                                lblAlternativaB.Text = "";
                                lblAlternativaC.Text = "";
                                lblPergunta.Text = "";

                                MessageBox.Show("FIM DE JOGO");

                                ConexaoArquivo ob = new ConexaoArquivo(Path.Combine(_caminho, "contadori.txt"));

                                ob.InserirLinhaNaUltimaPosicao(lblPontuacao.Text);

                                Pontuacao form = new Pontuacao();
                                form.Show();
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
    }
}
