using IFSPStore.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IFSPStore.Domain.Entities
{
        public class Customer : BaseEntity<int>
        {
        public Customer()
        {
            
        }
        public Customer(int id, string name, string address, string document, string district, City city) : base(id)
        {
                Name = name;
                Address = address;
                Document = document;
                District = district;
                City = city;
            }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Document { get; set; }
            public string District { get; set; }
            public City City { get; set; }
        }
    }
