using System.ComponentModel.DataAnnotations;

namespace Playground.Data
{
    public class TestGuy
    {
        [field: Key] public int Id { get; set; }
        public string Name { get; }
        public int Age { get; }

        public TestGuy()
        {
            
        }
        public TestGuy(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}