var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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


var books = new List<Book>
{
    new Book { Id = 1, Title = "The 48 laws of Power", Author = "Robert Greene" },
    new Book { Id = 2, Title = "The 50th law of Power", Author = "Robert Greene" },
    new Book { Id = 3, Title = "Human Nature", Author = "Robert howei" },



};
app.UseHttpsRedirection();

app.MapGet("/book", () =>
{
    return books;
});
app.Run();

class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }

}