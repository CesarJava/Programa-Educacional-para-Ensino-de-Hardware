using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Trabalho_Interdisciplinar___Placa_de_Video
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();
        }
        String _caminho = Application.StartupPath.ToString();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Para ter acesso ao menu, é necessário obter um login e senha. Se já tiver um, insira nos campos como mostra a imagem e clique em 'entrar' Caso não tenha, saiba mais sobre se cadastrar";
            pictureBox1.ImageLocation = Path.Combine(_caminho, "Print/Login.bmp");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Caso não tenha ainda seu próprio login e senha, clique no link 'Ainda não é cadastrado?Clique Aqui' abaixo na tela de Login. Para o cadastro é necessário preencher todos os campos nele contido. Há como verificar se o login que você digitou está disponível. Preencha uma senha e a confirme.Caso sua senha não seja segura, o programa avisará com imagens ao lado direito na tela. Para o término do cadastro clique em 'Cadastrar', após isso o programa voltará automaticamente à tela de login.";
            pictureBox1.ImageLocation = Path.Combine(_caminho, "Print/Cadastro.bmp");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "No menu principal há várias opções, são elas: - Quiz - Créditos - Extras -Deslogar Ao clicar na opção que deseja abrirá uma nova tela.";
            pictureBox1.ImageLocation = Path.Combine(_caminho, "Print/Menu.bmp");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Serão lançados 5 perguntas de múltipla escolha, cujo nível de dificuldade varia de fácil a difícil. Em todos os momentos do quiz o usuário poderá retornar ao menu principal, clicando no botão 'Voltar ao menu', encerrará o jogo e zerará a pontuação. Caso o usuário prossiga, ao fim do quiz, cairá em uma janela onde saberá sua pontuação.";
            pictureBox1.ImageLocation = Path.Combine(_caminho, "Print/Quiz.bmp");
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "É o espaço onde estão as informações técnicas do produto e os dados de seus criadores.";
            pictureBox1.ImageLocation = Path.Combine(_caminho, "Print/Creditos.bmp");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Cruzadinha: Complete os espaços em branco com letras que formam as palavras de acordo com as dicas que estão no canto esquerdo da página. Após preencher todos os espaços, clique em 'verificar' e aparecerá em vermelho as letras que errou, e em verde as que acertou.";
            pictureBox1.ImageLocation = Path.Combine(_caminho, "Print/Cruzadinha.bmp");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Ao apertar este botão o usuário se deslogará do programa, ou seja, voltará à tela de login e só poderá voltar a usar o software se acessar o login novamente";
            pictureBox1.ImageLocation = Path.Combine(_caminho, "Print/Deslogar.bmp");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
