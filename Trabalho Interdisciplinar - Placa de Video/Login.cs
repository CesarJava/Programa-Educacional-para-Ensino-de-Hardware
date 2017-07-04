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
using Trabalho_Interdisciplinar.Modelo;

namespace Trabalho_Interdisciplinar___Placa_de_Video
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro Cadastro = new Cadastro();
            Cadastro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "")
            {
                String _caminho = Application.StartupPath.ToString();
                AcessarArquivo acesso = new AcessarArquivo(Path.Combine(_caminho,"Login.txt"));

                if (acesso.ProcurarLogin(txtLogin.Text, txtSenha.Text) == true)
                {
                    Menu Menu = new Menu();
                    Menu.Show();

                }
                else
                {
                    MessageBox.Show("Login ou senha incorreto");
                }
            }
            else
            {
                MessageBox.Show("Espaços estão em branco");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuizFacil janela = new QuizFacil();
            janela.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            QuizFacil form = new QuizFacil();
            form.Show();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            Controles var = new Controles();
            toolStripStatusLabel1.Text = var.CapsLock();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Controles var = new Controles();
            toolStripStatusLabel1.Text = var.CapsLock();

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            Controles var = new Controles();
            toolStripStatusLabel1.Text = var.CapsLock();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda form = new Ajuda();
            form.button2.Hide();
            form.Show();
            
        }
    }
}
