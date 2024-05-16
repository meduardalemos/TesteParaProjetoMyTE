using Microsoft.AspNetCore.Identity;

namespace TesteParaProjetoMyTE.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime DataContratacao { get; set; }
        public Departamento Departamento { get; set;}
        public int DepartamentoId { get; set; }

    }
}
