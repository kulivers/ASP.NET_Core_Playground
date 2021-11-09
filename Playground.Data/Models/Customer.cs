namespace Playground.Data
{
    public class Customer : Person, IHasBalance
    {
        public decimal Balance { get; set; }

        public Customer()
        {
            
        }
        public Customer(int id, string firstname, string lastname, decimal balance = 1000)
        {
            Id = id;
            Name = firstname;
            LastName = lastname;
            Balance = balance;
        }
    }
}