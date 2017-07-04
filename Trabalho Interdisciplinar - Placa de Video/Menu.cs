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

namespace Trabalho_Interdisciplinar___Placa_de_Video
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuizFacil form = new QuizFacil();
            form.Show();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void jogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void deslogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            String _caminho = Application.StartupPath.ToString();
            AcessarArquivo acesso = new AcessarArquivo(Path.Combine(_caminho, "Login.txt"));
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teoria teoria = new Teoria();
            teoria.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Creditos creditos = new Creditos();
            creditos.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            NiveisQuiz form = new NiveisQuiz();
            form.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Ajuda form = new Ajuda();
            form.button1.Hide();
            form.Show();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Teoria form = new Teoria();
            form.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Creditos form = new Creditos();
            form.Show();
        }

        private void cruzadinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cruzada form = new Cruzada();
            form.Show();
        }
    }
}
