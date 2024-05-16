namespace TesteParaProjetoMyTE.Models
{
    public class Quinzena
    {
        public int QuinzenaId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public ICollection<LancamentoHora> LancamentosHora { get; set; }
    }
}
