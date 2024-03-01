using DemoExercise2.Repository;
using wintership_2024_dotNET.DAL.Dtos;

namespace DemoExercise2.Services.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly AccountRepository _accountRepository;
        public AccountService(AccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public List<AccoutDto> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }
    }
}
