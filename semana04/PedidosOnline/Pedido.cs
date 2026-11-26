using System;
using System.Collections.Generic;
using System.Text;

namespace PedidosOnline
{
    public class Pedido
    {
        private List<Produto> _produtos;
        private Cliente _cliente;

        public Pedido(Cliente cliente)
        {
            _cliente = cliente;
            _produtos = new List<Produto>();
        }

        public Cliente GetCliente()
        {
            return _cliente;
        }

        public void SetCliente(Cliente cliente)
        {
            _cliente = cliente;
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public double CalcularCustoTotal()
        {
            double subtotalProdutos = 0;

            foreach (Produto produtoItem in _produtos)
            {
                subtotalProdutos += produtoItem.CalcularCustoTotal();
            }

            double custoEnvio = _cliente.MoraNosEUA() ? 5.0 : 35.0;
            return subtotalProdutos + custoEnvio;
        }

        public string GerarEtiquetaEmbalagem()
        {
            StringBuilder etiqueta = new StringBuilder();
            etiqueta.AppendLine("=== ETIQUETA DE EMBALAGEM ===");

            foreach (Produto produtoItem in _produtos)
            {
                etiqueta.AppendLine(produtoItem.ObterItemEmbalagem());
            }

            return etiqueta.ToString().TrimEnd();
        }

        public string GerarEtiquetaEnvio()
        {
            StringBuilder etiqueta = new StringBuilder();
            etiqueta.AppendLine("=== ETIQUETA DE ENVIO ===");
            etiqueta.AppendLine(_cliente.ObterEtiquetaEnvio());
            return etiqueta.ToString().TrimEnd();
        }
    }
}