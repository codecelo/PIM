using System.Collections.Generic;
using PIM_API.Models;
using PIM_API.Repositories;

namespace PIM_API.Services
{
    public class ProducaoService
    {
        private readonly ProducaoRepository _producaoRepository;

        public ProducaoService(ProducaoRepository producaoRepository)
        {
            _producaoRepository = producaoRepository;
        }

        public void AdicionarProducao(Producao producao)
        {
            _producaoRepository.AdicionarProducao(producao);
        }

        public List<Producao> ObterTodasProducoes()
        {
            return _producaoRepository.ObterTodasProducoes();
        }

        public Producao ObterProducaoPorId(int producaoID)
        {
            return _producaoRepository.ObterProducaoPorId(producaoID);
        }

        public void AtualizarProducao(Producao producaoAtualizada)
        {
            _producaoRepository.AtualizarProducao(producaoAtualizada);
        }

        public void ExcluirProducao(int producaoID)
        {
            _producaoRepository.ExcluirProducao(producaoID);
        }
    }
}
