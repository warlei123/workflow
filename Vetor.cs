namespace Estrutura_dio
{
    using System;
    public class Vetor
    {
        public int[] Idade = new int[0];

        public string[] Nome = new string[0];

        public Vetor()
        {
            string[] nome = new string[5];

            int[] idade = new int[5];

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Escreva o nome");
                var nomeDigitado = Console.ReadLine();

                nome[i] = nomeDigitado;

                Console.WriteLine();
                Console.WriteLine("Em que ano nasceu");
                var anoDigitado = Console.ReadLine();
                var anoConvertido = Convert.ToInt32(anoDigitado);
                int Hj = DateTime.Now.Year;

                var idadePessoa = Hj - anoConvertido;

                idade[i] = idadePessoa;

            }
            var index = 0;

            foreach (var item in nome)
            {

                Console.WriteLine($"Nome: {nome[index]}\nIdade: {idade[index]}  ");
                index++;

            }
        }
    }
}