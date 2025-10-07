using IFSPStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Domain.Entities
{
    public class City : BaseEntity<int>
    {
        public City()
        {
            
        }
        public City(int id, string name, string state) : base(id)
        {
            Name = name;
            State = state;
        }

        public string Name { get; set; }
        public string State { get; set; }
    }
}

