using DemoExercise2.Services.PersonService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wintership_2024_dotNET.DAL.Dtos;

namespace DemoExercise2.Controllers
{
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService) { 
            _personService = personService;
        }

        [HttpGet("persons")]
        public List<PersonDto> GetPersons()
        {
            return _personService.GetPersons();  
        }
    }
}
