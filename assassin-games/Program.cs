using assassingames_backend.DbContexts;
using assassingames_backend.Repositories;
using assassingames_backend.Repositories.Interfaces;
using assassingames_backend.Services;
using assassingames_backend.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Azure.Core;

var builder = WebApplication.CreateBuilder(args);

SecretClientOptions options = new SecretClientOptions()
{
    Retry =
        {
            Delay= TimeSpan.FromSeconds(2),
            MaxDelay = TimeSpan.FromSeconds(16),
            MaxRetries = 5,
            Mode = RetryMode.Exponential
         }
};

var secretValue = "";

if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
{
    secretValue = builder.Configuration.GetConnectionString("SecretName");
}
else
{
    var client = new SecretClient(new Uri("https://assassin-games-vault.vault.azure.net/"), new DefaultAzureCredential(), options);
    KeyVaultSecret secret = client.GetSecret(builder.Configuration.GetConnectionString("SecretName"));
    secretValue = secret.Value;
}

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(
                options => options.UseMySql(
                    secretValue, ServerVersion.AutoDetect(secretValue)
                ));
builder.Services.AddScoped<IHuntRepository, HuntRepository>();
builder.Services.AddScoped<ILeadershipRepository, LeadershipRepository>();
builder.Services.AddScoped<IOrganiserRepository, OrganiserRepository>();
builder.Services.AddScoped<IParticipationRepository, ParticipationRepository>();
builder.Services.AddScoped<IPrizeRepository, PrizeRepository>();
builder.Services.AddScoped<IRuleRepository, RuleRepository>();
builder.Services.AddScoped<ISeasonRepository, SeasonRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IStudyRepository, StudyRepository>();
builder.Services.AddScoped<IHuntService, HuntService>();
builder.Services.AddScoped<ILeadershipService, LeadershipService>();
builder.Services.AddScoped<IOrganiserService, OrganiserService>();
builder.Services.AddScoped<IParticipationService, ParticipationService>();
builder.Services.AddScoped<IPrizeService, PrizeService>();
builder.Services.AddScoped<IRuleService, RuleService>();
builder.Services.AddScoped<ISeasonService, SeasonService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IStudyService, StudyService>();
builder.Services.AddCors();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "assassingames_backend", Version = "v1" });
});

var app = builder.Build();
//var startup = new Startup(builder.Configuration);

//startup.ConfigureServices(builder.Services);



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSwaggerUI(options => {
        options.SwaggerEndpoint("/swagger/v1/swagger.json",
        "Assassin Games API");
    });
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseHttpsRedirection();

}

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"));
//startup.Configure(app, app.Environment);
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();