using System;

namespace Caixa_eletronico
{
    class Program
    {
        static void Main(string[] args); 
        {
        double valorProduto = 0, valorPago = 0, troco = 0;


        Console.WriteLine("Digite o valor do produto: ");
            string valorProdutoSolicitado = Console.ReadLine();
        valorProduto = Convert.ToDouble(valorProdutoSolicitado);
        Console.WriteLine("Digite o valor pago: ");
            string valorPagoSolicitado = Console.ReadLine();
        valorPago = Convert.ToDouble(valorPagoSolicitado);

        if(valorProduto<valorPago)
        {   
           troco = valorPago - valorProduto;
            Console.WriteLine("O valor do seu troco é: " + troco);
        }
        else if 

    }
}
