using assassingames_backend;
using assassingames_backend.DbContexts;
using assassingames_backend.Repositories;
using assassingames_backend.Repositories.Interfaces;
using assassingames_backend.Services;
using assassingames_backend.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(
                options => options.UseMySql(
                    builder.Configuration.GetConnectionString("DefaultConnection"), 
                    ServerVersion.AutoDetect(
                        builder.Configuration.GetConnectionString("DefaultConnection"))
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
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
}

//startup.Configure(app, app.Environment);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


/*app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");*/

app.MapFallbackToFile("index.html"); ;

app.Run();