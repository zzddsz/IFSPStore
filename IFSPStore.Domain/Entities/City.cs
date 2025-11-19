using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class City : BaseEntity<int>
    {
        public City()
        {
        }

        public City(int id, string name, string state)
        {
            this.Id = id;
            this.Name = name;
            this.State = state;
        }

        public string? Name { get; set; }
        public string? State { get; set; }
    }
}