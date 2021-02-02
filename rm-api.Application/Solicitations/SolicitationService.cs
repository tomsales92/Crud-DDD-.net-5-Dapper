using rm_api.Application.Solicitations.Models;
using rm_api.Application.Solicitations.Request;
using rm_api.Domain.Solicitations;
using rm_api.Domain.Solicitations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.CommonModels;

namespace rm_api.Application.Solicitations
{
    public class SolicitationService : ISolicitationService
    {
        private readonly ISolicitationsRepository _solicitationsRepository;

        public SolicitationService(ISolicitationsRepository solicitationsRepository)
        {
            _solicitationsRepository = solicitationsRepository;
        }

        public async Task<SolicitationModel> Create(RegisterSolicitationRequest request)
        {
            var teste = request.ForEntity();
            _solicitationsRepository.Create(teste);
            return new SolicitationModel(teste);
        }

        public void Delete(int id)
        {
            _solicitationsRepository.Delete(id);
        }

        public SolicitationModel Get(int id)
        {
            var solicitation =  _solicitationsRepository.Get(id);
            return new SolicitationModel(solicitation);

        }

        public IEnumerable<SolicitationModel> GetAll()
        {
            var solicitaions =  _solicitationsRepository.GetAll();

            return solicitaions.Select(x => new SolicitationModel(x)).ToList();
           
        }

        public async Task<SolicitationModel> Update(EditSolicitationRequest request)
        {
            var teste = request.ForEntity();
            _solicitationsRepository.Update(teste);
            return new SolicitationModel(teste);
        }
    }
}
