using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Playground.Data;
using Playground.Data.Repositories;

namespace Playground.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepository<Employee> _context;

        public EmployeesController(IRepository<Employee> contextEmployees)
        {
            _context = contextEmployees;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _context.All;
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
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
        public void Add([FromQuery] Employee employee)
        {
            try
            {
                _context.Add(employee);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromQuery] Employee employee)
        {
            try
            {
                _context.Update(employee);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id, [FromQuery] Employee employee)
        {
            try
            {
                _context.Delete(employee);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}