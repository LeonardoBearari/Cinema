
namespace CinemaApp.Models;

public class SessaoViewModel
{
    public int Id { get; set; }

    public int FilmeId { get; set; }

    public string FilmeNome { get; set; } = string.Empty;

    public int SalaId { get; set; }

    public string SalaNome { get; set; } = string.Empty;

    public DateTime Data { get; set; }
    public string DataFormatada =>
    Data.ToString("dd/MM/yyyy HH:mm");
    public decimal Preco { get; set; }
    public string Classificacao { get; set; } = string.Empty;
}
