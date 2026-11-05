namespace CinemaApp.Models;

public class IngressoItemViewModel
{
    public int Id { get; set; }
    public int IngressoId { get; set; }
    public string Assento { get; set; } = string.Empty;
    public decimal Valor { get; set; }
}