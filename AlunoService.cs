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
                Console.WriteLine("Digite o nome do aluno: ");
                nome = Console.ReadLine();
                aluno.Nome = nome;
                Console.WriteLine("Digite o CPF do aluno: ");
                cpf = Console.ReadLine();
                aluno.CPF = cpf;
                Console.WriteLine("Digite a idade do aluno: ");
                idade = int.Parse(Console.ReadLine());
                aluno.Idade = idade;
                _matriculados.Add(aluno);
                this._idAluno++;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Opção inválida");
                return;
            }
            finally
            {
                Console.WriteLine("Aluno Cadastrado, Retornando para o inicio");
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
                    return;
                }
            }
            Console.WriteLine("Aluno não encontrado");
        }
        public void Editar(long id)
        {
            int opc;
            string novoNome, novoCPF;
            foreach (var aluno in _matriculados)
            {
                if (aluno.Id == id)
                {
                    try
                    {
                        Console.Write("1 - NOME \n2-CPF\n3- AMBOS\nDigite a opção que deseja alterar: ");
                        opc = int.Parse(Console.ReadLine());
                        switch (opc)
                        {
                            case 1:
                                Console.Write("Novo nome: ");
                                novoNome = Console.ReadLine();
                                aluno.Nome = novoNome;
                                Console.Write("Nome alterado para: ");
                                break;

                            case 2:
                                Console.Write("Novo CPF: ");
                                novoCPF = Console.ReadLine();
                                aluno.CPF = novoCPF;
                                Console.Write("CPF alterado para: ");
                                break;

                            case 3:
                                Console.Write("Novo nome: ");
                                novoNome = Console.ReadLine();
                                aluno.Nome = novoNome;
                                Console.Write("Novo CPF: ");
                                novoCPF = Console.ReadLine();
                                aluno.CPF = novoCPF;
                                Console.Write($"Nome alterado para: {aluno.Nome} / CPF alterado para: {aluno.CPF}");
                                break;
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
                    finally
                    {
                        Console.Write("Retornando para o inicio");
                    }
                }
            }
        }
    }
}