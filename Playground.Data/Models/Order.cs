using System.Transactions;

namespace Playground.Data
{
    public class Order
    {
        public int Id { get; set; }
        private Person p1;
        private Person p2;

        public Order()
        {
            
        }
        public bool DoTransaction(IHasBalance @from, IHasBalance to, decimal money)
        {
            if (@from.Balance < money)
                return false;
            @from.Balance -= money;
            to.Balance += money;
            return true;
        }
    }
    
}