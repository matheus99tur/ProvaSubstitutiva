using System;

namespace API.models;

public class Aluno

{
    public string AlunoId { get; set; } = Guid.NewGuid().ToString();
    public string? Nome { get; set; }
    public string? SobreNome { get; set; }
}

