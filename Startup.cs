using Kreshnik.Api.Data;
using Microsoft.EntityFrameworkCore;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<GameDbContext>(options =>
            options.UseSqlite("Data Source=game.db"));

        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
