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
        static List<Tabuleiro> setorPersonagem = new List<Tabuleiro>();

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
            setorPersonagem.Add(new Tabuleiro
            {
                Setor = setor,
                Personagem = personagem
            });
        }

        public static List<Tabuleiro> ObterEstadoTabuleiro()
        {
            // Retorna apenas personagens com setor válido (>= 0) e ordena
            return setorPersonagem.Where(p => p.Setor >= 0)
                                 .OrderBy(p => p.Setor)
                                 .ToList();
        }

        public static Tabuleiro BuscarPersonagem(string personagem)
        {
            foreach(Tabuleiro item in setorPersonagem)
            {
                if(item.Personagem == personagem)
                {
                    return item;
                }
            }

            return null;
        }

        public static void RemoverPersonagem(int setor, string personagem)
        {
            // Remove o personagem da lista do setor anterior
            var personagensNoSetor = setorPersonagem.Where(p => p.Setor == setor && p.Personagem == personagem).ToList();
            foreach (var p in personagensNoSetor)
            {
                setorPersonagem.Remove(p);
            }
        }

    }
}
