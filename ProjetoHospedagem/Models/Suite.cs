using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria) 
        {
            this.TipoSuite = tipoSuite;
            this.Capacidade = capacidade;
            this.ValorDiaria = valorDiaria;
   
        }

        public Suite ()
        {
            
        }
        public string TipoSuite { get; set; }

        public int Capacidade { get; set; }

        public decimal ValorDiaria { get; set; }

        
    }
}