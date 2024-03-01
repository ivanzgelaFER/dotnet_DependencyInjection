
namespace wintership_2024_dotNET.DAL.Dtos
{
    public class PersonDto
    {
        public required int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public List<AccoutDto> Accounts { get; set; } = new List<AccoutDto>();
    }
}
