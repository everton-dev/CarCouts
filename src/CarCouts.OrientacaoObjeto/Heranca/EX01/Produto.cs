namespace CarCouts.OrientacaoObjeto.Heranca.EX01
{
    public class Produto
    {
        public string Marca { get; set; }
        public string Descricao { get; set; }
        public string TipoProduto { get; set; }
        public string Utilidade { get; set; }
        public virtual void AcaoProduto()
        {
            Console.WriteLine($"Marca: {Marca} | Descricao: {Descricao} | TipoProduto: {TipoProduto} | Utilidade: {Utilidade} ");
        }
    }
}