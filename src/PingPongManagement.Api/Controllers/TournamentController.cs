using MediatR;
using Microsoft.AspNetCore.Mvc;
using PingPongManagement.Api.Extensions;
using PingPongManagement.Application.Tournaments.Commands.CreateTournament;
using PingPongManagement.Application.Tournaments.Commands.DeleteTournament;
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
        public async Task<IActionResult> GetTournament(Guid tournamentId, CancellationToken cancellationToken)
        {
            var query = new GetTournamentQuery(tournamentId);
            
            var getTournamentResult = await _mediator.Send(query, cancellationToken);
            
            return getTournamentResult.Match(
                tournament => Ok(new TournamentResponse(
                    tournament.Id,
                    tournament.Title,
                    tournament.Description)),
                error => Problem(
                    detail: $"Tournament with id {tournamentId} was not found.",
                    statusCode: 400));
        }

        [HttpPost]
        public async Task<TournamentResponse> CreateTournament(
            CreateTournamentRequest createTournamentRequest,
            Guid adminId,
            CancellationToken cancellationToken)
        {

            var command = new CreateTournamentCommand(
                Title: createTournamentRequest.Title,
                Description: createTournamentRequest.Description,
                StartDate: createTournamentRequest.StartDate,
                TournamentType: createTournamentRequest.TournamentType.ToDomain(),
                TournamentStatus: createTournamentRequest.TournamentStatus.ToDomain(),
                TournamentFormat: createTournamentRequest.TournamentFormat.ToDomain(),
                TournamentSize: createTournamentRequest.TournamentSize.ToDomain(),
                AdminId: adminId);
            
            var createTournamentResult = await _mediator.Send(command, cancellationToken);

            return new TournamentResponse(
                        createTournamentResult.Value.Id,
                        createTournamentResult.Value.Title,
                        createTournamentResult.Value.Description);
        }

        [HttpDelete("{tournamentId:guid}")]
        public async Task<IActionResult> DeleteTournament(Guid tournamentId, CancellationToken cancellationToken)
        {
            var command = new DeleteTournamentCommand(tournamentId);
            var deleteTournamentResult = await _mediator.Send(command, cancellationToken);

            return deleteTournamentResult.Match<IActionResult>(
                _ => NoContent(),
                error => Problem());
        }
    }
}
