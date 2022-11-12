namespace CarCouts.OrientacaoObjeto.Heranca.EX01
{
    public class Som : Produto
    {
        public override void AcaoProduto()
        {
            base.AcaoProduto();
            Console.WriteLine("Soltando um som pesado!");
        }
    }
}