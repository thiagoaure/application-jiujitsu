using KbrTec.JiuJitsuSystem.Application.Configurations;
using KbrTec.JiuJitsuSystem.Application.Extensions;
using KbrTec.JiuJitsuSystem.Application.Helpers;
using KbrTec.JiuJitsuSystem.Application.Security;
using KbrTec.JiuJitsuSystem.Data.Context;
using KbrTec.JiuJitsuSystem.Domain;
using KbrTec.JiuJitsuSystem.Domain.Entities;
using KbrTec.JiuJitsuSystem.Domain.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCustomServices();
builder.Services.AddCustomRepositories();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    var Key = Encoding.UTF8.GetBytes(Settings.Secret);
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Key)
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("admin",
        policy => policy.RequireRole("admin"));
    options.AddPolicy(TipoUsuarioHelper.GetRole(ETipoUsuario.USUARIO_COMUM),
        policy => policy.RequireRole(TipoUsuarioHelper.GetRole(ETipoUsuario.USUARIO_COMUM)));
});

//builder.Services.AddIdentity<Usuario, IdentityRole<Guid>>()
//    .AddEntityFrameworkStores<AppDbContext>()
//    .AddDefaultTokenProviders()
//    .AddRoles<IdentityRole<Guid>>();

builder.Services.AddEndpointsApiExplorer();
//Registrar o Swagger
builder.Services.AddSwaggerGen(options =>
{

    // Seguranca no Swagger
    options.AddSecurityDefinition("JWT", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Digite um Token JWT valido!",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });

    //configuraco visual da Seguranca no Swagger
    options.OperationFilter<AuthResponsesOperationFilter>();

});

builder.Services.AddCors(options => {
    options.AddPolicy(name: "MyPolicy",
        policy =>
        {
            policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
