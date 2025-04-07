using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;

namespace sistema_autonomo_2._0
{
    public partial class btnTabuleiro: Form
    {
        TabuleiroForm tabuleiro;

        public btnTabuleiro()
        {
            InitializeComponent();

            lblVersao.Text = Jogo.versao; // versão da dll
            lblGrupo.Text = "Juízes de Common Law";
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            dgvListarPartidas.DataSource = Partida.ListarPartida();
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string idPartida = txtIdPartida.Text; // informação do forms
            int id = Convert.ToInt32(idPartida); // convertendo p int

            dgvListarJogadores.DataSource = Partida.ListarJogador(id);
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            // informações do forms
            string nomePartida = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            string nomeGrupo = "Juízes de Common Law";

            int idPartida = Partida.CriarPartida(nomePartida, senha, nomeGrupo);
            string id = idPartida.ToString();

            // exibindo dados obtidos no forms
            lblIdPartidaCriada.Text = id;
            txtIdPartida.Text = id;
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            // pegando informações do forms
            string idPartida = txtIdPartida.Text;
            int id = Convert.ToInt32(idPartida);
            string nomeJogador = txtNomeJogador.Text;
            string senhaPartida = txtSenhaPartida.Text;

            // gerador senha por id jogador
            var idSenhaJogador = Jogador.EntrarPartida(id, nomeJogador, senhaPartida);

            // id e senha
            int idJogador = idSenhaJogador.idJogador;
            string senhaJogador = idSenhaJogador.senhaJogador;

            string idJogadorStr = idJogador.ToString(); // convertendo p string

            // exibindo no forms
            lblIdJogador.Text = idJogadorStr;
            lblSenhaJogador.Text = senhaJogador;

            txtIdJogador.Text = idJogadorStr;
            txtSenhaJogador.Text = senhaJogador;
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;

            int jogadorInicial = Partida.IniciarPartida(id, senhaJogador);
            string jogador = jogadorInicial.ToString();

            lblJogadorInicial.Text = jogador;
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;

            string cartas = Partida.ExibirCartas(id, senhaJogador);

            lblCartas.Text = cartas;
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            string idPartida = txtIdPartida.Text;
            int id = Convert.ToInt32(idPartida);

            var resultado = Partida.VerificarVez(id);

            List<Jogador> lista = new List<Jogador>
            {
                new Jogador
                {
                    Id = resultado.idJogador,
                    Status = resultado.status,
                    Rodada = resultado.rodada,
                    FaseAtual = resultado.faseAtual
                }
            };

            dgvVerificarVez.DataSource = lista;
        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);

            string senhaJogador = txtSenhaJogador.Text;

            string setorStr = txtSetor.Text;
            int setor = Convert.ToInt32(setorStr);

            string personagem = txtPersonagem.Text;

            dgvVerificarVez.DataSource = Jogador.ColocarPersonagem(id, senhaJogador, setor, personagem);

            // abre segundo form
            if (tabuleiro == null || tabuleiro.IsDisposed)
            {
                tabuleiro = new TabuleiroForm();
                tabuleiro.Show();
            }

            tabuleiro.AdicionarPersonagem(setor, personagem);

        }

        private void btnTabuleiroForm_Click(object sender, EventArgs e)
        {
            TabuleiroForm t = new TabuleiroForm();
            t.ShowDialog();
        }
 

    }
}
