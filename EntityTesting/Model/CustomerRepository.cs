using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityTesting.Models
{
    public class CustomerRepository : IRepository<Customer>, IDisposable
    {
        private AdventureDbContext _context;

        public CustomerRepository()
        {
            _context = new AdventureDbContext();
        }

        public IEnumerable<Customer> All => _context.Customers;

        public AdventureDbContext GetContext()
        {
            return _context;
        }
        public void Add(Customer e)
        {
            _context.Customers.Add(e);
            _context.SaveChanges();
        }

        public void Update(Customer e)
        {
            _context.Update(e);
            _context.SaveChanges();
        }

        public void Delete(Customer e)
        {
            _context.Remove(e);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}