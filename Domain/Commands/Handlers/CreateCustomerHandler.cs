using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
{
    

    public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        //Regras de negocio

        var result = new CreateCustomerResponse(
            id: Guid.NewGuid(),
            name: "leandro",
            email: "leandro94.a.s@gmail.com",
            date: DateTime.Now
       );

        return Task.FromResult( result );
    }
}
