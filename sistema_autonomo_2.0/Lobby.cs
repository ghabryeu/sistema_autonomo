using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sistema_autonomo_2._0
{
    class Lobby
    {
        int jogadorDaVez;
        int meuID;

        public int JogadorDaVez
        {
            get { return jogadorDaVez; }
            set { jogadorDaVez = value; }
        }

        public int MeuID
        {
            get { return meuID; }
            set { meuID = value; }
        }

        public Lobby()
        {
            this.jogadorDaVez = 0;
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
                p.Id = Convert.ToInt32(dados[0]);
                p.Nome = dados[1];
                p.Data = Convert.ToDateTime(dados[2]);
                p.Status = Convert.ToChar(dados[3]);

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

            for (int i = 0; i < jogadores.Length; i++)
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

        public static List<Setor> ListarSetores()
        {
            string retorno = Jogo.ListarSetores();
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] setores = retorno.Split('\n');
            List<Setor> listaSetores = new List<Setor>();

            for (int i = 0; i < setores.Length; i++)
            {
                string[] dados = setores[i].Split(',');

                Setor s = new Setor();

                s.IdSetor = Convert.ToInt32(dados[0]);
                s.NomeSetor = dados[1];

                listaSetores.Add(s);
            }

            return listaSetores;
        }

        public static List<Personagem> ListarPersonagens()
        {
            string retorno = Jogo.ListarPersonagens();
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] personagens = retorno.Split('\n');
            List<Personagem> listaPersonagens = new List<Personagem>();

            for (int i = 0; i < personagens.Length; i++)
            {
                string[] dados = personagens[i].Split(',');

                Personagem p = new Personagem();
                
                p.Nome = dados[0];

                listaPersonagens.Add(p);
            }

            return listaPersonagens;
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
            string retorno = Jogo.ListarCartas(idJogador, senhaJogador);
            retorno = retorno.Replace("\r", "");
            string[] dados = retorno.Split(',');

            string cartas = dados[0];

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

        // função: conseguir devolver o estado do tabuleiro depois da promoção
        public static List<Tabuleiro> RetornarEstadoTabuleiro(int idPartida)
        {
            string retorno = Jogo.VerificarVez(idPartida);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] statusPartida = retorno.Split('\n');
            List<Tabuleiro> setorPersonagem = new List<Tabuleiro>();

            for (int i = 0; i < statusPartida.Length; i++)
            {
                string[] dados = statusPartida[i].Split(',');

                Tabuleiro t = new Tabuleiro();

                t.Setor = Convert.ToInt32(dados[0]);
                t.Personagem = dados[1];

                setorPersonagem.Add(t);
            }

            return setorPersonagem;
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

        public static List<Personagem> ExibirUltimaVotacao(int idPartida)
        {
            string retorno = Jogo.ExibirUltimaVotacao(idPartida);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] status = retorno.Split('\n');
            List<Personagem> votoPersonagem = new List<Personagem>();

            for (int i = 0; i < status.Length; i++)
            {
                string[] dados = status[i].Split(',');

                Personagem p = new Personagem();

                p.Nome = dados[0];
                p.ID = Convert.ToInt32(dados[1]);
                p.Voto = dados[2];

                votoPersonagem.Add(p);
            }

            return votoPersonagem;
        }

        public static List<Historico> ConsultarHistorico(int idPartida, bool formato, bool completo)
        {
            string retorno = Jogo.ConsultarHistorico(idPartida, formato, completo);
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] historico = retorno.Split('\n');
            List<Historico> listaHistorico = new List<Historico>();

            for (int i = 0; i < historico.Length; i++)
            {
                string[] dados = historico[i].Split(',');

                Historico h = new Historico();

                h.Acao = dados[0];

                listaHistorico.Add(h);
            }
            return listaHistorico;
        }
    }
}
