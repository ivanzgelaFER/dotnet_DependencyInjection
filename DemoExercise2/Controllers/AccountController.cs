using DemoExercise2.Services.AccountService;
using DemoExercise2.Services.PersonService;
using Microsoft.AspNetCore.Mvc;
using wintership_2024_dotNET.DAL.Dtos;

namespace DemoExercise2.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("accounts")]
        public List<AccoutDto> GetAccounts()
        {
            return _accountService.GetAccounts();
        }
    }
}
