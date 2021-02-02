using rm_api.Domain.Solicitations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.Application.Solicitations.Models
{
    public class SolicitationModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public SolicitationModel(Solicitation solicitation)
        {
            Id = solicitation.Id;
            Name = solicitation.Name;
        }
    }
}

