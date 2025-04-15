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
        VerificarErro verificarErro = new VerificarErro();

        TabuleiroForm tabuleiro;
        
        List<Tabuleiro> tb;

        Lobby lobby = new Lobby();

        public btnTabuleiro()
        {
            InitializeComponent();

            lblVersao.Text = Jogo.versao; // versão da dll
            lblGrupo.Text = "Juízes de Common Law";
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            dgvListarPartidas.DataSource = Lobby.ListarPartida();
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string idPartida = txtIdPartida.Text; // informação do forms
            int id = Convert.ToInt32(idPartida); // convertendo p int

            //if (!verificarErro.VerificarIdPartida(id))
            //{
            //    return;
            //}

            dgvListarJogadores.DataSource = Lobby.ListarJogador(id);
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            // informações do forms
            string nomePartida = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            string nomeGrupo = "Juízes de Common Law";

            int idPartida = Lobby.CriarPartida(nomePartida, senha, nomeGrupo);
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
            var idSenhaJogador = Lobby.EntrarPartida(id, nomeJogador, senhaPartida);

            // id e senha
            int idJogador = idSenhaJogador.idJogador;
            string senhaJogador = idSenhaJogador.senhaJogador;

            string idJogadorStr = idJogador.ToString(); // convertendo p string

            // exibindo no forms
            lblIdJogador.Text = idJogadorStr;
            lblSenhaJogador.Text = senhaJogador;

            txtIdJogador.Text = idJogadorStr;
            txtSenhaJogador.Text = senhaJogador;

            lobby.MeuID = txtIdJogador.Text; // salva meu id
        }

        public void IniciarJogo()
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;

            int jogadorInicial = Lobby.IniciarPartida(id, senhaJogador);
            string jogador = jogadorInicial.ToString();

            lblJogadorInicial.Text = jogador;
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            IniciarJogo();
            tmrIniciar.Enabled = true; // habilitando o timer
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;

            string cartas = Lobby.ExibirCartas(id, senhaJogador);

            lblCartas.Text = cartas;
        }

        // VERIFICAR VEZ
        public void VerificarVez()
        {
            string idPartida = txtIdPartida.Text;
            int id = Convert.ToInt32(idPartida);

            var resultado = Lobby.VerificarVez(id);
            lobby.JogadorDaVez = resultado.idJogador; // salva id jogador da vez

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

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            VerificarVez();
        }

        // COLOCAR PERSONAGEM
        public void ColocarPersonagem(int setor, string personagem)
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;
            //string setorStr = txtSetor.Text;
            //int setor = Convert.ToInt32(setorStr);
            //string personagem = txtPersonagem.Text;

            // tb -> lista declarada no início
            tb = Lobby.ColocarPersonagem(id, senhaJogador, setor, personagem);
            dgvVerificarVez.DataSource = tb;

            // abre segundo form
            if (tabuleiro == null || tabuleiro.IsDisposed)
            {
                tabuleiro = new TabuleiroForm();
                tabuleiro.Show();
            }

            // exibindo graficamente
            foreach (var t in tb)
            {
                tabuleiro.AdicionarPersonagem(t.Setor, t.Personagem);
            }
        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            //ColocarPersonagem();
        }

        private void btnPromoverPersonagem_Click(object sender, EventArgs e)
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;
            string personagem = txtPersonagem.Text;

            string idPartida = txtIdPartida.Text;
            int idPtd = Convert.ToInt32(idPartida);

            tabuleiro.LimparPersonagens();

            dgvVerificarVez.DataSource = Lobby.PromoverPersonagem(id, senhaJogador, personagem);

            tb = Lobby.RetornarEstadoTabuleiro(idPtd);

            foreach (var t in tb)
            {
                tabuleiro.AdicionarPersonagem(t.Setor, t.Personagem);
                label13.Text = t.Setor.ToString();
                label12.Text = t.Personagem;
            }

        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;
            string voto = txtVotar.Text;

            string idPartida = txtIdPartida.Text;
            int idPtd = Convert.ToInt32(idPartida);

            tabuleiro.LimparPersonagens();

            Jogo.Votar(id, senhaJogador, voto);

            tb = Lobby.RetornarEstadoTabuleiro(idPtd);

            foreach (var t in tb)
            {
                tabuleiro.AdicionarPersonagem(t.Setor, t.Personagem);
                label13.Text = t.Setor.ToString();
                label12.Text = t.Personagem;
            }
        }

        private void btnExibirVotacao_Click(object sender, EventArgs e)
        {
            string idPartida = txtIdPartida.Text;
            int id = Convert.ToInt32(idPartida);

            dgvVerificarVez.DataSource = Lobby.ExibirUltimaVotacao(id);
        }

        private void btnVerificarVezTabuleiro_Click(object sender, EventArgs e)
        {
            if (tabuleiro != null && !tabuleiro.IsDisposed)
            {
                tabuleiro.Show();
                tabuleiro.BringToFront();
            }
            else
            {
                tabuleiro = new TabuleiroForm();
                tabuleiro.Show();
            }

            dgvVerificarVez.DataSource = tb;
        }


        /////////////////// TIMER /////////////////

        private void tmrIniciar_Tick(object sender, EventArgs e)
        {
            tmrIniciar.Enabled = false; // desabilitando o timer
            
            var resultado = Lobby.VerificarVez(Convert.ToInt32(txtIdPartida.Text));
            lobby.JogadorDaVez = resultado.idJogador;  // atualiza a vez

            int meuID = Convert.ToInt32(lobby.MeuID); // id de entrada

            if (lobby.JogadorDaVez == meuID)
            {
                int setor = 1;
                string personagem = "A";
                ColocarPersonagem(setor, personagem);
            }

            tmrIniciar.Enabled = true; // habilitando o timer novamente
        }
    }
}
