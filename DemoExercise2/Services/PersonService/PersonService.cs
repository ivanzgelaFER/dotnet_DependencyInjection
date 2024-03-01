using DemoExercise2.Repository;
using wintership_2024_dotNET.DAL.Dtos;

namespace DemoExercise2.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly PersonRepository _personRepository;
        public PersonService(PersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public List<PersonDto> GetPersons()
        {
            return _personRepository.GetPersons();
        }
    }
}
