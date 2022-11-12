// See https://aka.ms/new-console-template for more information
using CarCouts.OrientacaoObjeto.Encapsulamento;
using CarCouts.OrientacaoObjeto.Heranca;
using CarCouts.OrientacaoObjeto.Heranca.EX01;

//Console.WriteLine("-------------------------------------------");
//Console.WriteLine("Veiculos");
//Console.WriteLine("-------------------------------------------");
//Veiculo veiculo01 = new Carro("BMW", "Series 2", 150, 4);

//Console.WriteLine("-------------------------------------------");
//Veiculo veiculo02 = new Moto("Suzuky", "Moto 01", 70, 2);

//Console.WriteLine("-------------------------------------------");
//Veiculo veiculo03 = new Bicicleta("Caloi", "Speed", 10, 2);

//Trabalhando o conceito de Orientação a Objeto: Herança
// Modelar com orientação a objeto os produtos da Car Coutos.
// Ex. Loja de Conveniencia
// Sabemos que: Todo produto possui sua marca, descricao, tipo do produto, utilidade e sua "AÇÃO" (Métodos).

// ** Superação **
// ** Sabendo que, as ações de cada produto são diferentes, crie um método que seja sobrescrito nas classes filhas.

//Produto aromatizador = new Aromatizador()
//{
//    Descricao = "Aromatizador de veiculo",
//    Marca = "Cheiro Bom",
//    TipoProduto = "Aromatizador",
//    Utilidade = "Deixar um cheiro bom"
//};
//Produto som = new Som()
//{
//    Descricao = "Fazer um som para o carro",
//    Marca = "Buster",
//    TipoProduto = "Som",
//    Utilidade = "Peso"
//};

//aromatizador.AcaoProduto();
//som.AcaoProduto();

//var pagamento = new Pagamento(2000, "Pix");
//Console.WriteLine(pagamento.ToString());

//pagamento.AlterarFormaDePagamento("Cartão de Crédito");
//Console.WriteLine(pagamento.ToString());

//pagamento.AlterarValorTotal(2850.90M);
//Console.WriteLine(pagamento.ToString());

//pagamento.AlterarFormaDePagamento("Débito");
//Console.WriteLine(pagamento.ToString());

//pagamento.EfetuarPagamento();

//--------------------------------------------------------------------------------------------------
//Trabalhando o conceito de Orientação a Objeto: Abstração, Herança, Encapsulamento e Polimorfismo
// Modelar com orientação a objeto o modulo de vendas.
// Ex. Loja de Conveniencia: Vender produtos
// Sabemos que: Em uma venda há um numero unico da venda, o cliente que está comprando, os itens dessa venda (produtos) devem conter: valor unitário, quantidade e total,
// e a venda deve conter: forma de pagamento, data e hora da venda e data, hora do pagamento e o Total da venda.

// ** Superação **
// ** Aplicar todos os conceitos de orientação a objeto, todas as classes do módulo de venda devem ter as suas propriedades com "private set", e a iniciação desses
// métodos devem ser feitas pelo construtor e acessados por métodos especificos.
//Dica: https://www.devmedia.com.br/os-4-pilares-da-programacao-orientada-a-objetos/9264



Console.ReadLine();