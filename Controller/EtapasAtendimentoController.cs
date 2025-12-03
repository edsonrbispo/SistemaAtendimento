using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class EtapasAtendimentoController
    {
        private EtapasAtendimentoRepository _etapasAtendimentoRepository;
        private FrmAtendimento _frmAtendimento;

        public EtapasAtendimentoController(FrmAtendimento view) 
        { 
            _frmAtendimento = view;
            _etapasAtendimentoRepository = new EtapasAtendimentoRepository();            
        }

        public List<EtapasAtendimentos> Listar(int atendimentoId) 
        { 
            return _etapasAtendimentoRepository.Listar(atendimentoId);
        }

        public void Salvar(EtapasAtendimentos etapaAtendimento)
        {
            try
            {
                _etapasAtendimentoRepository.Inserir(etapaAtendimento);
                _frmAtendimento.ExibirMensagem("Atendimento Etapa Salvo com Sucesso!");
            }
            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem($"Erro ao Cadastrar o Atendimento Etapa: {ex.Message}");
            }
        }

        public void Excluir(int id)
        {
            try
            {
                _etapasAtendimentoRepository.Excluir(id);
                _frmAtendimento.ExibirMensagem("Atendimento Etapa Excluído com Sucesso!");
            }
            catch (Exception ex)
            {
                _frmAtendimento.ExibirMensagem($"Erro ao Excluir o Atendimento Etapa: {ex.Message}");
            }
        }
    }
}
