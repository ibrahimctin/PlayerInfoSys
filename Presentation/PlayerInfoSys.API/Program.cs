var builder = WebApplication.CreateBuilder(args);
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
