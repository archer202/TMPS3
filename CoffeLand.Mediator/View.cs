using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CoffeLand.Mediator
{
    public class View
    {
        private  IServiceProvider _provider;
        private  IMediator _mediator;

        public View()
        {
            IServiceCollection services = new ServiceCollection();
            var assembly = AppDomain.CurrentDomain.Load("CoffeLand.Mediator");
            services.AddMediatR(assembly);
            _provider = services.BuildServiceProvider();
            _mediator = _provider.GetRequiredService<IMediator>();
        }
        public async void GetView()
        {
            var query = new GetOrderQuery();

            var order = await _mediator.Send(query);

            Console.WriteLine("Comanda dumneavoastra contine : ");
            foreach (var obj in order)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
