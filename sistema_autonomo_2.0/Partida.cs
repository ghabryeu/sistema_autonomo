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
        string nome;
        DateTime data;
        char status;

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

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public char Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
