using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace sqli.Models
{
    internal class Produto
    {
        string descricao;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Descricao { get => descricao;
            set  
            {
                if (value == null) 
                {
                    throw new Exception("Por favor preencha a descrição");
                }
                descricao = value;

            }
            public double quantidade { get; set; }
            public double preco { get; set; }
            public double total { get => quantidade * preco; }
        }
    }
}
