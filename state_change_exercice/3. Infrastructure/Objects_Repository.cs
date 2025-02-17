using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using state_change_exercice._2._Application;
using state_change_exercice.Domain;


namespace state_change_exercice.Infrastructure
{
    public class Objects_Repository : IRepository
    {
        private List<ObjectEntity> _Global_Objects = [];

        /// <summary>
        /// This method Adds ObjectEntity to the Local Repo
        /// </summary>
        /// <param name="obj"></param>
        public bool AddObjects(ObjectEntity obj)
        { 
            _Global_Objects.Add(obj);
            return true;
        }

        /// <summary>
        /// This method finds objects by Id in the Local Repo 
        /// </summary>
        /// <param name="id"></param>
        public void FindObjectById(Guid id)
        {
            foreach (var obj in _Global_Objects) 
            {
                if(obj._Id == id)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Id: {0}\n Description: {1}", obj._Id, obj._Description);
                    Console.WriteLine("States:\n");
                    foreach (var obj2 in obj._states) 
                    {
                        Console.WriteLine("State {0}\n", obj2);
                    }
                }
            }
        }


        /// <summary>
        /// This method adds a state to an object by ID
        /// </summary>
        /// <param name="id"></param>
        public bool AddStateToObjectById(Guid id)
        {
            var status = false;
            foreach (var obj in _Global_Objects)
            {
                if (obj._Id == id)
                {
                    obj._states.Add(obj._states.Count + 1);
                    status = true;
                }
            }

            return status;
        }

        /// <summary>
        /// This method returns all the objects in the Local Repo
        /// </summary>
        public void FindAllObjects()
        {
            foreach (var obj in _Global_Objects)
            {

                Console.WriteLine("\n");
                Console.WriteLine("Id: {0}\n Description: {1}", obj._Id, obj._Description);
                Console.WriteLine("States:\n");
                    foreach (var obj2 in obj._states)
                    {
                        Console.WriteLine("State {0}\n", obj2);
                    }
            }
        }


    }
}
