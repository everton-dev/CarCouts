namespace CarCouts.Dominio.Entidades
{
    public class ItemVenda
    {
        public Guid Id { get; set; }
        public Guid CarroId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}