using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trabalho_Interdisciplinar.DAO;

namespace Trabalho_Interdisciplinar.Business
{
    public class AcessarArquivo
    {
        string _caminho;

        public AcessarArquivo(string Caminho)
        {
            this._caminho = Caminho;
        }

        /// <summary>
        /// Procura o nome em todas as linhas do arquivo.
        /// Para a procura no primeiro nome encontrado.
        /// </summary>
        /// <param name="Nome">Nome a ser procurado</param>
        /// <param name="Texto">Todo o texto do arquivo</param>
        /// <returns>Número da linha aonde o nome foi localizado</returns>
        private int ProcurarNome(string NomeAntigo, string NomeNovo, string Texto, out string NovaLinha)
        {
            int Posicao = 1;
            string[] aux;

            aux = Texto.Split(Environment.NewLine.ToCharArray());

            foreach (string s in aux)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    string[] aux2;
                    aux2 = s.Split(';');

                    if (aux2[0].ToLower().Trim() == NomeAntigo.ToLower().Trim())
                    {
                        NovaLinha = NomeNovo + ";" + aux2[1] + ";" + aux2[2];
                        return Posicao;
                    }
                    Posicao++;
                }
            }
            NovaLinha = "";
            return -1;
        }

        /// <summary>
        /// Procura o nome em todas as linhas do arquivo.
        /// Para a procura no primeiro nome encontrado.
        /// </summary>
        /// <param name="Nome">Nome a ser procurado</param>
        /// <param name="Texto">Todo o texto do arquivo</param>
        /// <returns>Número da linha aonde o nome foi localizado</returns>
        public bool ProcurarLogin(string Login, string Senha)
        {
            ConexaoArquivo conect = new ConexaoArquivo(_caminho);
            //int Posicao = 1;
            string ArquivoTodo = conect.LerTodasLinhas();
            string[] aux;

            aux = ArquivoTodo.Split(Environment.NewLine.ToCharArray());

            foreach (string s in aux)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    string[] aux2;
                    aux2 = s.Split(';');

                    if (aux2[0].ToLower().Trim() == Login.ToLower().Trim())
                    {
                        if (aux2[1].ToLower().Trim() == Senha.ToLower().Trim())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;

        }

        public bool TestarLogin(string Login)
        {
            ConexaoArquivo conect = new ConexaoArquivo(_caminho);
            //int Posicao = 1;
            string ArquivoTodo = conect.LerTodasLinhas();
            string[] aux;

            aux = ArquivoTodo.Split(Environment.NewLine.ToCharArray());

            foreach (string s in aux)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    string[] aux2;
                    aux2 = s.Split(';');

                    if (aux2[0].ToLower().Trim() == Login.ToLower().Trim())
                    {
                        
                            return true;
                        
                    }
                }
            }
            return false;

        }



        public void AtualizarNome(string NomeAntigo, string NomeNovo)
        {
            ConexaoArquivo arquivo = new ConexaoArquivo(_caminho);

            string NovaLinha;

            //Procura em qual linha existe o nome procurado.
            int Posicao = ProcurarNome(NomeAntigo, NomeNovo, arquivo.LerTodasLinhas(), out NovaLinha);

            arquivo.AtualizarLinha(NovaLinha, Posicao);

        }

       
         /*public void ApagarPessoa(Pessoa pessoa)
         {
             ConexaoArquivo arquivo = new ConexaoArquivo(_caminho);

             string texto = arquivo.LerTodasLinhas();
             string linha = pessoa.Nome + ";" + pessoa.Idade + ";" + pessoa.Sexo;

             int AondeComecaOTexto = texto.IndexOf(linha);

             texto = texto.Remove(AondeComecaOTexto, linha.Length + 1);

             arquivo.ZerarArquivo();

             arquivo.InserirLinhaNaUltimaPosicao(texto);

         }*/

        public void LimparArquivo()
        {
            ConexaoArquivo arquivo = new ConexaoArquivo(_caminho);

            arquivo.ZerarArquivo();
        }

        public void InserirUser(string Login, string Senha)
        {
            ConexaoArquivo conexao = new ConexaoArquivo(_caminho);
            string texto = Login + ";" + Senha;
            conexao.InserirLinhaNaUltimaPosicao(texto);
        }

        public string ProcurarPerguntas(string numero)
        {
            ConexaoArquivo conect = new ConexaoArquivo(_caminho);
            
            string ArquivoTodo = conect.LerTodasLinhas();
            string[] aux;

            aux = ArquivoTodo.Split(Environment.NewLine.ToCharArray());

            foreach (string s in aux)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    string[] aux2;
                    aux2 = s.Split(';');

                    if (aux2[0] == numero)
                    {
                        return aux2[1];
                    }
                }
            }
            return "";

        }

    }
}
