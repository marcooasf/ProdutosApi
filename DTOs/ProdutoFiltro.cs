namespace ProdutosApi.DTOs;

public class ProdutoFiltro
{
    public const int TamanhoMaximoPagina = 50;

    private int _page = 1;
    private int _pageSize = 10;

    public int Page
    {
        get => _page;
        set => _page = value < 1 ? 1 : value;
    }
    
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = value switch
        {
            < 1 => 1,
            > TamanhoMaximoPagina => TamanhoMaximoPagina,
            _ => value
        };
    }
    
    public int skip => (_page - 1) * _pageSize;
    
    public string? Nome  { get; set; }
    public decimal? PrecoMinimo { get; set; }
    public decimal? PrecoMaximo { get; set; }
    public string? Zona { get; set; }
    public string? OrderBy { get; set; }
    public bool Desc { get; set; }
}