using System.Threading.Tasks;
using Actio.Common.Commands;
using RawRabbit;

namespace Actio.Services.Identity.Handlers
{
    public class CreateUserHandler : ICommandHandler<CreateUser>
    {
        private readonly IBusClient _busClient;

        public CreateUserHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CreateUser command)
        {
            await Task.CompletedTask;
        }
    }
}