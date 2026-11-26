using System;

namespace PedidosOnline
{
    public class Produto
    {
        private string _nome;
        private string _produtoId;
        private double _precoUnitario;
        private int _quantidade;

        public Produto(string nome, string produtoId, double precoUnitario, int quantidade)
        {
            _nome = nome;
            _produtoId = produtoId;
            _precoUnitario = precoUnitario;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetProdutoId()
        {
            return _produtoId;
        }

        public void SetProdutoId(string produtoId)
        {
            _produtoId = produtoId;
        }

        public double GetPrecoUnitario()
        {
            return _precoUnitario;
        }

        public void SetPrecoUnitario(double precoUnitario)
        {
            _precoUnitario = precoUnitario;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        public double CalcularCustoTotal()
        {
            return _precoUnitario * _quantidade;
        }

        public string ObterItemEmbalagem()
        {
            return $"ID: {_produtoId} - {_nome} (Qtd: {_quantidade})";
        }
    }
}