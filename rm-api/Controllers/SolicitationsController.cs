using Microsoft.AspNetCore.Mvc;
using rm_api.Application.Solicitations;
using rm_api.Application.Solicitations.Models;
using rm_api.Application.Solicitations.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rm_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitationsController : ControllerBase
    {
        private readonly ISolicitationService _solicitationService;

        public SolicitationsController(ISolicitationService solicitationService)
        {
            _solicitationService = solicitationService;
        }

        // GET: api/<SolicitationsController>
        [HttpGet]
        public IEnumerable<SolicitationModel> GetAll() => _solicitationService.GetAll();

        // GET api/<SolicitationsController>/5
        [HttpGet("{id}")]
        public SolicitationModel Get(int id) => _solicitationService.Get(id);

        // POST api/<SolicitationsController>
        [HttpPost]
        public async Task<SolicitationModel> Create([FromBody] RegisterSolicitationRequest request) => await _solicitationService.Create(request);

        // PUT api/<SolicitationsController>/5
        [HttpPut("{id}")]
        public async Task<SolicitationModel> Update([FromBody] EditSolicitationRequest request) => await _solicitationService.Update(request);

        // Delete api/<SolicitationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) => _solicitationService.Delete(id);

    }
}
