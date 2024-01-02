using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


//Insert service to the container

builder.Services.AddControllers().AddJsonOptions(x =>
                                             x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);



//Swagger config

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


//HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
