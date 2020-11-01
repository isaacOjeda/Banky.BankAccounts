using Banky.BankAccounts.Application.Common.Models;

namespace Banky.BankAccounts.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        UserModel User { get; }
    }
}