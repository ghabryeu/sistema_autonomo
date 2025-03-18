using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;

namespace sistema_autonomo
{
    class Jogador
    {
        string id;
        string senha;
        string nome;

        public string Id
        { get { return id; }
          set { id = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Jogador(string id, string senha, string nome)
        {
            this.id = id;
            this.senha = senha;
            this.nome = nome;
        }

        public string EntrarPartida(string idPartidaString, string senhaPartida)
        {
            int idPartida = Convert.ToInt32(idPartidaString);
            string retornoEntrar = Jogo.Entrar(idPartida, nome, senhaPartida);

            return retornoEntrar;
        }
    }
}
