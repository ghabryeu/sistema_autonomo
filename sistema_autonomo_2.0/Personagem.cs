﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_autonomo_2._0
{
    class Personagem
    {
        string nome;
        int id;
        string voto;
        int votoRestante = 3;
        public static List<string> Nomes { get; set; } = new List<string> {"A", "B", "C", "D", "E", "G", "H", "K", "L", "M", "Q", "R", "T"};
        public static List<string> PersonagensUsados { get; set; } = new List<string>();
        public static List<string> PersonagensDisponiveis { get; set; } = new List<string>();

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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
