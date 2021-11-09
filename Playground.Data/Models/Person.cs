using System.ComponentModel.DataAnnotations;

namespace Playground.Data
{
    public abstract class Person
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}