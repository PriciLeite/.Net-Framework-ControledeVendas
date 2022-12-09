using Projeto_Controle_de_Vendas.br.com.projeto.model;
using System;

namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    internal class cliente
    {
        internal string nome;

        public static implicit operator cliente(Cliente v)
        {
            throw new NotImplementedException();
        }
    }
}