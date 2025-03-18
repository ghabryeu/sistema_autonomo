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

namespace sistema_autonomo
{
    public partial class Form1: Form
    {
        Erro verificarErro = new Erro();
        Tabuleiro tabuleiro = new Tabuleiro();
        Personagem personagem = new Personagem();

        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.versao; // versão da dll
            lblGrupo.Text = "Juízes de Common Law"; // label 
            txtNomeGrupo.Text = "Juízes de Common Law"; // txt

            // itens da combobox
            cboTipoPartida.Items.Add("Todos");
            cboTipoPartida.Items.Add("Abertas");
            cboTipoPartida.Items.Add("Jogando");
            cboTipoPartida.Items.Add("Encerrando");
            cboTipoPartida.SelectedIndex = 0;
        }

        private void btnListarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            lstPartidas.Items.Clear();
            for(int i = 0; i < partidas.Length; i++)
            {
                lstPartidas.Items.Add(partidas[i]);
            }
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string partida = lstPartidas.SelectedItem?.ToString();

            if (!verificarErro.VerificarSelecaoPartida(partida))
            {
                return;
            }

            string[] dadosPartida = partida.Split(',');

            int idPartida = Convert.ToInt32(dadosPartida[0]);
            string nomePartida = dadosPartida[1];
            string data = dadosPartida[2];

            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n');

            lstJogadores.Items.Clear();
            for(int i = 0; i < jogadores.Length; i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            // nome e senha da partida
            Partida partida = new Partida(lblIdPartidaCriada.Text, txtSenhaPartidaCriar.Text, txtNomePartida.Text);

            if (!verificarErro.VerificarNome(partida.Nome))
            {
                return;
            }

            if (!verificarErro.VerificarSenha(partida.Senha))
            {
                return;
            }

            partida.Id = Jogo.CriarPartida(partida.Nome, partida.Senha, "Juízes de Common Law");

            string retornoPartida = partida.Id.ToString();
            string[] dadosPartida = retornoPartida.Split(',');
            int idPartidaCriada = Convert.ToInt32(dadosPartida[0]);

            txtIdPartida.Text = idPartidaCriada.ToString();
            lblIdPartidaCriada.Text = idPartidaCriada.ToString();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            Partida partida = new Partida(lblIdPartidaCriada.Text, txtSenha.Text, txtNomePartida.Text);
            Jogador jogador = new Jogador(txtIDJogador.Text, lblSenhaJogador.Text, txtNomeJogador.Text);
            partida.Id = txtIdPartida.Text;

            if (!verificarErro.VerificarNome(jogador.Nome))
            {
                return;
            }

            if (!verificarErro.VerificarSenha(partida.Senha))
            {
                return;
            }

            if (!verificarErro.VerificarID(partida.Id))
            {
                return;
            }

            string entrarPartidaDados = jogador.EntrarPartida(partida.Id, partida.Senha);
            string retornoDados = entrarPartidaDados.ToString();
            string[] entrarPartida = retornoDados.Split(',');

            string idJogador = entrarPartida[0];
            string senhaJogador = entrarPartida[1];

            lblIdJogador.Text = idJogador;
            lblSenhaJogador.Text = senhaJogador;

            txtIDJogador.Text = idJogador;
            txtSenhaJogador.Text = senhaJogador;
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            string idJogadorString = txtIDJogador.Text;
            int idJogador = Convert.ToInt32(idJogadorString);
            string senhaJogador = txtSenhaJogador.Text;

            string vezJogadorDados = Jogo.Iniciar(idJogador, senhaJogador);
            string retornoDados = vezJogadorDados.ToString();
            string[] vezJogador = retornoDados.Split(',');

            string retornoVezJogador = vezJogador[0];
            lblVezJogador.Text = retornoVezJogador;
        }

        private void btnExibirCartas_Click(object sender, EventArgs e)
        {
            string idJogadorString = txtIDJogador.Text;
            int idJogador = Convert.ToInt32(idJogadorString);
            string senhaJogador = txtSenhaJogador.Text;

            string cartaJogador = Jogo.ListarCartas(idJogador, senhaJogador);
            string retornoCartaJogador = cartaJogador.ToString();
            lblMinhasCartas.Text = retornoCartaJogador;
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            Partida partida = new Partida(lblIdPartidaCriada.Text, txtSenha.Text, txtNomePartida.Text);
            lblIdPartidaCriada.Text = partida.Id;
            int idPartida = Convert.ToInt32(partida.Id);
            string retorno = Jogo.VerificarVez(idPartida);

            retorno = retorno.Replace("\r", "");
            string[] status = retorno.Split('\n');

            lstVerificarVez.Items.Clear();
            for (int i = 0; i < status.Length; i++)
            {
                lstVerificarVez.Items.Add(status[i]);
            }
        }

        private void btnColocarPersonagem_Click(object sender, EventArgs e)
        {
            // int jogador, string senha, int setor, string personagem
            Jogador jogador = new Jogador(lblIdJogador.Text, lblSenhaJogador.Text, txtNomeJogador.Text);
            int idJogador = Convert.ToInt32(jogador.Id);
            string senhaJogador = jogador.Senha;
            txtNomeJogador.Text = jogador.Nome;

            txtSetor.Text = tabuleiro.Setor.ToString();
            int idSetor = Convert.ToInt32(tabuleiro.Setor);

            txtSetorPersonagem.Text = personagem.Nome;
            string inicialPersonagem = personagem.Nome;

            string retorno = Jogo.ColocarPersonagem(idJogador, senhaJogador, idSetor, inicialPersonagem);
            retorno = retorno.Replace("\r", "");
            string[] status = retorno.Split('\n');

            // informações do jogador da vez
            lstVerificarVez.Items.Clear();
            for (int i = 0; i < status.Length; i++)
            {
                lstVerificarVez.Items.Add(status[i]);
            }
        }
    }
}
