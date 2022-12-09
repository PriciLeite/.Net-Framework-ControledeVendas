using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Controle_de_Vendas.br.com.projeto.model
{
    public class Cliente
    {
        //Criar os atributos Getter / Setter juntos

        public string codigo { get; set; }
        
        public string nome { get; set; }

        public string rg { get; set; }

        public string cpf { get; set; }

        public string email { get; set; }

        public string telefone { get; set; }

        public string celular { get; set; }

        public string cep { get; set; }

        public string endereco { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }
    }
}
