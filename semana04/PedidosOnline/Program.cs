using System;

namespace PedidosOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedido 1: Cliente nos EUA (frete de $5)
            Endereco enderecoEua = new Endereco("742 Evergreen Terrace", "Rexburg", "ID", "EUA");
            Cliente clienteEua = new Cliente("Lucas Martins", enderecoEua);

            Produto produto1A = new Produto("Garrafa Térmica Inox", "PRD-101", 24.50, 2);
            Produto produto1B = new Produto("Caderno de Anotações", "PRD-204", 12.00, 1);
            Produto produto1C = new Produto("Cabo USB-C Trançado", "PRD-309", 15.00, 2);

            Pedido primeiroPedido = new Pedido(clienteEua);
            primeiroPedido.AdicionarProduto(produto1A);
            primeiroPedido.AdicionarProduto(produto1B);
            primeiroPedido.AdicionarProduto(produto1C);

            // Pedido 2: Cliente fora dos EUA (frete de $35)
            Endereco enderecoInternacional = new Endereco("Av. Atlântica, 1500", "Rio de Janeiro", "RJ", "Brasil");
            Cliente clienteInternacional = new Cliente("Mariana Rocha", enderecoInternacional);

            Produto produto2A = new Produto("Mouse Sem Fio Ergonômico", "PRD-410", 45.00, 1);
            Produto produto2B = new Produto("Suporte de Alumínio para Notebook", "PRD-512", 38.00, 2);

            Pedido segundoPedido = new Pedido(clienteInternacional);
            segundoPedido.AdicionarProduto(produto2A);
            segundoPedido.AdicionarProduto(produto2B);

            // Exibição do Pedido 1
            Console.WriteLine("**************************************************");
            Console.WriteLine("PEDIDO 1");
            Console.WriteLine(primeiroPedido.GerarEtiquetaEmbalagem());
            Console.WriteLine();
            Console.WriteLine(primeiroPedido.GerarEtiquetaEnvio());
            Console.WriteLine();
            Console.WriteLine($"Preço Total do Pedido: ${primeiroPedido.CalcularCustoTotal():F2}");

            // Exibição do Pedido 2
            Console.WriteLine("**************************************************");
            Console.WriteLine("PEDIDO 2");
            Console.WriteLine(segundoPedido.GerarEtiquetaEmbalagem());
            Console.WriteLine();
            Console.WriteLine(segundoPedido.GerarEtiquetaEnvio());
            Console.WriteLine();
            Console.WriteLine($"Preço Total do Pedido: ${segundoPedido.CalcularCustoTotal():F2}");
            Console.WriteLine("**************************************************");
        }
    }
}