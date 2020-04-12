using System;

namespace ProjectOrder.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; private set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }
    }
}
