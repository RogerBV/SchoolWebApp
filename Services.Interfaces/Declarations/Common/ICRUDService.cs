using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Declarations.Common
{
    public interface ICRUDService<DTOCreate,DTOUpdate,DTORegistered>
    {
        DTORegistered Create(DTOCreate newRegistry);
        List<DTORegistered> List();
        DTORegistered Update(DTOUpdate updateRegistry);
        void Delete(int Id);

    }
}
