using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld4
{
    class Program
    {
        static void Main(string[] args)
        {
            //array é uma super variavel, podendo armazenar quantos valores precisar. 
            //Exemplo:
            string[] produtos = new string[5] //c# nao pode mudar o tamanho do array
            {
             "Fifa", "Dofus", "LoL", "Dota", "Valorant"
            };

            //acessar informação especifica do array é só inserir a numeração no cochetes de acordo com a posição:
            Console.WriteLine(produtos[0]);

            //modificar valor especifico no array:
            produtos[0] = "FIFA 21";

            Console.WriteLine(produtos[0]);


            //outra forma de criar array (mais facil), identifica automatico a quantidade:
            int[] valores = {40, 50, 60, 70, 80, 90};

            Console.ReadLine();
        }
    }
}
