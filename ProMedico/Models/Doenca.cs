using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedico.Models
{
    public class Doenca
    {
        public string Nome { get; set; }
        public List<Sintoma> Sintomas { get; set; }
    }
}
