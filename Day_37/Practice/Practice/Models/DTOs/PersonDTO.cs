using Practice.Infastructure.Attributes;

namespace Practice.Models.DTOs
{
    public class PersonDTO
    {
        [GeorgianOnly]
        public string? FirstName { get; set; }

        [GeorgianOnly]
        public string? LastName { get; set; }
    }
}
