namespace CinemaApp.Models;

public class IngressoViewModel
{
    public int Id { get; set; }
    public int SessaoId { get; set; }
    public DateTime DataVenda { get; set; }
    public decimal ValorTotal { get; set; }
}