namespace CarCouts.Dominio.Entidades
{
    public class Venda
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public List<ItemVenda> Itens { get; set; }
        public decimal Total { get; set; }
    }
}