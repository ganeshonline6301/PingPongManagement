using FluentValidation;

namespace PingPongManagement.Application.Admins.Commands.CreateAdmin;

public class CreateAdminCommandValidator : AbstractValidator<CreateAdminCommand>
{
    public CreateAdminCommandValidator()
    {
        RuleFor(x => x.firstName).MinimumLength(3).NotEmpty().MaximumLength(30);
    }
}