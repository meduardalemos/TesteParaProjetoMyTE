namespace TesteParaProjetoMyTE.Models
{
    public class LancamentoHora
    {
        public int LancamentoHoraId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public int ApplicationUserId { get; set; }
        public DateTime Data {  get; set; }
        public int Horas {  get; set; }
        public Quinzena Quinzena { get; set; }
        public int QuinzenaId { get; set; }
    }
}
