using Semana_04.Classes.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_04.Classes
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public EstadoCivil EstadoCivil { get; private set; }
        public TipoPessoa TipoPessoa { get; private set; }
       
        public Cliente (string nome, DateTime nasc, string profissao, EstadoCivil estCivil, TipoPessoa tipo)
        {
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("O nome não pode ser vazio");
            }
            else
            {
                Nome = nome;
            }
            Nascimento = nasc;
            Profissao = profissao;
            TipoPessoa = tipo;
            EstadoCivil = estCivil;
        }
      
    }
}
