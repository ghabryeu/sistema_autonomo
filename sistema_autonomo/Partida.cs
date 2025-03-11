using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;

namespace sistema_autonomo
{
    class Partida
    {
        public string id;
        public string senha;
        public string nome;

        public static List<Partida> ListarPartida()
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');
            List<Partida> listaPartidas = new List<Partida>();

            for(int i = 0; i < partidas.Length; i++)
            {
                string partida = partidas[i];
                string[] dados = partida.Split(',');

                if (dados.Length < 3) continue;

                Partida p = new Partida();
                p.id = dados[0];
                p.nome = dados[1];
                p.senha = dados[2];

                listaPartidas.Add(p);
            }


            return listaPartidas;
        }

    }
}
