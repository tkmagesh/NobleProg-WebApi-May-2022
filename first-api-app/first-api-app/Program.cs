//Top Level Statement

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

/*
app.Run(async (context) =>
{
    //analyze the request
    //extract the data from the payload
    //deserialize it
    //convert the data into a .NET objecct
    //process the data
    //get the result
    //seraialize the result
    //send the response
    await context.Response.WriteAsync("Hello World!");
});
*/

app.Run();

