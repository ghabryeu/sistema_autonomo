﻿namespace sistema_autonomo_2._0
{
    partial class btnTabuleiro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.dgvListarPartidas = new System.Windows.Forms.DataGridView();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.dgvListarJogadores = new System.Windows.Forms.DataGridView();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.dgvVerificarVez = new System.Windows.Forms.DataGridView();
            this.btnVerificarVez = new System.Windows.Forms.Button();
            this.lblJogadorInicial = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.btnIniciarJogo = new System.Windows.Forms.Button();
            this.btnExibirCartas = new System.Windows.Forms.Button();
            this.lblCartas = new System.Windows.Forms.Label();
            this.btnColocarPersonagem = new System.Windows.Forms.Button();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtPersonagem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstSetores = new System.Windows.Forms.ListBox();
            this.lstPersonagens = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPromoverPersonagem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVotar = new System.Windows.Forms.TextBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.btnExibirVotacao = new System.Windows.Forms.Button();
            this.btnVerificarVezTabuleiro = new System.Windows.Forms.Button();
            this.tmrIniciar = new System.Windows.Forms.Timer(this.components);
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.chkHistorico = new System.Windows.Forms.CheckBox();
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPartidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerificarVez)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(27, 25);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(100, 20);
            this.txtNomePartida.TabIndex = 0;
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGrupo.ForeColor = System.Drawing.Color.IndianRed;
            this.txtNomeGrupo.Location = new System.Drawing.Point(27, 103);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.ReadOnly = true;
            this.txtNomeGrupo.Size = new System.Drawing.Size(143, 20);
            this.txtNomeGrupo.TabIndex = 1;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(27, 64);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaPartida.TabIndex = 2;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.Location = new System.Drawing.Point(27, 9);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(97, 14);
            this.lblNomePartida.TabIndex = 3;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.Location = new System.Drawing.Point(27, 48);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(97, 14);
            this.lblSenhaPartida.TabIndex = 4;
            this.lblSenhaPartida.Text = "Senha da Partida";
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGrupo.Location = new System.Drawing.Point(27, 87);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(92, 14);
            this.lblNomeGrupo.TabIndex = 5;
            this.lblNomeGrupo.Text = "Nome do Grupo";
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPartida.Location = new System.Drawing.Point(305, 50);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(77, 14);
            this.lblIdPartida.TabIndex = 6;
            this.lblIdPartida.Text = "Id da Partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(305, 66);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(100, 20);
            this.txtIdPartida.TabIndex = 7;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnCriarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarPartida.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCriarPartida.Location = new System.Drawing.Point(183, 23);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(72, 61);
            this.btnCriarPartida.TabIndex = 8;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // dgvListarPartidas
            // 
            this.dgvListarPartidas.BackgroundColor = System.Drawing.Color.Brown;
            this.dgvListarPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListarPartidas.Location = new System.Drawing.Point(27, 190);
            this.dgvListarPartidas.Name = "dgvListarPartidas";
            this.dgvListarPartidas.Size = new System.Drawing.Size(250, 105);
            this.dgvListarPartidas.TabIndex = 10;
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarPartidas.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartidas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarPartidas.Location = new System.Drawing.Point(27, 154);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(100, 30);
            this.btnListarPartidas.TabIndex = 11;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnListarJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarJogadores.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarJogadores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListarJogadores.Location = new System.Drawing.Point(27, 316);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(121, 30);
            this.btnListarJogadores.TabIndex = 12;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // dgvListarJogadores
            // 
            this.dgvListarJogadores.BackgroundColor = System.Drawing.Color.Brown;
            this.dgvListarJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarJogadores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListarJogadores.Location = new System.Drawing.Point(27, 352);
            this.dgvListarJogadores.Name = "dgvListarJogadores";
            this.dgvListarJogadores.Size = new System.Drawing.Size(250, 105);
            this.dgvListarJogadores.TabIndex = 13;
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(305, 25);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(100, 20);
            this.txtNomeJogador.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome do Jogador";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnEntrarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntrarPartida.Location = new System.Drawing.Point(438, 23);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(72, 61);
            this.btnEntrarPartida.TabIndex = 16;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Jogador";
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdJogador.Location = new System.Drawing.Point(302, 116);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(104, 14);
            this.lblIdJogador.TabIndex = 18;
            this.lblIdJogador.Text = "Id Jogador Criado";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.Location = new System.Drawing.Point(302, 154);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(124, 14);
            this.lblSenhaJogador.TabIndex = 19;
            this.lblSenhaJogador.Text = "Senha Jogador Criado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "Senha Jogador";
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(894, 461);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(44, 14);
            this.lblVersao.TabIndex = 21;
            this.lblVersao.Text = "Versão";
            // 
            // dgvVerificarVez
            // 
            this.dgvVerificarVez.BackgroundColor = System.Drawing.Color.Brown;
            this.dgvVerificarVez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerificarVez.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVerificarVez.Location = new System.Drawing.Point(305, 190);
            this.dgvVerificarVez.Name = "dgvVerificarVez";
            this.dgvVerificarVez.Size = new System.Drawing.Size(250, 105);
            this.dgvVerificarVez.TabIndex = 23;
            // 
            // btnVerificarVez
            // 
            this.btnVerificarVez.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnVerificarVez.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerificarVez.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarVez.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerificarVez.Location = new System.Drawing.Point(457, 152);
            this.btnVerificarVez.Name = "btnVerificarVez";
            this.btnVerificarVez.Size = new System.Drawing.Size(98, 32);
            this.btnVerificarVez.TabIndex = 24;
            this.btnVerificarVez.Text = "Verificar Vez";
            this.btnVerificarVez.UseVisualStyleBackColor = false;
            this.btnVerificarVez.Click += new System.EventHandler(this.btnVerificarVez_Click);
            // 
            // lblJogadorInicial
            // 
            this.lblJogadorInicial.AutoSize = true;
            this.lblJogadorInicial.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogadorInicial.Location = new System.Drawing.Point(480, 333);
            this.lblJogadorInicial.Name = "lblJogadorInicial";
            this.lblJogadorInicial.Size = new System.Drawing.Size(88, 14);
            this.lblJogadorInicial.TabIndex = 26;
            this.lblJogadorInicial.Text = "Jogador Inicial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(480, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "Jogador Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 28;
            this.label4.Text = "ID Jogador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 14);
            this.label6.TabIndex = 29;
            this.label6.Text = "Senha";
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(370, 313);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(100, 20);
            this.txtIdJogador.TabIndex = 30;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(346, 339);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(124, 20);
            this.txtSenhaJogador.TabIndex = 31;
            // 
            // btnIniciarJogo
            // 
            this.btnIniciarJogo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIniciarJogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarJogo.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarJogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciarJogo.Location = new System.Drawing.Point(305, 365);
            this.btnIniciarJogo.Name = "btnIniciarJogo";
            this.btnIniciarJogo.Size = new System.Drawing.Size(100, 35);
            this.btnIniciarJogo.TabIndex = 32;
            this.btnIniciarJogo.Text = "Iniciar Partida";
            this.btnIniciarJogo.UseVisualStyleBackColor = false;
            this.btnIniciarJogo.Click += new System.EventHandler(this.btnIniciarJogo_Click);
            // 
            // btnExibirCartas
            // 
            this.btnExibirCartas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnExibirCartas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibirCartas.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirCartas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExibirCartas.Location = new System.Drawing.Point(305, 422);
            this.btnExibirCartas.Name = "btnExibirCartas";
            this.btnExibirCartas.Size = new System.Drawing.Size(87, 35);
            this.btnExibirCartas.TabIndex = 33;
            this.btnExibirCartas.Text = "Exibir Cartas";
            this.btnExibirCartas.UseVisualStyleBackColor = false;
            this.btnExibirCartas.Click += new System.EventHandler(this.btnExibirCartas_Click);
            // 
            // lblCartas
            // 
            this.lblCartas.AutoSize = true;
            this.lblCartas.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartas.Location = new System.Drawing.Point(408, 433);
            this.lblCartas.Name = "lblCartas";
            this.lblCartas.Size = new System.Drawing.Size(43, 14);
            this.lblCartas.TabIndex = 34;
            this.lblCartas.Text = "Cartas";
            // 
            // btnColocarPersonagem
            // 
            this.btnColocarPersonagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnColocarPersonagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColocarPersonagem.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocarPersonagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColocarPersonagem.Location = new System.Drawing.Point(702, 23);
            this.btnColocarPersonagem.Name = "btnColocarPersonagem";
            this.btnColocarPersonagem.Size = new System.Drawing.Size(94, 61);
            this.btnColocarPersonagem.TabIndex = 35;
            this.btnColocarPersonagem.Text = "Colocar Personagem";
            this.btnColocarPersonagem.UseVisualStyleBackColor = false;
            this.btnColocarPersonagem.Click += new System.EventHandler(this.btnColocarPersonagem_Click);
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(581, 25);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(100, 20);
            this.txtSetor.TabIndex = 36;
            // 
            // txtPersonagem
            // 
            this.txtPersonagem.Location = new System.Drawing.Point(581, 66);
            this.txtPersonagem.Name = "txtPersonagem";
            this.txtPersonagem.Size = new System.Drawing.Size(100, 20);
            this.txtPersonagem.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 14);
            this.label7.TabIndex = 38;
            this.label7.Text = "Setor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 14);
            this.label8.TabIndex = 39;
            this.label8.Text = "Personagem";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(811, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 14);
            this.label9.TabIndex = 40;
            this.label9.Text = "Setor";
            // 
            // lstSetores
            // 
            this.lstSetores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSetores.BackColor = System.Drawing.Color.Brown;
            this.lstSetores.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSetores.ForeColor = System.Drawing.SystemColors.Window;
            this.lstSetores.FormattingEnabled = true;
            this.lstSetores.ItemHeight = 14;
            this.lstSetores.Location = new System.Drawing.Point(814, 25);
            this.lstSetores.Name = "lstSetores";
            this.lstSetores.Size = new System.Drawing.Size(120, 102);
            this.lstSetores.TabIndex = 41;
            // 
            // lstPersonagens
            // 
            this.lstPersonagens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPersonagens.BackColor = System.Drawing.Color.Brown;
            this.lstPersonagens.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPersonagens.ForeColor = System.Drawing.SystemColors.Window;
            this.lstPersonagens.FormattingEnabled = true;
            this.lstPersonagens.ItemHeight = 14;
            this.lstPersonagens.Location = new System.Drawing.Point(814, 160);
            this.lstPersonagens.Name = "lstPersonagens";
            this.lstPersonagens.Size = new System.Drawing.Size(120, 186);
            this.lstPersonagens.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(811, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 14);
            this.label10.TabIndex = 43;
            this.label10.Text = "Personagem";
            // 
            // btnPromoverPersonagem
            // 
            this.btnPromoverPersonagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnPromoverPersonagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPromoverPersonagem.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromoverPersonagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPromoverPersonagem.Location = new System.Drawing.Point(702, 92);
            this.btnPromoverPersonagem.Name = "btnPromoverPersonagem";
            this.btnPromoverPersonagem.Size = new System.Drawing.Size(94, 61);
            this.btnPromoverPersonagem.TabIndex = 44;
            this.btnPromoverPersonagem.Text = "Promover Personagem";
            this.btnPromoverPersonagem.UseVisualStyleBackColor = false;
            this.btnPromoverPersonagem.Click += new System.EventHandler(this.btnPromoverPersonagem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(578, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 14);
            this.label11.TabIndex = 47;
            this.label11.Text = "Votar (S/N)";
            // 
            // txtVotar
            // 
            this.txtVotar.Location = new System.Drawing.Point(581, 116);
            this.txtVotar.Name = "txtVotar";
            this.txtVotar.Size = new System.Drawing.Size(75, 20);
            this.txtVotar.TabIndex = 48;
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVotar.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVotar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVotar.Location = new System.Drawing.Point(581, 152);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(65, 29);
            this.btnVotar.TabIndex = 49;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // btnExibirVotacao
            // 
            this.btnExibirVotacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnExibirVotacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExibirVotacao.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirVotacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExibirVotacao.Location = new System.Drawing.Point(581, 190);
            this.btnExibirVotacao.Name = "btnExibirVotacao";
            this.btnExibirVotacao.Size = new System.Drawing.Size(161, 39);
            this.btnExibirVotacao.TabIndex = 50;
            this.btnExibirVotacao.Text = "Exibir Última Votação";
            this.btnExibirVotacao.UseVisualStyleBackColor = false;
            this.btnExibirVotacao.Click += new System.EventHandler(this.btnExibirVotacao_Click);
            // 
            // btnVerificarVezTabuleiro
            // 
            this.btnVerificarVezTabuleiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnVerificarVezTabuleiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerificarVezTabuleiro.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarVezTabuleiro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerificarVezTabuleiro.Location = new System.Drawing.Point(581, 244);
            this.btnVerificarVezTabuleiro.Name = "btnVerificarVezTabuleiro";
            this.btnVerificarVezTabuleiro.Size = new System.Drawing.Size(161, 39);
            this.btnVerificarVezTabuleiro.TabIndex = 51;
            this.btnVerificarVezTabuleiro.Text = "Verificar Vez + Tabuleiro";
            this.btnVerificarVezTabuleiro.UseVisualStyleBackColor = false;
            this.btnVerificarVezTabuleiro.Click += new System.EventHandler(this.btnVerificarVezTabuleiro_Click);
            // 
            // tmrIniciar
            // 
            this.tmrIniciar.Interval = 5000;
            this.tmrIniciar.Tick += new System.EventHandler(this.tmrIniciar_Tick);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimer.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimer.Location = new System.Drawing.Point(411, 365);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(89, 35);
            this.btnTimer.TabIndex = 52;
            this.btnTimer.Text = "Iniciar Timer";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(116)))), ((int)(((byte)(64)))));
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorico.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistorico.Location = new System.Drawing.Point(581, 295);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(138, 38);
            this.btnHistorico.TabIndex = 53;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // chkHistorico
            // 
            this.chkHistorico.AutoSize = true;
            this.chkHistorico.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHistorico.Location = new System.Drawing.Point(581, 339);
            this.chkHistorico.Name = "chkHistorico";
            this.chkHistorico.Size = new System.Drawing.Size(84, 18);
            this.chkHistorico.TabIndex = 54;
            this.chkHistorico.Text = "Formatado";
            this.chkHistorico.UseVisualStyleBackColor = true;
            // 
            // lstHistorico
            // 
            this.lstHistorico.BackColor = System.Drawing.Color.Brown;
            this.lstHistorico.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHistorico.ForeColor = System.Drawing.SystemColors.Window;
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.ItemHeight = 14;
            this.lstHistorico.Location = new System.Drawing.Point(581, 373);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(304, 102);
            this.lstHistorico.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(701, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 56;
            this.label12.Text = "Histórico";
            // 
            // btnTabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(946, 483);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lstHistorico);
            this.Controls.Add(this.chkHistorico);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnVerificarVezTabuleiro);
            this.Controls.Add(this.btnExibirVotacao);
            this.Controls.Add(this.btnVotar);
            this.Controls.Add(this.txtVotar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnPromoverPersonagem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstPersonagens);
            this.Controls.Add(this.lstSetores);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPersonagem);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.btnColocarPersonagem);
            this.Controls.Add(this.lblCartas);
            this.Controls.Add(this.btnExibirCartas);
            this.Controls.Add(this.btnIniciarJogo);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblJogadorInicial);
            this.Controls.Add(this.btnVerificarVez);
            this.Controls.Add(this.dgvVerificarVez);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.dgvListarJogadores);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.dgvListarPartidas);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.txtNomePartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "btnTabuleiro";
            this.Text = "King Me!";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPartidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarJogadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerificarVez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.DataGridView dgvListarPartidas;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.DataGridView dgvListarJogadores;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.DataGridView dgvVerificarVez;
        private System.Windows.Forms.Button btnVerificarVez;
        private System.Windows.Forms.Label lblJogadorInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Button btnIniciarJogo;
        private System.Windows.Forms.Button btnExibirCartas;
        private System.Windows.Forms.Label lblCartas;
        private System.Windows.Forms.Button btnColocarPersonagem;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.TextBox txtPersonagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstSetores;
        private System.Windows.Forms.ListBox lstPersonagens;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPromoverPersonagem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVotar;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.Button btnExibirVotacao;
        private System.Windows.Forms.Button btnVerificarVezTabuleiro;
        private System.Windows.Forms.Timer tmrIniciar;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.CheckBox chkHistorico;
        private System.Windows.Forms.ListBox lstHistorico;
        private System.Windows.Forms.Label label12;
    }
}

