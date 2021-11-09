using System.Collections.Generic;
using System.Linq;

namespace Playground.Data.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        public IEnumerable<Customer> All { get; }

        private readonly WebApiDbContext _context;

        public CustomerRepository(WebApiDbContext context)
        {
            _context = context;
            All = _context.Customers.ToList();
        }

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _context.Customers.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Customer entity)
        {
            _context.Customers.Update(entity);
            _context.SaveChanges();
        }

        public Customer FindById(int id)
        {
            return _context.Customers.ToList().SingleOrDefault(e => e.Id == id);
        }
    }
}