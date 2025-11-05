using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmAtendimento : Form
    {

        private AtendimentoController _atendimentoController;

        public FrmAtendimento()
        {
            InitializeComponent();
            _atendimentoController = new AtendimentoController(this);
        }


        private void btnPesquisarAtendimento_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.ShowDialog();
        }


        private void CarregarClientes()
        {
            var clientes = _atendimentoController.ListarClientes();

            cbxNomeCliente.DataSource = clientes;
            cbxNomeCliente.DisplayMember = "Nome";
            cbxNomeCliente.SelectedIndex = -1;
            cbxNomeCliente.ValueMember = "Id";
            //Filtros no Combobox
            cbxNomeCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNomeCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void CarregarEtapas()
        {
            var etapas = _atendimentoController.ListarEtapas();

            cbxEtapaAtendimento.DataSource = etapas;
            cbxEtapaAtendimento.DisplayMember = "Nome";
            cbxEtapaAtendimento.SelectedIndex = -1;
            cbxEtapaAtendimento.ValueMember = "Id";


        }

        private void CarregarSituacaoAtendimento()
        {
            var situacaoAtendimentos = _atendimentoController.ListarSituacaoAtendimento();

            cbxSituacaoAtendimento.DataSource = situacaoAtendimentos;
            cbxSituacaoAtendimento.DisplayMember = "Nome";
            cbxSituacaoAtendimento.SelectedIndex = -1;
            cbxSituacaoAtendimento.ValueMember = "Id";


        }

        private void FrmAtendimento_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarEtapas();
            CarregarSituacaoAtendimento();
        }

        private void cbxNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoCliente.Clear();

            if (cbxNomeCliente.SelectedValue != null)
            {
                txtCodigoCliente.Text = cbxNomeCliente.SelectedValue.ToString();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            cbxNomeCliente.Enabled = true;
            dtpAberturaAtendimento.Enabled = true;
            cbxSituacaoAtendimento.Enabled = true;
            txtObservacaoAtendimento.ReadOnly = false;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesativarCampos();
        }

        private void DesativarCampos()
        {
            LimparCampos();
            cbxNomeCliente.Enabled = false;
            dtpAberturaAtendimento.Enabled = false;
            cbxSituacaoAtendimento.Enabled = false;
            txtObservacaoAtendimento.ReadOnly = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void LimparCampos()
        {
            txtCodigoCliente.Clear();
            cbxNomeCliente.SelectedIndex = -1;
            cbxSituacaoAtendimento.SelectedIndex = -1;
            txtObservacaoAtendimento.Clear();
            dtpAberturaAtendimento.Value = DateTime.Now;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Atendimentos atendimento = new Atendimentos
            {
                ClienteId = Convert.ToInt32(txtCodigoCliente.Text),
                UsuarioId = 1,
                SituacaoAtendimentoId = Convert.ToInt32(cbxSituacaoAtendimento.SelectedValue),
                DataAbertura = dtpAberturaAtendimento.Value,
                Observacao = txtObservacaoAtendimento.Text
            };

            if(!ValidarDados(atendimento)) 
                return;
        }

        private bool ValidarDados(Atendimentos atendimento)
        {
            //Criar Regras de Validação de Campos
            
            return true;
        }
    }
}
