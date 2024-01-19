namespace MinimalCakeShop
{
    public class ClientApp
    {
        private readonly ILogger _logger;
        public ClientApp(ILogger<ClientApp> logger)
        {
            _logger = logger;
        }

        public void Register(WebApplication app)
        {
            app.MapGet("/", GetCakeShop);
          
        }

        public async Task<IResult> GetCakeShop(int id)
        {
            _logger.LogInformation($"{id} is the id logged!!");
            //return Results.Ok(new repository.GetCakeShopAsync(id));
            return Results.Ok(id);
        }
    }
}