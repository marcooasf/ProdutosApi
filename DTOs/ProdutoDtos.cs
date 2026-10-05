using System.ComponentModel.DataAnnotations;

namespace ProdutosApi.DTOs;

public record ProdutoResponse(
    int Id,
    string Nome,
    string? Descricao,
    decimal Preco,
    int Estoque,
    DateTime CriadoEm,
    string Tipo,
    string Zona,
    int Profundidade,
    int Timbre,
    string? ImagemUrl);

public class ProdutoRequest
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(120, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 120 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres.")]
    public string? Descricao { get; set; }

    [Range(0.01, 1_000_000, ErrorMessage = "O preço deve estar entre 0,01 e 1.000.000,00.")]
    public decimal Preco { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "O estoque não pode ser negativo.")]
    public int Estoque { get; set; }

    // Campos novos do Sonar
    [Required(ErrorMessage = "O tipo do instrumento é obrigatório.")]
    [StringLength(60, MinimumLength = 2, ErrorMessage = "O tipo deve ter entre 2 e 60 caracteres.")]
    public string Tipo { get; set; } = string.Empty;

    [Required(ErrorMessage = "A zona é obrigatória.")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = "A zona deve ter entre 2 e 30 caracteres.")]
    public string Zona { get; set; } = string.Empty;

    [Range(0, 11000, ErrorMessage = "A profundidade deve estar entre 0 e 11.000 metros.")]
    public int Profundidade { get; set; }

    [Range(1, 5, ErrorMessage = "O timbre deve estar entre 1 (brilhante) e 5 (grave).")]
    public int Timbre { get; set; }

    [StringLength(500, ErrorMessage = "O link da imagem deve ter no máximo 500 caracteres.")]
    public string? ImagemUrl { get; set; }
}