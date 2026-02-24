namespace SistemaAtendimento
{
    partial class FrmTelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuTelaPrincipal = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            etapasToolStripMenuItem = new ToolStripMenuItem();
            situacaoAtendimentosToolStripMenuItem = new ToolStripMenuItem();
            atendimentosToolStripMenuItem = new ToolStripMenuItem();
            novoAtendimentoToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnConexao = new Button();
            statusStrip1 = new StatusStrip();
            slblNome = new ToolStripStatusLabel();
            slblPerfil = new ToolStripStatusLabel();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            listaDeClientesToolStripMenuItem = new ToolStripMenuItem();
            mnuTelaPrincipal.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuTelaPrincipal
            // 
            mnuTelaPrincipal.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, atendimentosToolStripMenuItem, sistemaToolStripMenuItem, relatóriosToolStripMenuItem });
            mnuTelaPrincipal.Location = new Point(0, 0);
            mnuTelaPrincipal.Name = "mnuTelaPrincipal";
            mnuTelaPrincipal.Size = new Size(800, 24);
            mnuTelaPrincipal.TabIndex = 0;
            mnuTelaPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, usuáriosToolStripMenuItem, etapasToolStripMenuItem, situacaoAtendimentosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(192, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(192, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // etapasToolStripMenuItem
            // 
            etapasToolStripMenuItem.Name = "etapasToolStripMenuItem";
            etapasToolStripMenuItem.Size = new Size(192, 22);
            etapasToolStripMenuItem.Text = "Etapas";
            etapasToolStripMenuItem.Click += etapasToolStripMenuItem_Click;
            // 
            // situacaoAtendimentosToolStripMenuItem
            // 
            situacaoAtendimentosToolStripMenuItem.Name = "situacaoAtendimentosToolStripMenuItem";
            situacaoAtendimentosToolStripMenuItem.Size = new Size(192, 22);
            situacaoAtendimentosToolStripMenuItem.Text = "Situação Atendimento";
            situacaoAtendimentosToolStripMenuItem.Click += situacaoAtendimentosToolStripMenuItem_Click;
            // 
            // atendimentosToolStripMenuItem
            // 
            atendimentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAtendimentoToolStripMenuItem, consultasToolStripMenuItem });
            atendimentosToolStripMenuItem.Name = "atendimentosToolStripMenuItem";
            atendimentosToolStripMenuItem.Size = new Size(94, 20);
            atendimentosToolStripMenuItem.Text = "Atendimentos";
            // 
            // novoAtendimentoToolStripMenuItem
            // 
            novoAtendimentoToolStripMenuItem.Name = "novoAtendimentoToolStripMenuItem";
            novoAtendimentoToolStripMenuItem.Size = new Size(144, 22);
            novoAtendimentoToolStripMenuItem.Text = "Atendimento";
            novoAtendimentoToolStripMenuItem.Click += novoAtendimentoToolStripMenuItem_Click;
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(144, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            consultasToolStripMenuItem.Click += consultasToolStripMenuItem_Click;
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // btnConexao
            // 
            btnConexao.Location = new Point(664, 391);
            btnConexao.Name = "btnConexao";
            btnConexao.Size = new Size(124, 23);
            btnConexao.TabIndex = 1;
            btnConexao.Text = "Teste Conexão";
            btnConexao.UseVisualStyleBackColor = true;
            btnConexao.Click += btnConexao_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { slblNome, slblPerfil });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // slblNome
            // 
            slblNome.Name = "slblNome";
            slblNome.Size = new Size(118, 17);
            slblNome.Text = "toolStripStatusLabel1";
            // 
            // slblPerfil
            // 
            slblPerfil.Name = "slblPerfil";
            slblPerfil.Size = new Size(118, 17);
            slblPerfil.Text = "toolStripStatusLabel2";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeClientesToolStripMenuItem });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // listaDeClientesToolStripMenuItem
            // 
            listaDeClientesToolStripMenuItem.Name = "listaDeClientesToolStripMenuItem";
            listaDeClientesToolStripMenuItem.Size = new Size(180, 22);
            listaDeClientesToolStripMenuItem.Text = "Lista de Clientes";
            listaDeClientesToolStripMenuItem.Click += listaDeClientesToolStripMenuItem_Click;
            // 
            // FrmTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(btnConexao);
            Controls.Add(mnuTelaPrincipal);
            MainMenuStrip = mnuTelaPrincipal;
            Name = "FrmTelaPrincipal";
            Text = "Sistema de Atendimento";
            FormClosed += FrmTelaPrincipal_FormClosed;
            Load += FrmTelaPrincipal_Load;
            mnuTelaPrincipal.ResumeLayout(false);
            mnuTelaPrincipal.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuTelaPrincipal;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem etapasToolStripMenuItem;
        private ToolStripMenuItem situacaoAtendimentosToolStripMenuItem;
        private ToolStripMenuItem atendimentosToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem novoAtendimentoToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnConexao;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel slblNome;
        private ToolStripStatusLabel slblPerfil;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem listaDeClientesToolStripMenuItem;
    }
}
