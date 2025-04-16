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
        //VerificarErro verificarErro = new VerificarErro();
        TabuleiroForm tabuleiro;
        List<Tabuleiro> tb;
        Lobby lobby = new Lobby();

        public btnTabuleiro()
        {
            InitializeComponent();

            lblVersao.Text = Jogo.versao; // versão da dll
            lblGrupo.Text = "Juízes de Common Law";
        }

        public void ListarPartidas()
        {
            dgvListarPartidas.DataSource = Lobby.ListarPartida();
        }

        public void ListarJogadores()
        {
            string idPartida = txtIdPartida.Text;
            int id = Convert.ToInt32(idPartida);
            dgvListarJogadores.DataSource = Lobby.ListarJogador(id);
        }

        public void CriarPartida()
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

        public void EntrarPartida()
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

            lobby.MeuID = idSenhaJogador.idJogador; // salva id jogador que entrou na partida
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

        public void ExibirCartas()
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;

            string cartas = Lobby.ExibirCartas(id, senhaJogador);

            lblCartas.Text = cartas;
        }

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

        public void PromoverPersonagem()
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

        public void Votar()
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

        public void ExibirVotacao()
        {
            string idPartida = txtIdPartida.Text;
            int id = Convert.ToInt32(idPartida);

            dgvVerificarVez.DataSource = Lobby.ExibirUltimaVotacao(id);
        }

        public void VerificarVezTabuleiro()
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

        /////////////////// BOTÕES DO FORM ///////////////////
        
        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            ListarPartidas();
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            ListarJogadores();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            CriarPartida();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            EntrarPartida();
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            IniciarJogo();
            tmrIniciar.Enabled = true; // habilitando o timer
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            ExibirCartas();
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            VerificarVez();
        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            string setorStr = txtSetor.Text;
            int setor = Convert.ToInt32(setorStr);
            string personagem = txtPersonagem.Text;

            ColocarPersonagem(setor, personagem);
        }

        private void btnPromoverPersonagem_Click(object sender, EventArgs e)
        {
            PromoverPersonagem();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            Votar();
        }

        private void btnExibirVotacao_Click(object sender, EventArgs e)
        {
            ExibirVotacao();
        }

        private void btnVerificarVezTabuleiro_Click(object sender, EventArgs e)
        {
            VerificarVezTabuleiro();
        }

        /////////////////// TIMER /////////////////

        private void tmrIniciar_Tick(object sender, EventArgs e)
        {
            tmrIniciar.Enabled = false; // desabilitando o timer

            // pegar o estado do tabuleiro pra colocar o personagem a partir dele;
            // talvez pensar na carta de influência de cada personagem pra estratégia;

            var estadoTabuleiro = tb;

            if (lobby.JogadorDaVez == lobby.MeuID)
            {
                int setor = 1;
                string personagem = "A";
                ColocarPersonagem(setor, personagem);
            }

            tmrIniciar.Enabled = true; // habilitando o timer novamente
        }
    }
}
