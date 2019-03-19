using System;
using System.Threading.Tasks;
using Actio.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Actio.Api.Controllers
{
    [Route("[controller]")]
    public class ActivitiesController : Controller
    {
        private readonly IBusClient _busClient;

        public ActivitiesController(IBusClient bus)
        {
            _busClient = bus;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]CreateActivity command)
        {
            command.Id = Guid.NewGuid(); 
            command.CreatedAt = DateTime.UtcNow;

            try
            {
                await _busClient.PublishAsync(command);

            }
            catch (Exception ex)
            {
                var a = ex;
            }

            return Accepted($"activities/{command.Id}");
        }
    }
}
