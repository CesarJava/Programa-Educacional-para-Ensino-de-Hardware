using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_Interdisciplinar___Placa_de_Video
{
    public partial class Teoria : Form
    {
        public Teoria()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void lnkintroducao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            ConteudoIntrodução oque = new ConteudoIntrodução();
            oque.Show();
        }

        private void lnkoque_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            ConteudoOqueéPlacadeVideo oque = new ConteudoOqueéPlacadeVideo();
            oque.Show();
        }

        private void lnkínformacoes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            InformacoesBasicasdeumaplacadevideo informacoes = new InformacoesBasicasdeumaplacadevideo();
            informacoes.Show();
        }

        private void lnkon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            ConteudoOqueéPlacadeVideo oque = new ConteudoOqueéPlacadeVideo();
            oque.Show();
        }

        private void lnkoff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            PlacadevideoOffBoard off = new PlacadevideoOffBoard();
            off.Show();
        }

        private void lnkplacadevideo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Processadorememoriadeumaplacadevideo placadevide = new Processadorememoriadeumaplacadevideo();
            placadevide.Show();
        }
    }
}
