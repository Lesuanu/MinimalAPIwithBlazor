
using MinimalCakeShop.Dapper;
using MinimalCakeShop.Endpoint;
using MinimalCakeShop.Endpoint.CakeShopEndpoint;

namespace MinimalCakeShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<ClientApp>();
            builder.Services.AddTransient<EndpointConfiguration>();
            builder.Services.AddTransient<ICakeShopEndPoint, CakeShopEndpoints>();

            builder.Services.AddSingleton<DapperContext>();

            var app = builder.Build();

            //new ClientApp().Register(app);
            //new EndpointConfiguration().Register(app);

            var endpoint = app.Services.GetService<EndpointConfiguration>();
            endpoint?.Register(app);

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.Run();
        }
    }
}