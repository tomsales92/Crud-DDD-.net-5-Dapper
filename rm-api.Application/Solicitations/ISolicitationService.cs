using rm_api.Application.Solicitations.Models;
using rm_api.Application.Solicitations.Request;
using rm_api.Domain.Solicitations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.CommonModels;

namespace rm_api.Application.Solicitations
{
    public interface ISolicitationService
    {
        SolicitationModel Get(int id);
        IEnumerable<SolicitationModel> GetAll();
        Task<SolicitationModel> Create(RegisterSolicitationRequest request);
        Task<SolicitationModel> Update(EditSolicitationRequest request);
        void Delete(int id);




    }

}
