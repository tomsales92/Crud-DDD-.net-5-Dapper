using rm_api.Domain.Solicitations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.Application.Solicitations.Builders
{
    public class SolicitationsFactory
    {
        public static Solicitation Create(Solicitation customer)
        {
            return new Solicitation(null, customer.Name);
        }
    }

}