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

    }
}
