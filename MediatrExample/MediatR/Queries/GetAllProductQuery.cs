using MediatR;

namespace MediatrExample.MediatR.Queries
{
    public class GetAllProductQuery : IRequest<List<GetProductViewModel>>
    {

    }
}
