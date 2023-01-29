using System;
namespace Escola
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var alunos = new AlunoService();
            bool start = true;
            int opc;
            int id;
            Console.WriteLine("Escola do Lucas!");
            try
            {
                while (start == true)
                {
                    Console.WriteLine("1 - CADASTRAR\n2 - LISTAR ALUNOS\n3 - EDITAR\n4 - EXCLUIR\n5 - FINALIZAR\nSELECIONE O OPERAÇÃO DESEJADA: ");
                    opc = int.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                        alunos.Adicionar(new Aluno());
                        break;
                        case 2:
                        alunos.ListarAlunos();
                        break;
                        case 3:
                        Console.Write("Digite o Id do aluno que deseja editar: ");
                        id = int.Parse(Console.ReadLine());
                        alunos.Editar(id);
                        break;
                        case 4:
                        Console.Write("Digite o Id do aluno que deseja excluir: ");
                        id = int.Parse(Console.ReadLine());
                        alunos.Remover(id);
                        break;
                        case 5: start = false;
                        break;
                    }
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}