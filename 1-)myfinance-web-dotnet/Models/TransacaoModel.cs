using myfinance_web_dotnet_domain.Entities;

namespace myfinance_web_netcore.Models
{
    public class TransacaoModel
{
    public int? Id { get; set; }
    public string Historico { get; set; }
    public DateTime Date { get; set; }
    public decimal Valor { get; set; }
    public int PlanoContaId { get; set; }
    public string? Tipo { get; set; }
    public PlanoConta PlanoConta { get; set; }
}
}