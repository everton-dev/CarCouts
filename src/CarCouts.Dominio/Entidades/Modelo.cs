namespace CarCouts.Dominio.Entidades
{
    public class Modelo
    {
        public Guid Id { get; set; }
        public Guid MarcaId { get; set; }
        public Marca Marca { get; set; }
        public string Descricao { get; set; }
    }
}