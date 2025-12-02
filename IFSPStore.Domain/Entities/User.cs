using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class User : BaseEntity<int>
    {

        public User() : base(0)
        {
        }
        public User(int id, string name, string password, string login, string email, DateTime registerDate, DateTime loginDate, bool isActive) : base(id)
        {
            Name = name;
            Password = password;
            Login = login;
            Email = email;
            RegisterDate = registerDate;
            LoginDate = loginDate;
            IsActive = isActive;
        }

        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LoginDate { get; set; }
        public bool IsActive { get; set; }
    }
}