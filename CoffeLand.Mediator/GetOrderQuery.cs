using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeLand.Mediator
{
    public class GetOrderQuery : IRequest<List<string>>
    {
    }

    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, List<string>>
    {
        public async Task<List<string>> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
            List<string> newOrder = new List<string>();
            newOrder.Add("Cafea cu lapte");
            newOrder.Add("Prajitura");
            newOrder.Add("Gogoasa");
            newOrder.Add("Inca o cafea");
            await Task.Delay(TimeSpan.FromSeconds(5), cancellationToken);
            return newOrder;
        }
    }
}
