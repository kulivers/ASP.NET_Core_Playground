using System;

namespace EntityTesting.Services
{
    public interface IPersonProvider
    {
        string Born { get; set; }
        string Name { get; set; }
    }

    public class PersonInfoProvider : IPersonProvider
    {
        public PersonInfoProvider(ITime time)
        {
            Name = "Name of person";
            Born = time.GetTime();
        }

        public string Born { get; set; }
        public string Name { get; set; }
    }
}