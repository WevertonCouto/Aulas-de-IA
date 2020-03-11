namespace Parentesco_Taulogia
{
    public class Pessoa
    {

        public string Nome { get; set; }
        public string Parentesco { get; set; }
        public string Nome2 { get; set; }


        public Pessoa(string nome, string parentesco, string nome2)
        {
            Nome = nome;
            Parentesco = parentesco;
            Nome2 = nome2;
        }
    }
}