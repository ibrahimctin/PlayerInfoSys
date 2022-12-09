using PlayerInfoSys.API.Extensions;
using PlayerInfoSys.Domain.Application.Extensions;
using PlayerInfoSys.Domain.Common.AutoMapper.AutoMapperProfiles;
using PlayerInfoSys.Domain.Common.UriService;
using PlayerInfoSys.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
builder.Services.LoadDataInfrastructureExtensions(builder.Configuration);
builder.Services.LoadEntityFrameworkExtensions(builder.Configuration);
builder.Services.LoadDataApplicationExtensions(builder.Configuration);
builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<IPaginationUriService>(opt =>
{
    var httpContextAccessor = opt.GetRequiredService<IHttpContextAccessor>();
    return new PaginationUriService(httpContextAccessor);
});
builder.Services.AddAutoMapper(typeof(Maps));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
