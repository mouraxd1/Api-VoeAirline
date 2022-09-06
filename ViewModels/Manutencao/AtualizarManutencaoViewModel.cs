using VoeAirlines.Entities.Enums;

namespace VoeAirlines.ViewModels.Manutencao;
public class AtualizarManutencaoViewModel
{
    public AtualizarManutencaoViewModel(DateTime dataHora, TipoManuntecao tipoManutencao, string? observacao, int aeronaveId)
    {
        DataHora = dataHora;
        TipoManutencao = tipoManutencao;
        Observacao = observacao;
        AeronaveId = aeronaveId;
    }
    public DateTime DataHora { get; set; }
    public TipoManuntecao TipoManutencao { get; set; }
    public string? Observacao { get; set; }
    public int AeronaveId { get; set; }
}
