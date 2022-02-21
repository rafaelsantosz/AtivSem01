using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtivSem01.Classes;
using static AtivSem01.Classes.Cadastros;

namespace AtivSem01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - MÉTODO: SOMAR MATRIZ DE INTEIROS");

            var matrizCriada = Funcoes.CriarMatriz();
            var resultadoSoma = Funcoes.Somar(matrizCriada);
            Console.WriteLine($"A soma total da matriz é: {resultadoSoma}");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("2 - MÉTODO: MAIOR NÚMERO");

            var arrayCriado = Funcoes.CriarArray();
            var maiorNumero = Funcoes.MaiorNumero(arrayCriado[0], arrayCriado[1], arrayCriado[2], arrayCriado[3]);
            Console.WriteLine($"O maior número informado foi: {maiorNumero}");

            Console.ReadKey();
            Console.Clear();

            Pedidos pedidos = new Pedidos();
            Clientes cliente = new Clientes();
            Console.WriteLine("3 - MÉTODOS DE CLIENTES E PEDIDOS (Exemplos)");

            Console.Write("Método Deletar - Classe Clientes: ");
            cliente.Deletar();

            Console.Write("Método Deletar - Classe Pedidos: ");
            pedidos.Deletar();

            Console.Write("Método Inserir - Classe Pedidos: ");
            pedidos.Inserir();

            Console.ReadKey();
        }
    }
}
