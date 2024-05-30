using System.Reflection;
using Binabox.Application.Extensions;
using Binabox.Infrastructure.Extensions;
using Binabox.Infrastructure.SignalR;
using Binabox.Persistence.Extensions;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructureLayer();
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddApplicationLayer();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(b => b
    .WithOrigins("http://localhost:5173") 
    .AllowAnyMethod()                     
    .AllowAnyHeader()                      
    .AllowCredentials()); 

app.UseFileServer(new FileServerOptions  
{  
    FileProvider = new PhysicalFileProvider(  
        Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")),  
    RequestPath = "/static",  
    EnableDefaultFiles = true  
}); 


app.MapControllers();
app.MapHub<EmailConfirmationHub>("/emailConfirmationHub");
app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();

app.Run();
