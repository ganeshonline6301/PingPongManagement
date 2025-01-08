using MediatR;
using Microsoft.AspNetCore.Mvc;
using PingPongManagement.Application.Tournaments.Queries.GetTournament;
using PingPongManagement.Contracts.Tournaments;

namespace PingPongManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        private readonly ISender _mediator;

        public TournamentController(ISender mediator)
        {
            _mediator = mediator;
        }
        
        public async Task<IActionResult> GetTournaments()
        {
            // var tournaments = await _mediator.Send()
            return Ok();
        }

        [HttpGet("{tournamentId:guid}")]
        public async Task<IActionResult> GetTournament(Guid id, CancellationToken cancellationToken)
        {
            var query = new GetTournamentQuery(id);
            
            var getTournamentResult = await _mediator.Send(query, cancellationToken);
            
            return getTournamentResult.Match(
                tournament => Ok(new TournamentResponse(
                    tournament.Id,
                    tournament.Title,
                    tournament.Description)),
                error => Problem(
                    detail: $"Tournament with id {id} was not found.",
                    statusCode: 400));
        }

        [HttpPost]
        public async Task<TournamentResponse> CreateTournament(CreateTournamentRequest createTournamentRequest,
            CancellationToken cancellationToken)
        {
            return new TournamentResponse(Guid.NewGuid(), createTournamentRequest.Title, createTournamentRequest.Description);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTournament(Guid id, CancellationToken cancellationToken)
        {
            return NoContent();
        }
    }
}
