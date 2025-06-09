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
        Setor setor;
        List<Tabuleiro> estadoDoTabuleiro;
        Lobby lobby = new Lobby();
        Jogador jogador = new Jogador();
        Random random = new Random();
        Personagem personagem = new Personagem();

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
            
            if(!verificarErro.VerificarIdPartida(idPartida))
            {
                return;
            }

            int id = Convert.ToInt32(idPartida);
            dgvListarJogadores.DataSource = Lobby.ListarJogador(id);
        }

        public void ListarSetores()
        {
            lstSetores.Items.Clear();

            List<Setor> setores = Lobby.ListarSetores();

            foreach (Setor setor in setores)
            {
                lstSetores.Items.Add($"{setor.IdSetor}: {setor.NomeSetor}");
            }
        }

        public void ListarPersonagens()
        {
            lstPersonagens.Items.Clear();

            List<Personagem> personagens = Lobby.ListarPersonagens();

            foreach (Personagem personagem in personagens)
            {
                lstPersonagens.Items.Add($"{personagem.Nome}");
            }
        }

        public void CriarPartida()
        {
            // informações do forms
            string nomePartida = txtNomePartida.Text;
            string senha = txtSenhaPartida.Text;
            string nomeGrupo = "Juízes de Common Law";

            if (!verificarErro.VerificarNome(nomePartida))
            {
                return;
            }

            if (!verificarErro.VerificarSenha(senha))
            {
                return;
            }

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
            string nomeJogador = txtNomeJogador.Text;
            string senhaPartida = txtSenhaPartida.Text;

            if(!verificarErro.VerificarNome(nomeJogador))
            {
                return;
            }

            if (!verificarErro.VerificarIdPartida(idPartida))
            {
                return;
            }

            int id = Convert.ToInt32(idPartida);
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

        public string ExibirCartas()
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;

            string cartas = Lobby.ExibirCartas(id, senhaJogador);

            lblCartas.Text = cartas;

            return cartas;
        }

        public void VerificarVez()
        {
            string idPartida = txtIdPartida.Text;
            int id = Convert.ToInt32(idPartida);

            var resultado = Lobby.VerificarVez(id);
            lobby.JogadorDaVez = resultado.idJogador; // salva id jogador da vez

            // pegando nome do jogador
            List<Jogador> listaJogadores = Lobby.ListarJogador(id);
            string nome = "";
            foreach(Jogador j in listaJogadores)
            {
                if (j.Id == resultado.idJogador)
                {
                    nome = j.Nome;
                    break;
                }
            }

            jogador.Id = resultado.idJogador;
            jogador.Status = resultado.status;
            jogador.Nome = nome;
            jogador.Rodada = resultado.rodada;
            jogador.FaseAtual = resultado.faseAtual;

            List<Jogador> lista = new List<Jogador>
            {
                jogador
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
            
            int rodadaAnterior = -1;
            if(jogador.Rodada != rodadaAnterior && tabuleiro != null)
            {
                tabuleiro.LimparPersonagens();
                rodadaAnterior = jogador.Rodada;
            }

            estadoDoTabuleiro = Lobby.ColocarPersonagem(id, senhaJogador, setor, personagem);
            dgvVerificarVez.DataSource = estadoDoTabuleiro;

            // abre segundo form
            if (tabuleiro == null || tabuleiro.IsDisposed)
            {
                tabuleiro = new TabuleiroForm();
                tabuleiro.Show();
            }

            // exibindo graficamente
            foreach (var t in estadoDoTabuleiro)
            {
                tabuleiro.AdicionarPersonagem(t.Setor, t.Personagem);
            }
        }

        public void PromoverPersonagem(string personagem)
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;
            //string personagem = txtPersonagem.Text;

            string idPartida = txtIdPartida.Text;
            int idPtd = Convert.ToInt32(idPartida);

            tabuleiro.LimparPersonagens();

            dgvVerificarVez.DataSource = Lobby.PromoverPersonagem(id, senhaJogador, personagem);

            estadoDoTabuleiro = Lobby.RetornarEstadoTabuleiro(idPtd);

            foreach (var t in estadoDoTabuleiro)
            {
                tabuleiro.AdicionarPersonagem(t.Setor, t.Personagem);
            }
        }

        public void Votar(string voto)
        {
            string idJogador = txtIdJogador.Text;
            int id = Convert.ToInt32(idJogador);
            string senhaJogador = txtSenhaJogador.Text;
            //string voto = txtVotar.Text;

            string idPartida = txtIdPartida.Text;
            int idPtd = Convert.ToInt32(idPartida);

            tabuleiro.LimparPersonagens();

            Jogo.Votar(id, senhaJogador, voto);

            estadoDoTabuleiro = Lobby.RetornarEstadoTabuleiro(idPtd);

            foreach (var t in estadoDoTabuleiro)
            {
                tabuleiro.AdicionarPersonagem(t.Setor, t.Personagem);
            }
        }

        public void ExibirUltimaVotacao()
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

            dgvVerificarVez.DataSource = estadoDoTabuleiro;
        }

        public void ConsultarHistorico()
        {
            string idPartida = txtIdPartida.Text;
            int id = Convert.ToInt32(idPartida);

            bool formatado = chkHistorico.Checked;
            bool completo = !chkHistorico.Checked;

            dgvVerificarVez.DataSource = Lobby.ConsultarHistorico(id, formatado,  completo);
        }

        // ajustes: verificar os personagens que já foram colocados no tabuleiro
        // pelos outros jogadores e não estão mais disponíveis
        public void AutoColocarPersonagem()
        {
            var nomes = Personagem.Nomes;
            var nomesDisponiveis = Personagem.PersonagensDisponiveis;
            var nomesUsados = Personagem.PersonagensUsados;

            string idPartida = txtIdPartida.Text;
            int idPtd = Convert.ToInt32(idPartida);
            estadoDoTabuleiro = Lobby.RetornarEstadoTabuleiro(idPtd);

            try
            {
                nomesUsados.Clear();

                foreach (var t in estadoDoTabuleiro)
                {
                    if (!nomesUsados.Contains(t.Personagem))
                    {
                        nomesUsados.Add(t.Personagem);
                    }
                }

                nomesDisponiveis.Clear();

                foreach (var nome in nomes)
                {
                    if (!nomesUsados.Contains(nome))
                    {
                        nomesDisponiveis.Add(nome);
                    }
                }

                if (nomesDisponiveis.Count > 0)
                {
                    int setor = random.Next(1, 5);

                    
                    int indiceAleatorio = random.Next(0, nomesDisponiveis.Count);
                    string personagemSelecionado = nomesDisponiveis[indiceAleatorio];

                    if (!string.IsNullOrEmpty(personagemSelecionado) && !nomesUsados.Contains(personagemSelecionado))
                    {
                        // add personagem de setor aqui //

                        nomesUsados.Add(personagemSelecionado);
                        nomesDisponiveis.Remove(personagemSelecionado);

                        label12.Text = nomesDisponiveis.Count.ToString();
                        ColocarPersonagem(setor, personagemSelecionado);
                    }
                    else
                    {
                        MessageBox.Show("Personagem não válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AutoPromoverPersonagem()
        {
            // tabuleiro pra verificar onde cada personagem está
            string idPartida = txtIdPartida.Text;
            int idPtd = Convert.ToInt32(idPartida);
            estadoDoTabuleiro = Lobby.RetornarEstadoTabuleiro(idPtd);

            var nomes = Personagem.Nomes;

            try
            {

                int indice = random.Next(0, nomes.Count);
                string personagemSelecionado = nomes[indice];

                if(!string.IsNullOrEmpty(personagemSelecionado)){

                    // setor atual do personagem
                    int setorAtual = -1;
                    foreach (var t in estadoDoTabuleiro)
                    {
                        if (t.Personagem == personagemSelecionado)
                        {
                            setorAtual = t.Setor;
                            break;
                        }
                    }

                    if (setorAtual == -1)
                    {
                        MessageBox.Show("Personagem não está no tabuleiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int setorPromocao = setorAtual + 1;

                    // quantos personagens estão no próximo setor
                    int quantidadeNoSetor = 0;
                    foreach (var t in estadoDoTabuleiro)
                    {
                        if (t.Setor == setorPromocao)
                            quantidadeNoSetor++;
                    }

                    if (quantidadeNoSetor < 4)
                    {
                        PromoverPersonagem(personagemSelecionado);
                    }
                    else
                    {
                        MessageBox.Show($"Limite atingido no setor {setorPromocao}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Personagem não válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch
            {
                MessageBox.Show("Erro ao promover personagem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AutoVotar() 
        {
            // tabuleiro pra verificar onde cada personagem está
            string idPartida = txtIdPartida.Text;
            int idPtd = Convert.ToInt32(idPartida);
            estadoDoTabuleiro = Lobby.RetornarEstadoTabuleiro(idPtd);

            // usar exibir cartas para votar
            // lista de personagens de cada jogador
            string cartas = ExibirCartas();
            string[] meusPersonagens = cartas.Split(',');

            string personagemSetorRei = null;
            foreach (var t in estadoDoTabuleiro)
            {
                if (t.Setor == 10)
                {
                    personagemSetorRei = t.Personagem;
                    break;
                }
            }

            // comparar com meusPersonagens
            bool ehMeu = false;
            foreach (var p in meusPersonagens)
            {
                if (p.Trim() == personagemSetorRei)
                {
                    ehMeu = true;
                    break;
                }
            }

            // sim ou não
            string voto;
            if (ehMeu)
            {
                voto = "s";
            }
            else
            {
                if (personagem.VotoRestante > 0)
                {
                    voto = "n";
                    personagem.VotoRestante--;
                }
                else
                {
                    voto = "s";
                }
            }

            try
            {
                Votar(voto);
            }
            catch
            {
                MessageBox.Show("Erro ao votar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AutomatizarAcao()
        {
            if (lobby.JogadorDaVez == lobby.MeuID)
            {
                switch (jogador.FaseAtual)
                {
                    case 'S':
                        AutoColocarPersonagem();
                        break;
                    case 'P':
                        AutoPromoverPersonagem();
                        break;
                    case 'V':
                        AutoVotar();
                        break;
                }
            }
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
            ListarSetores();
            ListarPersonagens();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            EntrarPartida();
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            IniciarJogo();
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
            //string setorStr = txtSetor.Text;
            //int setor = Convert.ToInt32(setorStr);
            //string personagem = txtPersonagem.Text;

            //ColocarPersonagem(setor, personagem);
        }

        private void btnPromoverPersonagem_Click(object sender, EventArgs e)
        {
            //string personagem = txtPersonagem.Text;
            //PromoverPersonagem(personagem);
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            //Votar();
        }

        private void btnExibirVotacao_Click(object sender, EventArgs e)
        {
            ExibirUltimaVotacao();
        }

        private void btnVerificarVezTabuleiro_Click(object sender, EventArgs e)
        {
            VerificarVezTabuleiro();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            ConsultarHistorico();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            tmrIniciar.Enabled = true; // habilitando o timer
        }


        /////////////////// TIMER /////////////////

        private void tmrIniciar_Tick(object sender, EventArgs e)
        {
            tmrIniciar.Enabled = false; // desabilitando o timer

            VerificarVez();
            ExibirCartas();
            AutomatizarAcao();
            VerificarVez();

            tmrIniciar.Enabled = true; // habilitando o timer novamente
        }

    }
}
