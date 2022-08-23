using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaçao de instanciação de objeto 
            Produto prod = new Produto();
            Cliente cli = new Cliente();
            Console.Write("Digite o nome do cliente ");
            cli.setNome(Console.ReadLine());
            Console.Write("Digite o cpf do cliente ");
            cli.setCpf(Console.ReadLine());
            Console.Write("Digite o endereço do cliente ");
            cli.setEndereco(Console.ReadLine());
            Console.Write("Digite a idade do cliente ");
            cli.setIdade(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite o codigo do produto:");
            prod.setCodigo(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite a descrição do produto:");
            prod.setDescricao(Console.ReadLine());
            Console.Write("Digite o categoria do produto:");
            prod.setCategoria(Console.ReadLine());
            Console.Write("Digite o valor do produto:");
            prod.setValor(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Nome = " + cli.getNome() + "\nEndereco: " + cli.getEndereco() + "\nCPF = " + cli.getCpf() +
                "\nIdade =" + cli.getIdade());
         Console.WriteLine("Código = " + prod.getCodigo() + "\nDescrição: " + prod.getDescricao() + "\nCategoria = " + prod.getCategoria() +
                "\nValor =" + prod.getValor().ToString("c"));
            Console.ReadKey();

        }
    }
}
