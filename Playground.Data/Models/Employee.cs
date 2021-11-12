using System.ComponentModel.DataAnnotations;

namespace Playground.Data
{
    public class Employee : Person, IHasBalance
    {
        public decimal Balance { get; set; }

        public Employee()
        {
            
        }
        public Employee(int id, string firstname, string lastname, decimal balance = 0)
        {
            Id = id;
            Name = firstname;
            LastName = lastname;
            Balance = balance;
        }
    }
}