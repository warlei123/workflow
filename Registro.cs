namespace Estrutura_dio
{
    using System;
    using System.Collections.Generic;
    public class Registro
    {

        public string Nome;

        public double Preço;

        public int Paginas;

        List<Registro> listaDeLivros = new List<Registro>();
        public Registro()
        {
            string opcaoEscolhida = opcoes();

            while (opcaoEscolhida != "X")
            {
                switch (opcaoEscolhida)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Nome do livro");
                        var nomeDoLivro = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Quantas Paginas");
                        var nPaginas = Console.ReadLine();
                        var numeroDePaginas = Convert.ToInt32(nPaginas);

                        Console.WriteLine();
                        Console.WriteLine("Qual o preço");
                        var pDoLivro = Console.ReadLine();
                        var precoDoLivro = Convert.ToDouble(pDoLivro);

                        this.Nome = nomeDoLivro;
                        this.Paginas = numeroDePaginas;
                        this.Preço = precoDoLivro;

                        listaDeLivros.Add(this);

                        break;

                    case "2":

                        foreach (var item in listaDeLivros)
                        {
                            Console.WriteLine($"\nLivro {item.Nome}\n{item.Paginas} Paginas\nPreço: R${item.Preço}\n");
                        }

                        break;

                    default:

                        break;
                }
                opcaoEscolhida = opcoes();
            }

        }

        private static string opcoes()
        {
            Console.WriteLine();
            Console.WriteLine("1- Adicionar Livro");
            Console.WriteLine("X- Sair");
            var opcaoEscolhida = Console.ReadLine().ToUpper();
            return opcaoEscolhida;
        }
    }
}