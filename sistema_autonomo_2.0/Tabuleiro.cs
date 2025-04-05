using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo_2._0
{
    class Tabuleiro
    {
        int setor;
        string personagem;
        public static List<Tabuleiro> SetorPersonagem { get; set; } = new List<Tabuleiro>();

        public int Setor
        {
            get { return setor; }
            set { setor = value; }
        }

        public string Personagem
        {
            get { return personagem; }
            set { personagem = value; }
        }

        public static void AdicionarPersonagem(int setor, string personagem)
        {
            SetorPersonagem.Add(new Tabuleiro
            {
                Setor = setor,
                Personagem = personagem
            });
        }

        public static List<Tabuleiro> ObterEstadoTabuleiro()
        {
            return SetorPersonagem.Where(p => p.Setor >= 0)
                                 .OrderBy(p => p.Setor)
                                 .ToList();
        }

    }
}
