using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels.Manutencao;
public class ListarManutencaoViewModel
{
    public ListarManutencaoViewModel(int id, DateTime dataHora, TipoManuntecao tipoManutencao, string? observacao, int aeronaveId)
    {
        Id = id;
        DataHora = dataHora;
        TipoManutencao = tipoManutencao;
        Observacao = observacao;
        AeronaveId = aeronaveId;
    }
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public TipoManuntecao TipoManutencao { get; set; }
    public string? Observacao { get; set; }
    public int AeronaveId { get; set; }
}
