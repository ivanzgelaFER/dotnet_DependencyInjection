using wintership_2024_dotNET.DAL.Dtos;

namespace DemoExercise2.Services.PersonService
{
    public interface IPersonService
    {

        public List<PersonDto> GetPersons();
    }
}
