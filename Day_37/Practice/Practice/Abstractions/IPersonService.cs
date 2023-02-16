using Practice.Models;

namespace Practice.Abstractions
{
    public interface IPersonService
    {
        Task<int> CreateAsync(Person person);
        Task<List<Person>> GetAllAsync();
    }
}
