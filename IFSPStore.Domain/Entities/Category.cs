using IFSPStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IFSPStore.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category()
        {
            
        }
        public Category(int id, string name) : base(id)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
