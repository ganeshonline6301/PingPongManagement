using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PingPongManagement.Contracts.Tournaments;

namespace PingPongManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        public async Task<IActionResult> GetTournaments()
        {
            return Ok();
        }

        public async Task<IActionResult> GetTournament(Guid id, CancellationToken cancellationToken)
        {
            return Ok();
        }

        public async Task<TournamentResponse> CreateTournament(CreateTournamentRequest createTournamentRequest,
            CancellationToken cancellationToken)
        {
            return new TournamentResponse();
        }

        public async Task<IActionResult> DeleteTournament(Guid id, CancellationToken cancellationToken)
        {
            return NoContent();
        }
    }
}
