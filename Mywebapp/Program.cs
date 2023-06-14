// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.Run();
using Mywebapp.Data;
using Mywebapp.Model;

StudentDbContext db=new StudentDbContext();
Student student=new Student{Prenom="Oussama",Nom="CHEBECHAB",Note=19.9F};
db.Students?.Add(student);
db.SaveChanges();