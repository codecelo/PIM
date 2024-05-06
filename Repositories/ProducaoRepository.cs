using System.Collections.Generic;
using System.Linq;
using PIM_API.Models;

namespace PIM_API.Repositories
{
    public class ProducaoRepository
    {
        private List<Producao> producoes;
        private static int proximoID = 1;

        public ProducaoRepository()
        {
            producoes = new List<Producao>();
        }

        public void AdicionarProducao(Producao producao)
        {
            producao.ProducaoID = proximoID++;
            producoes.Add(producao);
        }

        public List<Producao> ObterTodasProducoes()
        {
            return producoes;
        }

        public void AtualizarProducao(Producao producaoAtualizada)
        {
            Producao producaoExistente = producoes.FirstOrDefault(p => p.ProducaoID == producaoAtualizada.ProducaoID);
            if (producaoExistente != null)
            {
                producaoExistente.DataProducao = producaoAtualizada.DataProducao;
                producaoExistente.QuantidadeProduzida = producaoAtualizada.QuantidadeProduzida;
                producaoExistente.MetodoProducao = producaoAtualizada.MetodoProducao;
                producaoExistente.InsumoID = producaoAtualizada.InsumoID;
                producaoExistente.Observacoes = producaoAtualizada.Observacoes;
            }
        }

        public void ExcluirProducao(int producaoID)
        {
            Producao producaoExistente = producoes.FirstOrDefault(p => p.ProducaoID == producaoID);
            if (producaoExistente != null)
            {
                producoes.Remove(producaoExistente);
            }
        }

        public Producao ObterProducaoPorId(int producaoId)
        {
            return producoes.FirstOrDefault(p => p.ProducaoID == producaoId);
        }

    }
}
