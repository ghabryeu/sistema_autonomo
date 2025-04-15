using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo_2._0
{
    class Personagem
    {
        string personagem;
        int id;
        string voto;
        int votoRestante;

        public string Inicial
        {
            get { return personagem; }
            set { personagem = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Voto
        {
            get { return voto; }
            set { voto = value; }
        }

        public int VotoRestante
        {
            get { return votoRestante; }
            set { votoRestante = value; }
        }

    }
}
