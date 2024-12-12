using System;

namespace API.models;

public class Imc
{
    public string ImcId { get; set; } = Guid.NewGuid().ToString();
    public int Quilos { get; set; }
    public int Altura { get; set; }

    public int Status { get; set; }

}
