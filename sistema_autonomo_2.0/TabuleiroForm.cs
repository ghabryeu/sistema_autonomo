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

        public TabuleiroForm()
        {
            InitializeComponent();
            this.FormClosing += HideTabuleiro; // esconde formulário em vez de fechar
        }

        public void AdicionarPersonagem(int setor, string personagem)
        {
            //Panel pnlPersonagem = new Panel();
            //pnlPersonagem.Size = new Size(40, 40);
            //pnlPersonagem.BackColor = Color.BlueViolet;
            //pnlPersonagem.Location = new Point(3, 6);
            //pnlA.Controls.Add(pnlPersonagem);

            Panel pnlSetor = null;
            //setor = 0;

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

                }

                if(pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor; // usar caso precise de outros métodos
                    pnlSetor.Controls.Add(pnlA);
                    pnlA.Location = new Point(3, 6); 
                    pnlA.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlB);
                    pnlB.Location = new Point(49, 6);
                    pnlB.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlC);
                    pnlC.Location = new Point(95, 6);
                    pnlC.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlD);
                    pnlD.Location = new Point(141, 6);
                    pnlD.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlE);
                    pnlE.Location = new Point(187, 6);
                    pnlE.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlG);
                    pnlG.Location = new Point(233, 6);
                    pnlG.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlH);
                    pnlH.Location = new Point(279, 6);
                    pnlH.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlK);
                    pnlK.Location = new Point(325, 6);
                    pnlK.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlL);
                    pnlL.Location = new Point(371, 6);
                    pnlL.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlM);
                    pnlM.Location = new Point(417, 6);
                    pnlM.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlQ);
                    pnlQ.Location = new Point(463, 6);
                    pnlQ.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlR);
                    pnlR.Location = new Point(509, 6);
                    pnlR.Visible = true;
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

                }

                if (pnlSetor != null)
                {
                    this.pnlSetor = pnlSetor;
                    pnlSetor.Controls.Add(pnlT);
                    pnlT.Location = new Point(555, 6);
                    pnlT.Visible = true;
                }

            }

        }

        void HideTabuleiro(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

    }
}
