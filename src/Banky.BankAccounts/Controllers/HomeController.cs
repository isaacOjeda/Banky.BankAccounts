using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace Banky.BankAccounts.Controllers
{
    [Route("/")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public IActionResult Home() =>
            Ok(new
            {
                Name = "Banky.BankAccounts",
                Version = typeof(Program).Assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version,
                Message = "Hello Stranger"
            });
    }
}