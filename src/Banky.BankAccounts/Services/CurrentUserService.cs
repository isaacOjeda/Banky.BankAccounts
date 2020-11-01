using Banky.BankAccounts.Application.Common.Interfaces;
using Banky.BankAccounts.Application.Common.Models;

namespace Banky.BankAccounts.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public UserModel User { get; set; }
    }
}