using ErrorOr;
using MediatR;

namespace PingPongManagement.Application.Matches.Commands.CreateMatch;

public class CreateMatchCommandHandler : IRequestHandler<CreateMatchCommand, ErrorOr<Success>>
{
    public Task<ErrorOr<Success>> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}