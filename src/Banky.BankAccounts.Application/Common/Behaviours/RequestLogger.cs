using Banky.BankAccounts.Application.Common.Interfaces;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Banky.BankAccounts.Application.Common.Behaviours
{
    public class RequestLogger<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly ILogger _logger;
        public RequestLogger(ILogger<TRequest> logger, ICurrentUserService currentUserService)
        {
            _logger = logger;
            _currentUserService = currentUserService;
        }

        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;
            var user = _currentUserService.User ?? new Models.UserModel();

            _logger.LogInformation("NotACore.Invoicer Request: {Name} {@UserId} {@UserName} {@Request}",
                requestName, user.UserId, user.UserName, request);

            return Task.FromResult(0);
        }
    }
}