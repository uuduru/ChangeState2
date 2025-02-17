using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using state_change_exercice.Domain;

namespace state_change_exercice._2._Application
{
    public class ChangeStateService
    {
        private readonly IRepository _states_repo;
        public ChangeStateService() { }

        public ChangeStateService(IRepository states_repo) 
        { 
            _states_repo = states_repo;
        }

        public void AddState(Guid Id)
        {
            _states_repo.AddStateToObjectById(Id);
        }

        public void CreateState()
        {
            var new_object = new ObjectEntity();
            _states_repo.AddObjects(new_object);
        }

        public void ViewStates()
        {
            _states_repo.FindAllObjects();
        }
    }

}
