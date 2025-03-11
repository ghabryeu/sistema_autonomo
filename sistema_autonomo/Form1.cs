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
        Jogador jogador = new Jogador();
        Partida partida = new Partida();
        Erro verificarErro = new Erro();

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
            partida.nome = txtNomePartida.Text;

            if (!verificarErro.VerificarNome(partida.nome))
            {
                return;
            }

            partida.senha = txtSenhaPartidaCriar.Text;
            partida.id = Jogo.CriarPartida(partida.nome, partida.senha, "Juízes de Common Law");

            string retornoPartida = partida.id.ToString();
            string[] dadosPartida = retornoPartida.Split(',');
            int idPartidaCriada = Convert.ToInt32(dadosPartida[0]);

            txtIdPartida.Text = idPartidaCriada.ToString();
            lblIdPartidaCriada.Text = idPartidaCriada.ToString();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            jogador.nome = txtNomeJogador.Text;

            if (!verificarErro.VerificarNome(jogador.nome))
            {
                return;
            }

            partida.senha = txtSenha.Text;
            partida.id = txtIdPartida.Text;

            string entrarPartidaDados = jogador.EntrarPartida(partida.id, partida.senha);
            string retornoDados = entrarPartidaDados.ToString();
            string[] entrarPartida = retornoDados.Split(',');

            string idJogador = entrarPartida[0];
            string senhaJogador = entrarPartida[1].ToString();

            lblIdJogador.Text = idJogador;
            lblSenhaJogador.Text = senhaJogador;
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
    }
}
