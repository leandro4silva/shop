using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Handlers;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Controllers;

[Controller]
[Route("v1/customers")]
public class CustomerController : ControllerBase
{
    [HttpPost]
    [Route("")]
    public Task<CreateCustomerResponse> Create(
        [FromBody] CreateCustomerRequest command,
        [FromServices] IMediator mediator
    )
    {
        return mediator.Send(command);
    }
}

