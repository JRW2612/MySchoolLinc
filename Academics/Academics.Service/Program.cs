using Academics.Business.Repository.Course;
using Academics.Business.Service.Course;
using Academics.Core.Service.Course;
using Academics.Repository.DataSeeder;
using Academics.Repository.Repositories.Course;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

var builder = WebApplication.CreateBuilder(args);

// 1. Register MongoDB Serializers
BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));
BsonSerializer.RegisterSerializer(new DateTimeOffsetSerializer(BsonType.String));

// 2. Add services to the container
builder.Services.AddControllers();

// 3. Swagger & OpenAPI Configuration (Cleaned up duplicates)
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 4. Dependency Injection for your Repositories and Services
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ICourseService, CourseService>();

// 5. Bind configuration
builder.Services.Configure<Constants>(builder.Configuration.GetSection("DatabaseSettings"));
builder.Services.AddSingleton(sp =>
    sp.GetRequiredService<IConfiguration>().GetSection("DatabaseSettings").Get<Constants>());

var app = builder.Build();

// 6. Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// 7. Seed Mongo Data at Application Startup
// Wrapped in a try-catch so a data formatting error doesn't crash the entire app!
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var config = services.GetRequiredService<IConfiguration>();
        var constants = config.GetSection("DatabaseSettings").Get<Constants>();
        await DBSeederClass.SeedDataAsync(constants);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database. Please check your MongoDB data types.");
    }
}

// 8. Run the application
app.Run();