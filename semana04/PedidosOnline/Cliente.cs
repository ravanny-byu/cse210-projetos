using System;

namespace PedidosOnline
{
    public class Cliente
    {
        private string _nome;
        private Endereco _endereco;

        public Cliente(string nome, Endereco endereco)
        {
            _nome = nome;
            _endereco = endereco;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public Endereco GetEndereco()
        {
            return _endereco;
        }

        public void SetEndereco(Endereco endereco)
        {
            _endereco = endereco;
        }

        public bool MoraNosEUA()
        {
            return _endereco.EhNosEUA();
        }

        public string ObterEtiquetaEnvio()
        {
            return $"{_nome}\n{_endereco.ObterEnderecoCompleto()}";
        }
    }
}