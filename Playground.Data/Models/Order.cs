using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace Playground.Data
{
    public class Order
    {
        [Key] public int Id { get; set; }
        private Person P1 { get; }
        private Person P2 { get; }
        public decimal Money { get; set; }

        public Order(Person p1, Person p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public bool DoTransaction(IHasBalance @from, IHasBalance to, decimal money)
        {
            if (@from.Balance < money)
                return false;
            Money = money;
            @from.Balance -= money;
            to.Balance += money;
            return true;
        }
    }
}