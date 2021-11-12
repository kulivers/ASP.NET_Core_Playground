using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Playground.Data;
using Playground.Data.Repositories;

namespace Playground.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IRepository<Customer> _context;

        public CustomersController(IRepository<Customer> contextCustomers)
        {
            _context = contextCustomers;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.All;
        }

        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            try
            {
                return _context.FindById(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public void Add([FromBody] Customer Customer)
        {
            try
            {
                Console.WriteLine(Customer.Id + " - " + Customer.Name);
                _context.Add(Customer);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromQuery] Customer Customer)
        {
            try
            {
                _context.Update(Customer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id, [FromQuery] Customer Customer)
        {
            try
            {
                _context.Delete(Customer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

}