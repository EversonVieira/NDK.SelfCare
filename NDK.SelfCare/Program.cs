using NDK.SelfCare.Config;
using NDK.Auth.ExtensionMethods;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( c =>
{
    c.AddSecurityDefinition("NDToken", new OpenApiSecurityScheme
    {
        Description = @"NDToken of the current logged user.",
        Name = "NDToken",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "NDToken"
                },
                Name = "NDToken",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});

StartupHelper.AddInjections(builder.Services, builder.Configuration);
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseNdkAuthMiddleWare();

app.MapControllers();

app.Run();
