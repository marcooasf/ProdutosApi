namespace ProdutosApi.Domain;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    
    //Campos novos Projeto Sonar
    public string Tipo { get; set; } = string.Empty;
    public string Zona { get; set; } = string.Empty;
    public int Profundidade { get; set; }   
    public int Timbre { get; set; }
    public string? ImagemUrl { get; set; }
    
    public Produto()
    {
    }

    public Produto(int id, string? descricao, decimal preco, int estoque)
    {
        Id = id;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
    }
}
