using CleanCodePOC.Processes;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanCodePOC.EfCore.SqlServer.Processes.Handlers
{
    internal sealed class SaveUserHandler : IRequestHandler<SaveUser, SaveUserResult>
    {
        public async Task<SaveUserResult> Handle(SaveUser request, CancellationToken cancellationToken)
        {
            return new SaveUserResult()
            {
                Username = request.Username
            };
        }
    }
}
