using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trabalho_Interdisciplinar.Business;
using Trabalho_Interdisciplinar.DAO;
using System.IO;

namespace Trabalho_Interdisciplinar___Placa_de_Video
{
    public partial class Pontuacao : Form
    {
        public Pontuacao()
        {
            InitializeComponent();
        }

        private void Pontuacao_Load(object sender, EventArgs e)
        {
            String _caminho = Application.StartupPath.ToString();

            ConexaoArquivo ob = new ConexaoArquivo(Path.Combine(_caminho,"contadori.txt"));
            int pont = Convert.ToInt16( ob.LerLinha(1));
            label1.Text = "Sua Pontuação foi: " + ob.LerLinha(1);

            if (pont >= 3)
            {
                pictureBox1.ImageLocation = Path.Combine(_caminho, "Trabalho/Venceu.png");
                lblmensagem.Text = "Parabéns, Continue assim!";
            }
            
            if (pont < 3)
            {
                pictureBox1.ImageLocation = Path.Combine(_caminho, "Trabalho/Perdeu.png");
                lblmensagem.Text = "Não foi desta vez!";
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String _caminho = Application.StartupPath.ToString();

           ConexaoArquivo ob = new ConexaoArquivo(Path.Combine(_caminho,"contadori.txt"));
           ob.ZerarArquivo();
           this.Close();

        }
    }
}
