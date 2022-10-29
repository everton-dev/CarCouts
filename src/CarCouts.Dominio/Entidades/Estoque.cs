namespace CarCouts.Dominio.Entidades
{
    public class Estoque
    {
        public Guid Id { get; set; }
        public Guid EmpresaId { get; set; }
        public Guid CarroId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorVenda { get; set; }
    }
}