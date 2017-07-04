using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Trabalho_Interdisciplinar.DAO
{
    public class ConexaoArquivo
    {
        string _caminho;
        /// <summary>
        /// Recebe o caminho de um arquivo e abre o mesmo.
        /// Se não existir cria.
        /// </summary>
        /// <param name="caminho">Caminho e nome do arquivo a ser trabalhado.</param>
        public ConexaoArquivo(string caminho)
        {
            this._caminho = caminho;
        }

        /// <summary>
        /// Apagar o arquivo
        /// </summary>
        public void ApagarArquivo()
        {
            if(File.Exists(this._caminho))
                File.Delete(_caminho);
        }

        /// <summary>
        /// Não apaga o arquivo, mas limpa todo o seu conteúdo.
        /// </summary>
        public void ZerarArquivo()
        {
            if(File.Exists(this._caminho))
                using (Stream stream = new FileStream(_caminho, FileMode.Truncate))
                {

                }
        }

        /// <summary>
        /// Atualiza uma linha em uma determinada posição.
        /// </summary>
        /// <param name="texto">Texto a ser inserido</param>
        /// <param name="posicao">Número da linha na qual se deve incluir o texto</param>
        public void AtualizarLinha(string texto, int posicao)
        {
            StringBuilder auxiliar = new StringBuilder();
            int Posicao = 1;

            using (Stream stream = new FileStream(_caminho, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        if (!string.IsNullOrEmpty(s))
                        {
                            if (Posicao != posicao)
                                auxiliar.AppendLine(s);
                            else
                            {
                                auxiliar.AppendLine(texto);
                            }
                            Posicao++;
                        }
                    }
                }
            }

            using (Stream stream = new FileStream(_caminho, FileMode.Truncate))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(auxiliar);
                }
            }

        }

        /// <summary>
        /// Insere um texto na última linha do arquivo
        /// </summary>
        /// <param name="texto">Texto a ser inserido no final do arquivo</param>
        public void InserirLinhaNaUltimaPosicao(string texto)
        {
            using (Stream stream = new FileStream(_caminho, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(texto);
                }
            }
        }

        /// <summary>
        /// Ler uma determinada linha do arquivo
        /// </summary>
        /// <param name="numeroLinha">Número da linha a ser lida.</param>
        /// <returns>A linha lida</returns>
        public string LerLinha(int numeroLinha)
        {
            int Posicao = 0;
            using (Stream stream = new FileStream(_caminho, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        if (Posicao == numeroLinha)
                            return reader.ReadLine();

                        Posicao++;
                    }
                }
            }
            return "";
        }

        /// <summary>
        /// Ler todas as linhas do arquivo
        /// </summary>
        /// <returns></returns>
        public string LerTodasLinhas()
        {
            using (Stream stream = new FileStream(_caminho, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }

       } 




    }
}
