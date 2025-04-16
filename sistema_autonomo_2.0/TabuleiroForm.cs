using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_autonomo_2._0
{
    public partial class TabuleiroForm: Form
    {
        public Panel pnlSetor = null;
        public List<Panel> Personagens { get; set; } = new List<Panel>();
        public TabuleiroForm()
        {
            InitializeComponent();
            this.FormClosing += HideTabuleiro; // esconde formulário em vez de fechar

            Panel pnlA = CriarPainelPersonagem("A", Properties.Resources.A);
            Panel pnlB = CriarPainelPersonagem("B", Properties.Resources.B);
            Panel pnlC = CriarPainelPersonagem("C", Properties.Resources.C);
            Panel pnlD = CriarPainelPersonagem("D", Properties.Resources.D);
            Panel pnlE = CriarPainelPersonagem("E", Properties.Resources.E);
            Panel pnlG = CriarPainelPersonagem("G", Properties.Resources.G);
            Panel pnlH = CriarPainelPersonagem("H", Properties.Resources.H);
            Panel pnlK = CriarPainelPersonagem("K", Properties.Resources.K);
            Panel pnlL = CriarPainelPersonagem("L", Properties.Resources.L);
            Panel pnlM = CriarPainelPersonagem("M", Properties.Resources.M);
            Panel pnlQ = CriarPainelPersonagem("Q", Properties.Resources.Q);
            Panel pnlR = CriarPainelPersonagem("R", Properties.Resources.R);
            Panel pnlT = CriarPainelPersonagem("T", Properties.Resources.T);

            Personagens.Add(pnlA);
            Personagens.Add(pnlB);
            Personagens.Add(pnlC);
            Personagens.Add(pnlD);
            Personagens.Add(pnlE);
            Personagens.Add(pnlG);
            Personagens.Add(pnlH);
            Personagens.Add(pnlK);
            Personagens.Add(pnlL);
            Personagens.Add(pnlM);
            Personagens.Add(pnlQ);
            Personagens.Add(pnlR);
            Personagens.Add(pnlT);
        }

        public Panel CriarPainelPersonagem(string nome, Image imagem)
        {
            Panel painel = new Panel();
            painel.Size = new Size(40, 40);
            painel.BackgroundImage = imagem;
            painel.BackgroundImageLayout = ImageLayout.Stretch;
            painel.Name = "pnl" + nome.ToUpper();  
            return painel;
        }

        public Panel BuscarPainelPersonagem(string personagem)
        {
            foreach (var p in Personagens)
            {
                if (p.Name == "pnl" + personagem.ToUpper())
                {
                    return p;
                }
            }
            return null;
        }

        public void LimparPersonagens()
        {
            foreach (var panel in Personagens)
            {
                if (panel.Parent != null)
                {
                    panel.Parent.Controls.Remove(panel);
                }

                panel.Visible = false;
            }
        }

        void HideTabuleiro(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void AdicionarPersonagem(int setor, string personagem)
        {
            Panel pnlSetor = null;

            if (personagem == "a" || personagem == "A")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if(pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor; // usar caso precise de outros métodos
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(3, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "b" || personagem == "B")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;

                }

                if (pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(49, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "c" || personagem == "C")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(95, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "d" || personagem == "D")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(141, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "e" || personagem == "E")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {

                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(187, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "g" || personagem == "G")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(233, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "h" || personagem == "H")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {

                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(279, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "k" || personagem == "K")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {

                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(325, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "l" || personagem == "L")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(371, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "m" || personagem == "M")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(417, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "q" || personagem == "Q")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(463, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "r" || personagem == "R")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(509, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

            if (personagem == "t" || personagem == "T")
            {
                switch (setor)
                {
                    case 0:
                        pnlSetor = pnlPlebeus;
                        break;

                    case 1:
                        pnlSetor = pnlArtesaos;
                        break;

                    case 2:
                        pnlSetor = pnlMercadores;
                        break;

                    case 3:
                        pnlSetor = pnlOficiais;
                        break;

                    case 4:
                        pnlSetor = pnlDignatarios;
                        break;
                    case 5:
                        pnlSetor = pnlNobres;
                        break;
                    case 10:
                        pnlSetor = pnlRei;
                        break;
                }

                if (pnlSetor != null)
                {
                    Panel painelPersonagem = BuscarPainelPersonagem(personagem);

                    if(painelPersonagem != null)
                    {
                        this.pnlSetor = pnlSetor;
                        pnlSetor.Controls.Add(painelPersonagem);
                        painelPersonagem.Location = new Point(555, 6);
                        painelPersonagem.Visible = true;
                        painelPersonagem.Refresh();
                    }
                }

            }

        }


    }
}
