using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorProduto = 0, valorPago = 0, troco = 0;
            int i = 0;

            do { 

            Console.WriteLine("Digite o valor do produto: ");
            string valorProdutoSolicitado = Console.ReadLine();
            valorProduto = Convert.ToDouble(valorProdutoSolicitado);
            Console.WriteLine("Digite o valor pago: ");
            string valorPagoSolicitado = Console.ReadLine();
            valorPago = Convert.ToDouble(valorPagoSolicitado);

            if (valorProduto < valorPago) ;
                {
                    troco = valorPago - valorProduto;
                    Console.WriteLine("O valor do seu troco é: " + Math.Round(troco, 2));
                }
            else if (valorPago == valorPago) ;
            Console.WriteLine("Não há troco");
            else if (valorProduto > valorPago) ;
                Console.WriteLine("Vosê não tem poder aquisitivo para esta compra (POBRE)");

                

            }
    }
}
