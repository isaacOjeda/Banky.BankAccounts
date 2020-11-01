
using System.Threading.Tasks;

namespace Banky.BankAccounts.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {


        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            // Seed, if necessary
            await Task.FromResult(0);
        }

    }
}