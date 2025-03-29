using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;

namespace sistema_autonomo_2._0
{
    class Partida
    {
        int id;
        string senha;
        string nome;
        DateTime data;
        char status;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Senha
        {
            //get { return senha; }
            set { senha = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Data
        {
            get { return data; }
        }

        public char Status
        {
            get { return status; }
            set { status = value; }
        }

        public static List<Partida> ListarPartida()
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');
            List<Partida> listaPartidas = new List<Partida>();

            for (int i = 0; i < partidas.Length; i++)
            {
                string partida = partidas[i];
                string[] dados = partida.Split(',');

                Partida p = new Partida();
                p.id = Convert.ToInt32(dados[0]);
                p.nome = dados[1];
                p.data = Convert.ToDateTime(dados[2]);
                p.status = Convert.ToChar(dados[3]);

                listaPartidas.Add(p);
            }

            return listaPartidas;
        }

        public static List<Jogador> ListarJogador(int idPartida)
        {
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] jogadores = retorno.Split('\n');
            List<Jogador> listaJogadores = new List<Jogador>();

            for(int i = 0; i < jogadores.Length; i++)
            {
                string jogador = jogadores[i];
                string[] dados = jogador.Split(',');

                Jogador j = new Jogador();
                j.Id = Convert.ToInt32(dados[0]);
                j.Nome = dados[1];
                j.Pontuacao = Convert.ToInt32(dados[2]);

                listaJogadores.Add(j);
            }

            return listaJogadores;
        }

        public static int CriarPartida(string nomePartida, string senha, string nomeGrupo)
        {
            string retorno = Jogo.CriarPartida(nomePartida, senha, nomeGrupo);
            retorno = retorno.Replace("\r", "");
            string[] dados = retorno.Split(',');

            int idPartidaCriada = Convert.ToInt32(dados[0]);

            return idPartidaCriada;
        }
       
        public static int IniciarPartida(int idJogador, string senhaJogador)
        {
            string retorno = Jogo.Iniciar(idJogador, senhaJogador);
            retorno = retorno.Replace("\r", "");
            string[] dados = retorno.Split(',');

            int jogadorInicial = Convert.ToInt32(dados[0]);

            return jogadorInicial;
        }

        public static string ExibirCartas(int idJogador, string senhaJogador)
        {
            string cartas = Jogo.ListarCartas(idJogador, senhaJogador);
            return cartas;
        }

        public static (int idJogador, char status, int rodada, char faseAtual) VerificarVez(int idPartida)
        {
            string retorno = Jogo.VerificarVez(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] statusPartida = retorno.Split('\n');

            int idJogador = 0;
            char status = ' ';
            int rodada = 0;
            char faseAtual = ' ';

            for (int i = 0; i < statusPartida.Length; i++)
            {
                string[] dados = statusPartida[i].Split(',');

                if (dados.Length >= 4) 
                {
                    idJogador = Convert.ToInt32(dados[0]);
                    status = Convert.ToChar(dados[1]);
                    rodada = Convert.ToInt32(dados[2]);
                    faseAtual = Convert.ToChar(dados[3]); 
                }
            }

            return (idJogador, status, rodada, faseAtual);
        }


    }
}
