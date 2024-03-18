using MediatR;

namespace MediatrExample.MediatR.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {

            var viewModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Product Name"
            };

            return Task.FromResult(viewModel);

            // Get Product from repository
        }
    }
}
