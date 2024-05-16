namespace TesteParaProjetoMyTE.Models
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Name { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
