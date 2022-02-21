using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem01.Classes
{
    /* No arquivo Cadastros.cs, monte a seguinte estrutura de classes:
       1. Uma Interface: IOperacoesBD, com os seguintes métodos sem retorno: Inserir, Alterar, Deletar, Pesquisar.
       2. Uma Classe Abstrata: Cadastros, que implementa a Interface acima.
       3. Inclua na Classe Abstrata uma propriedade protegida chamada: Conexao.
       4. Inclua duas Classes que não podem ser herdadas, que derivam da Classe Abstrata : Clientes e Pedidos.
       5. As Classes Clientes e Pedidos devem preencher a propriedade Conexão a partir de seus construtores.
       6. O método Deletar deve sofrer sobrecarga nas duas Classes, executando o código da Classe Superior
        e incluindo algo novo.
       7. O método Inserir deve sofrer sobrecarga na classe Pedidos, desconsiderando a implementação do método da 
        classe Superior. */

    public class Cadastros
    {
        //Interface com métodos sem retorno
        interface IOperacoesBD
        {
            void Inserir();
            void Alterar();
            void Deletar();
            void Pesquisar();
        }

        //Classe Abstrata que implementa a Interface acima
        public abstract class Cadastro : IOperacoesBD
        {
            protected bool Conexao; //Propriedade protegida chamada: Conexao

            public void Inserir()
            {
                Console.Write("Arquivo Inserido!");
            }
            public void Alterar()
            {

            }
            public void Deletar()
            {
                Console.Write("Arquivo Deletado!");
            }
            public void Pesquisar()
            {

            }
        }

        //Classe que não pode ser herdada, que deriva da Classe Abstrata
        public sealed class Clientes : Cadastro
        {
            public Clientes()
            {
                Conexao = true; //Classe Clientes deve preencher a propriedade Conexão a partir de seu construtor
            }

            /* O método Deletar deve sofrer sobrecarga na Classe Clientes, executando o código da Classe Superior
            e incluindo algo novo. */
            public void Deletar(string cliente)
            {
                Console.Write("Arquivo Deletado! ");
                Console.WriteLine("O Cliente "+cliente+" foi deletado com sucesso!");
            }
        }

        //Classe que não pode ser herdada, que deriva da Classe Abstrata
        public sealed class Pedidos : Cadastro
        {
            public Pedidos()
            {
                Conexao = true; //Classe Pedidos deve preencher a propriedade Conexão a partir de seu construtor
            }

            /* O método Inserir deve sofrer sobrecarga na classe Pedidos, desconsiderando a implementação do método da
            classe Superior */
            public void Inserir(int pedido)
            {
                Console.WriteLine($"Pedido {pedido} foi inserido com sucesso!");
            }

            /* O método Deletar deve sofrer sobrecarga na Classe Pedidos, executando o código da Classe Superior
            e incluindo algo novo */
            public void Deletar(int pedido)
            {
                Console.Write("Arquivo Deletado! ");
                Console.WriteLine("O Pedido "+pedido + " foi deletado com sucesso!");
            }
        }
    }
}
