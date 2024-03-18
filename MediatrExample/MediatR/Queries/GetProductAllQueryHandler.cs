using MediatR;

namespace MediatrExample.MediatR.Queries
{
    public class GetProductAllQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
    {
        public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new List<GetProductViewModel>()
            {
                new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 1."
                },
                                new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Product 2."
                },
            };

            return Task.FromResult(viewModel);
        }
    }
}
