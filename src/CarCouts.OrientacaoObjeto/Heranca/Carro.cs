namespace CarCouts.OrientacaoObjeto.Heranca
{
    public class Carro : Veiculo
    {
        public Carro(string marca, string modelo, decimal peso, int numeroDeRodas) 
            : base(marca, modelo, peso, numeroDeRodas)
        {
        }
    }
}