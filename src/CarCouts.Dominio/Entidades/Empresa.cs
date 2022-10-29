namespace CarCouts.Dominio.Entidades
{
    public class Empresa
    {
        public Guid Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public bool Matriz { get; set; }
    }
}