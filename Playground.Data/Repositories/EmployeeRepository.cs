using System;
using System.Collections.Generic;
using System.Linq;

namespace Playground.Data.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public IEnumerable<Employee> All { get; }

        private readonly WebApiDbContext _context;

        public EmployeeRepository(WebApiDbContext context)
        {
            try
            {
                _context = context;
                All = _context.Employees.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Add(Employee entity)
        {
            try
            {
                Console.WriteLine(entity.Id + " - " + entity.Name);
                _context.Employees.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Delete(Employee entity)
        {
            try
            {
                _context.Employees.Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Update(Employee entity)
        {
            try
            {
                _context.Employees.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Employee FindById(int id)
        {
            try
            {
                return _context.Employees.ToList().SingleOrDefault(e => e.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}