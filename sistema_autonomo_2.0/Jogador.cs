using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;
using static System.Windows.Forms.LinkLabel;

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

        public static List<Tabuleiro> ColocarPersonagem(int idJogador, string senhaJogador, int setor, string personagem)
        {
            string retorno = Jogo.ColocarPersonagem(idJogador, senhaJogador, setor, personagem);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] status = retorno.Split('\n');
            List<Tabuleiro> setorPersonagem = new List<Tabuleiro>();

            for (int i = 0; i < status.Length; i++)
            {
                string[] dados = status[i].Split(',');

                Tabuleiro t = new Tabuleiro();

                int.TryParse(dados[0], out int novoSetor);
                t.Setor = novoSetor;
                t.Personagem = dados[1];

                setorPersonagem.Add(t);
            }

            return setorPersonagem;
        }

        public static List<Tabuleiro> PromoverPersonagem(int idJogador, string senhaJogador, string personagem)
        {
            string retorno = Jogo.Promover(idJogador, senhaJogador, personagem);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] status = retorno.Split('\n');
            List<Tabuleiro> promoPersonagem = new List<Tabuleiro>();

            for (int i = 0; i < status.Length; i++)
            {
                string[] dados = status[i].Split(',');

                Tabuleiro t = new Tabuleiro();

                int.TryParse(dados[0], out int novoSetor);
                t.Setor = novoSetor;
                t.Personagem = dados[1];

                promoPersonagem.Add(t);
            }

            return promoPersonagem;
        }

    }
}
