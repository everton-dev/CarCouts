namespace CarCouts.OrientacaoObjeto.Encapsulamento
{
    public class Pagamento
    {
        public Pagamento(decimal valorTotal, string formaPagamento)
        {
            ValorTotal = valorTotal;
            FormaPagamento = formaPagamento;
        }

        public decimal ValorTotal { get; private set; }
        public string FormaPagamento { get; private set; }

        public void AlterarValorTotal(decimal novoValorTotal)
        {
            Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} | O Valor total que era {this.ValorTotal}, foi alterado para {novoValorTotal}");
            this.ValorTotal = novoValorTotal;
        }

        public void AlterarFormaDePagamento(string novaFormaPagamento)
        {
            Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} | A Forma de Pagamento que era {this.FormaPagamento}, foi alterada para {novaFormaPagamento}");
            this.FormaPagamento = novaFormaPagamento;
        }

        public void EfetuarPagamento()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(ToString());
            Console.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} | Pagamento efetuado com sucesso!");
        }

        public override string ToString()
        {
            return $"Valor Total de {this.ValorTotal} e a forma de pagamento será {this.FormaPagamento}";
        }
    }
}