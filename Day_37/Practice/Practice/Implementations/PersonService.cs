using Practice.Abstractions;
using Practice.Models;

namespace Practice.Implementations
{
    public class PersonService : IPersonService
    {
        private static List<Person> _persons = new List<Person>()
        {
            new Person()
            {
                Id = 1, FirstName = "გიორგი", LastName = "ჩიქოვანი"
            },
            new Person()
            {
                Id = 2, FirstName = "ნათია", LastName = "გავაშელიშვილი"
            },
            new Person()
            {
                Id = 3, FirstName = "თეკლა", LastName = "გორეზიანი"
            },
        };

        public async Task<int> CreateAsync(Person person)
        {
            var id = _persons.Max(x => x.Id) + 1;
            person.Id = id;
            _persons.Add(person);

            return await Task.FromResult(id);
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await Task.FromResult(_persons);
        }
    }
}
