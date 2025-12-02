using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Costumer : BaseEntity<int>
    {

        public Costumer() : base(0)
        {
        }

        public Costumer(int id, string name, string address, string document, string district, City city) : base(id)
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