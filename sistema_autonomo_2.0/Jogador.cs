using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;

namespace sistema_autonomo_2._0
{
    class Jogador
    {
        int id;
        string nome;
        int pontuacao;

        char status;
        int rodada;
        char faseAtual;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Pontuacao
        {
            get { return pontuacao; }
            set { pontuacao = value; }
        }

        public char Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Rodada
        {
            get { return rodada; }
            set { rodada = value; }
        }

        public char FaseAtual
        {
            get { return faseAtual; }
            set { faseAtual = value; }
        }

        public static (int idJogador, string senhaJogador) EntrarPartida(int idPartida, string nomeJogador, string senhaPartida)
        {
            string retorno = Jogo.Entrar(idPartida, nomeJogador, senhaPartida);
            string[] dados = retorno.Split(',');

            int idJogador = Convert.ToInt32(dados[0]);
            string senhaJogador = dados[1];

            return (idJogador, senhaJogador);
        }

        //public static string ColocarPersonagem(int idJogador, string senhaJogador, int setor, string personagem)
        //{
        //    string retorno = Jogo.ColocarPersonagem(idJogador, senhaJogador, setor, personagem);
        //    retorno = retorno.Replace("\r", "");
        //    string[] status = retorno.Split('\n');

        //    for(int i = 0; i < status.Length; i++)
        //    {
        //        string[] dados = status[i].Split(',');
        //        if(dados.Length > 2)
        //        {
        //            // informações do tabuleiro
        //            // criar classe tabuleiro
        //        }
        //    }
        //}
    }
}
