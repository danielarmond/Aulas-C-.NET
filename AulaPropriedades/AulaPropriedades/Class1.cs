using System;


namespace AulaPropriedades
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        public int Quantidade { get; private set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco {
            get { return _preco; }
                }
                
    }

   
}
