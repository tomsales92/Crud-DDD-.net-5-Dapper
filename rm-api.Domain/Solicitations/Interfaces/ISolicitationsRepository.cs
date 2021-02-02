using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.Domain.Solicitations.Interfaces
{
    public interface ISolicitationsRepository
    {
        IEnumerable<Solicitation> GetAll();
        Solicitation Get(int id);
        void Create(Solicitation solicitation);
        void Update(Solicitation solicitation);
        void Delete(int id);

    }
}
