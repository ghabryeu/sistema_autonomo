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
        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.versao; // versão da dll

            // itens da combobox
            cboTipoPartida.Items.Add("Todos");
            cboTipoPartida.Items.Add("Abertas");
            cboTipoPartida.Items.Add("Jogando");
            cboTipoPartida.Items.Add("Encerrando");
            cboTipoPartida.SelectedIndex = 0;

            // nome do grupo fixado 
            txtNomeGrupo.Text = "Juízes de Common Law";
        }

        private void btnListarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            lstPartidas.Items.Clear();
            for(int i = 0; i < partidas.Length - 1; i++)
            {
                lstPartidas.Items.Add(partidas[i]);
            }
        }

        private void btnListarJogadores_Click(object sender, EventArgs e)
        {
            string partida = lstPartidas.SelectedItem.ToString();
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
            string nomePartida = txtNomePartida.Text;
            string senhaPartidaCriar = txtSenhaPartidaCriar.Text;
            string idPartida = Jogo.CriarPartida(nomePartida, senhaPartidaCriar, "Juízes de Common Law");

            string partida = idPartida.ToString();
            string[] dadosPartida = partida.Split(',');
            int idPartidaCriada = Convert.ToInt32(dadosPartida[0]);

            txtIdPartida.Text = idPartidaCriada.ToString();
            lblIdPartidaCriada.Text = idPartidaCriada.ToString();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string nomeJogador = txtNomeJogador.Text;
            string senhaPartida = txtSenha.Text;
            string idPartidaString = txtIdPartida.Text;
            int idPartida = Convert.ToInt32(idPartidaString);

            string retornoEntrar = Jogo.Entrar(idPartida, nomeJogador, senhaPartida);
            string entrarPartidaDadosString = idPartida.ToString();
            string[] entrarPartidaDados = retornoEntrar.Split(',');

            string idJogador = entrarPartidaDados[0];
            string senhaJogador = entrarPartidaDados[1].ToString();

            lblIdJogador.Text = idJogador;
            lblSenhaJogador.Text = senhaJogador;
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            string idJogadorString = txtIDJogador.Text;
            int idJogador = Convert.ToInt32(idJogadorString);
            string senhaJogador = txtSenhaJogador.Text;
            string vezJogador = Jogo.Iniciar(idJogador, senhaJogador);

            // mudar status da partidade de A para J

        }
    }
}
