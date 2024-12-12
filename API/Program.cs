using API.models;
using API.Properties;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDataContext>();

// builder.Services.AddCors(
//     options =>
//         options.AddPolicy("Acesso Total",
//             configs => configs
//                 .AllowAnyOrigin()
//                 .AllowAnyHeader()
//                 .AllowAnyMethod())
// );

var app = builder.Build();


app.MapGet("/", () => "Prova Substitutiva");




app.MapPost("/api/aluno/cadastrar", ([FromServices] AppDataContext ctx, [FromBody] Aluno aluno) =>
{
    ctx.Aluno.Add(aluno);
    ctx.SaveChanges();
    return Results.Created("", aluno);
});


app.MapPost("/api/imc/cadastrar", ([FromServices] AppDataContext ctx, [FromBody] Imc imc) =>
{
    ctx.Imc.Add(imc);
    ctx.SaveChanges();
    return Results.Created("", imc);
});



//Listar Imc
app.MapGet("/api/imc/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Imc.Any())
    {
        return Results.Ok(ctx.Imc.ToList());
    }
    return Results.NotFound("Nenhum Imc Encontrado");
});


//Listar Por Aluno 

app.MapGet("/api/imc/listarPorALuno", ([FromServices] AppDataContext ctx) =>
{
   if(ctx.Imc.Any()){
    return Results.Ok(ctx.Imc.Include(x => x.Altura).ToList());
    
   }
        return Results.NotFound("Nenhuma tarefa encontrada");
});



// app.MapPut("/api/imc/alterar {id}", ([FromServices] AppDataContext ctx, [FromBody] string id) =>
// {
//     Imc? imc = ctx.Imc.Find(id);
//     if(imc is null)
//     {
//         return Results.NotFound("Imc não encontrado");
//     }
//     if(imc.Status = "não iniciada")
//     {
       
//     }
    
// });



