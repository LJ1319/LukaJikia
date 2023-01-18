using Mapster;
using Microsoft.AspNetCore.Mvc;
using Practice.Abstractions;
using Practice.Models;
using Practice.Models.DTOs;

namespace Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(PersonDTO person)
        {
            var personToCreate = person.Adapt<Person>();

            var newId = await _personService.CreateAsync(personToCreate);

            return Ok(newId);
        }

        [HttpGet]
        public async Task<List<PersonDTO>> GetAll()
        {
            var result = await _personService.GetAllAsync();

            return result.Adapt<List<PersonDTO>>();
        }
    }
}
