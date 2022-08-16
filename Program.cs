using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula1_programação_orientada_a_objeto
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // instanciar o objeto 
            Veiculo golf = new Veiculo();
           
            Console.WriteLine("Digite a marca");
            string marca=Console.ReadLine();
            
            Console.WriteLine("Digite a modelo");
            string modelo = Console.ReadLine();
            
            Console.WriteLine("Digite a placa");
            string placa = Console.ReadLine();
            
            Console.WriteLine("Digite o ano");
            int ano = Convert.ToInt32(Console.ReadLine());
            // objeto chamando método atribuir

            golf.atribuir(marca, modelo, placa, ano);
            Console.WriteLine(golf.retorna());

            Console.ReadKey();
        }
    }
}
