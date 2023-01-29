namespace Escola
{
    public class AlunoService
    {
        private List<Aluno> _matriculados;
        private int _idAluno;
        public AlunoService()
        {
            this._matriculados = new List<Aluno>();
            this._idAluno = 1;
        }
        public void Adicionar(Aluno aluno)
        {
            try
            {
                aluno.Id = this._idAluno;
                string nome, cpf;
                int idade;

                Console.Write("Digite o nome do aluno: ");
                nome = Console.ReadLine();
                aluno.Nome = nome;

                Console.Write("Digite o CPF do aluno: ");
                cpf = Console.ReadLine();
                aluno.CPF = cpf;

                Console.Write("Digite a idade do aluno: ");
                idade = int.Parse(Console.ReadLine());
                aluno.Idade = idade;

                _matriculados.Add(aluno);
                this._idAluno++;
                Console.WriteLine("Aluno Cadastrado");
                return;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Opção inválida");
                return;
            }
        }
        public void ListarAlunos()
        {
            foreach (var aluno in _matriculados)
            {
                Console.WriteLine(aluno.ToString());
            }
        }
        public void Remover(long id)
        {
            foreach (var aluno in _matriculados)
            {
                if (aluno.Id == id)
                {
                    _matriculados.Remove(aluno);
                    Console.WriteLine("Aluno removido com sucesso !");
                    return;
                }
            }
            Console.WriteLine("Aluno não encontrado");
        }
        public void Editar(long id)
        {
            int opc;
            string novoNome, novaIdade;
            foreach (var aluno in _matriculados)
            {
                if (aluno.Id == id)
                {
                    try
                    {
                        Console.Write("1 - NOME \n2-IDADE\n3- AMBOS\nDigite a opção que deseja alterar: ");
                        opc = int.Parse(Console.ReadLine());
                        if (opc>1 && opc<3)
                        {
                            Console.WriteLine("Opção inválida...");
                            return;
                        }
                        switch (opc)
                        {
                            case 1:
                                Console.Write("Novo nome: ");
                                novoNome = Console.ReadLine();
                                aluno.Nome = novoNome;

                                Console.Write($"Nome alterado para: {aluno.Nome} ");
                                return;

                            case 2:
                                Console.Write("Nova idade: ");
                                novaIdade = Console.ReadLine();
                                aluno.CPF = novaIdade;

                                Console.Write($"Idade alterada para: {aluno.Idade}");
                                return;
                            case 3:

                                Console.Write("Novo nome: ");
                                novoNome = Console.ReadLine();
                                aluno.Nome = novoNome;

                                Console.Write("Novo CPF: ");
                                novaIdade = Console.ReadLine();
                                aluno.CPF = novaIdade;

                                Console.Write($"Nome alterado para: {aluno.Nome} / idade alterado para: {aluno.Idade}");
                                return;
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Opção inválida");
                        return;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Opção inválida");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado");
                }
            }
        }
    }
}