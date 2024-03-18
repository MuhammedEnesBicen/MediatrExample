using MediatR;

namespace MediatrExample.MediatR.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.NewGuid());
            // repository aracılığı ile dbye gönderilir

        }
    }
}
