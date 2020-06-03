using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string name, string email)
        {
            AddNotifications(
                new Contract()
                    .Requires()
                    .IsNotNullOrEmpty(name, "Name", "Nome do cliente não pode ser vazio")   
            );
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}