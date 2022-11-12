namespace CarCouts.OrientacaoObjeto.Heranca.EX01
{
    public class Aromatizador : Produto
    {
        public override void AcaoProduto()
        {
            base.AcaoProduto();
            Console.WriteLine("Aromatizando o ar...");
        }
    }
}