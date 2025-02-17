using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace state_change_exercice.Domain
{
    public class ObjectEntity
    {
       public Guid _Id {  get; private set; }
        public List<int> _states = [];
       public string _Description { get; private set; }

        public ObjectEntity() 
        {
            this._Id = Guid.NewGuid();
            this._states.Add(1);
            Console.WriteLine("The object ID is {0}", this._Id);
        }

        public ObjectEntity(string Description)
        {
            this._Description = Description;
        }
    }
}
