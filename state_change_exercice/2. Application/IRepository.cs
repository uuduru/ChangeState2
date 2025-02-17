using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using state_change_exercice.Domain;

namespace state_change_exercice._2._Application
{
    public interface IRepository
    {
        bool AddObjects(ObjectEntity obj);
        void FindObjectById(Guid id);
        bool AddStateToObjectById(Guid id);

        void FindAllObjects();
    }
}
