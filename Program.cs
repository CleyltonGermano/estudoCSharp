using System;

namespace urna
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa cliente = new Pessoa();
            Console.WriteLine("Qual seu nome?");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("Seja bem vindo " + cliente.nome);

            Console.WriteLine("Qual a sua idade?");
            cliente.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu sexo?");
            cliente.sexo = Console.ReadLine();


            if (cliente.idade < 16)
            {
                Console.WriteLine(cliente.nome + " do sexo " + cliente.sexo + " ,de " + cliente.idade + " anos de idade" + " não pode votar");
            }
            else if (cliente.idade >= 16 && cliente.idade < 18)
            {
                Console.WriteLine(cliente.nome + " do sexo " + cliente.sexo + " ,de " + cliente.idade + " anos de idade" + " pode votar");
            }
            else if (cliente.idade >= 18 && cliente.idade < 65)
            {
                Console.WriteLine(cliente.nome + " do sexo " + cliente.sexo + " ,de " + cliente.idade + " anos de idade" + " voto Obrigatorio");
            }
            else
            {
                Console.WriteLine(cliente.nome + " do sexo " + cliente.sexo + " ,de " + cliente.idade + " anos de idade" + " voto não obrigatorio");
            }

          

        }
    }
}
