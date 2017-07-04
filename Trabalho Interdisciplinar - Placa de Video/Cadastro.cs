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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtSenha1.Text != "" && txtSenha2.Text != "")
            {

                if (txtSenha1.Text == txtSenha2.Text)
                {
                    String _caminho = Application.StartupPath.ToString();
                    AcessarArquivo acesso = new AcessarArquivo(Path.Combine(_caminho, "Login.txt"));


                    if (acesso.ProcurarLogin(txtLogin.Text, txtSenha1.Text) == false)
                    {
                        acesso.InserirUser(txtLogin.Text, txtSenha1.Text);
                        MessageBox.Show("Parabéns. Cadastro Efetuado");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Não é possível cadastrar usuário. Erro: login já existente.");
                    }
                }

                if (txtSenha1.Text != txtSenha2.Text)
                {
                    MessageBox.Show("Senhas não batem");
                }
            }
            MessageBox.Show("Preencha os campos vazios");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String _caminho = Application.StartupPath.ToString();
            AcessarArquivo acesso = new AcessarArquivo(Path.Combine(_caminho, "Login.txt"));

            

            if (acesso.TestarLogin(txtLogin.Text) == false)
            {
                lbllogin.Text = "Login Disponível";
                lbllogin.ForeColor = Color.Green;
            }
            if (acesso.TestarLogin(txtLogin.Text) == true)
            {
                lbllogin.Text = "Login Indisponível";
                lbllogin.ForeColor = Color.Red;
            }

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            Controles var = new Controles();
            toolStripStatusLabel1.Text = var.CapsLock();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha1_TextChanged(object sender, EventArgs e)
        {
            Controles var = new Controles();
            toolStripStatusLabel1.Text = var.CapsLock();
            String _caminho = Application.StartupPath.ToString();

            string texto = txtSenha1.Text.Trim();
            int quant = texto.Length;

            if ((quant >= 6)&&(txtSenha1.Text != txtLogin.Text))
            {
                string caminho = Path.Combine(_caminho, "Trabalho/SenhaForte.png");
                pictureBox1.ImageLocation = caminho;
            }
            else
            {
                string caminho = Path.Combine(_caminho, "Trabalho/SenhaFraca.png");
                pictureBox1.ImageLocation = caminho;
            }

        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            Controles var = new Controles();
            toolStripStatusLabel1.Text = var.CapsLock();

           
        }

        private void txtSenha2_TextChanged(object sender, EventArgs e)
        {
            Controles var = new Controles();
            toolStripStatusLabel1.Text = var.CapsLock();
        }
    }
}
