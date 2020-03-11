using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedico.Models
{
    public class Sintoma
    {
        private string Nome;

        public Sintoma(string nome)
        {
            this.Nome = nome;
        }

        public string GetNome() => this.Nome;

    }
}
