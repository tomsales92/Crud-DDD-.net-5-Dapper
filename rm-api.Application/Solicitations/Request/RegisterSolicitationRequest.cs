using rm_api.Application.Solicitations.Builders;
using rm_api.Application.Solicitations.Models;
using rm_api.Domain.Solicitations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.Application.Solicitations.Request
{
    public class RegisterSolicitationRequest
    {
        public int Id { get; set; }
        public string Name { get; set;}


        public Solicitation ForEntity()
        {
            var name = Name;

            return new Solicitation(null, name);
        }
        

    }
}
