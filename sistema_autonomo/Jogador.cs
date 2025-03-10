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
        public int id;
        public string senha;
        public string nome;


        public string EntrarPartida(string idPartidaString, string senhaPartida)
        {
            int idPartida = Convert.ToInt32(idPartidaString);
            string retornoEntrar = Jogo.Entrar(idPartida, nome, senhaPartida);

            return retornoEntrar;
        }
    }
}
