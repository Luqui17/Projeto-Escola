namespace Escola
{
    public class Aluno
    
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public Aluno()
        {
            // this.Nome = nome;
        }
        public override string ToString()
        {
            return $"Aluno: {this.Nome} /ID: {this.Id} ";
        }
    }
}