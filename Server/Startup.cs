using Microsoft.OpenApi;
using PhoneBook.Core.Application.IService;
using PhoneBook.Core.Application.Service.Service;
using PhoneBook.Core.Domain.IRepositories;
using PhoneBook.Infrastructure.Repository.Repository;

public class Startup(IConfiguration configuration)
{
    private readonly IConfiguration _configuration = configuration;
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "PhoneBook",
            });
        });
        services.AddSingleton<IContactRepository, ContactRepository>();

        services.AddScoped<IContactService, ContactService>();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseSwagger();

        app.UseSwaggerUI();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}