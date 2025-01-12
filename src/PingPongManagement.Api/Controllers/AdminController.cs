using MediatR;
using Microsoft.AspNetCore.Mvc;
using PingPongManagement.Application.Admins.Commands.CreateAdmin;
using PingPongManagement.Application.Admins.Commands.DeleteAdmin;
using PingPongManagement.Application.Admins.Queries.GetAdmin;
using PingPongManagement.Contracts.Admins;

namespace PingPongManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{adminId:guid}")]
        public async Task<IActionResult> Get(Guid adminId)
        {
            var query = new GetAdminQuery(adminId);
            
            var getadminResult = await _mediator.Send(query);

            return getadminResult.Match(
                admin => Ok(new AdminResponse(
                    admin.Id,
                    admin.FirstName,
                    admin.LastName,
                    admin.Email,
                    admin.UserName,
                    admin.UserId)),
                errors => Problem());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateAdminCommand request)
        {
            var command = new CreateAdminCommand(
                firstName: request.firstName,
                lastName: request.lastName,
                email: request.email,
                userName: request.userName);
            
            var createAdminResult = await _mediator.Send(command);
            
            return createAdminResult.Match(
                admin => CreatedAtAction(
                    nameof(Get),
                    new { adminId = admin.Id },
                    new AdminResponse(createAdminResult.Value.Id, 
                        createAdminResult.Value.FirstName, 
                        createAdminResult.Value.LastName,
                        createAdminResult.Value.Email,
                        createAdminResult.Value.UserName,
                        createAdminResult.Value.UserId)),
                errors => Problem());
        }

        [HttpDelete("{adminId:guid}")]
        public async Task<IActionResult> Delete(Guid adminId)
        {
            var command = new DeleteAdminCommand(adminId);
            
            var deleteAdminResult = await _mediator.Send(command);
            
            return deleteAdminResult.Match<IActionResult>(
                _ => NoContent(),
                errors => Problem());
        }
    }
}
