using Microsoft.Data.SqlClient;
using SistemaAtendimento.Database;
using SistemaAtendimento.Model;
using SistemaAtendimento.View;

namespace SistemaAtendimento
{
        
    public partial class FrmTelaPrincipal : Form
    {

        private Usuarios _usuarioLogado;

        public FrmTelaPrincipal(Usuarios usuario)
        {
            InitializeComponent();

            _usuarioLogado = usuario;
           
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexao = ConexaoDB.GetConexao())
                {
                    conexao.Open();
                    MessageBox.Show("Conexão Realizada com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar:" + ex.Message);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadastroCliente = new FrmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(_usuarioLogado.Perfil != "admin")
            {
                MessageBox.Show("Você não tem permissão para acessar esta função.");
                return;
            }

            FrmCadastroUsuario frmCadastroUsuario = new FrmCadastroUsuario();
            frmCadastroUsuario.Show();


        }

        private void novoAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtendimento frmAtendimento = new FrmAtendimento();
            frmAtendimento.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.Show();
        }

        private void etapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroEtapa frmCadastroEtapa = new FrmCadastroEtapa();
            frmCadastroEtapa.Show();
        }

        private void situacaoAtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroSituacaoAtendimento frmCadastroSituacaoAtendimento = new FrmCadastroSituacaoAtendimento();
            frmCadastroSituacaoAtendimento.Show();
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {
            slblNome.Text = $"Usuário: {_usuarioLogado.Nome}";
            slblPerfil.Text = $"Perfil: {_usuarioLogado.Perfil}";

        }

        private void FrmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
