using System.Threading;
using System.Threading.Tasks;

namespace Banky.BankAccounts.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}