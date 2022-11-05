namespace CarCouts.Dominio.Entidades
{
    public class Marca
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<Modelo> Modelos { get; set; }
    }
}