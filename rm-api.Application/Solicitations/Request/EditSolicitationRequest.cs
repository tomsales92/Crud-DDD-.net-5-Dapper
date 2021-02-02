using rm_api.Domain.Solicitations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.Application.Solicitations.Request
{
    public class EditSolicitationRequest

    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Solicitation ForEntity()
        {
            int id = Id;
            var name = Name;

            return new Solicitation(id, name);
        }
    }
}
