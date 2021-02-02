using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.Domain.Solicitations
{
    public class Solicitation
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public Solicitation(int? id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
