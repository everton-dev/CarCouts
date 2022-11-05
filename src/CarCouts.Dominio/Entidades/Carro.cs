namespace CarCouts.Dominio.Entidades
{
    public class Carro
    {
        public Guid Id { get; set; }
        public Guid MarcaId { get; set; }
        public Marca Marca { get; set; }
        public Guid ModeloId { get; set; }
        public Modelo Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string EnderecoImagem { get; set; }
    }
}