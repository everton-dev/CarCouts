namespace CarCouts.OrientacaoObjeto.Heranca
{
    public class Veiculo
    {
        public Veiculo(string marca, string modelo, decimal peso, int numeroDeRodas)
        {
            Marca = marca;
            Modelo = modelo;
            Peso = peso;
            NumeroDeRodas = numeroDeRodas;

            ToString();
            Acelerar();
            Brecar();
            Re();
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Peso { get; set; }
        public int NumeroDeRodas { get; set; }

        public void Acelerar()
        {
            Console.WriteLine($"{this.GetType().Name} => Acelerando...");
        }

        public void Brecar()
        {
            Console.WriteLine($"{this.GetType().Name} => Brecando...");
        }

        public void Re()
        {
            Console.WriteLine($"{this.GetType().Name} => Dando Ré...");
        }

        public override string ToString()
        {
            var mensagem = $"Marca: {Marca} | Modelo: {Modelo} | Peso: {Peso} | N.o Rodas: {NumeroDeRodas} |";
            Console.WriteLine(mensagem);
            return mensagem;
        }
    }
}