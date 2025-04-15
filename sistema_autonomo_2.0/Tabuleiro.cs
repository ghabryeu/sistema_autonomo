using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo_2._0
{
    public class Tabuleiro
    {
        int setor;
        string personagem;

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

    }
}
