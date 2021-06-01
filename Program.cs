using System;

namespace Vetores_Exercicio_Senac {
    class Program {
        static void Main(string[] args) {


            //primeira parte
            Console.Write("Quantidades de números que será digitado: ");
            int n = int.Parse(Console.ReadLine());
            int[] vect = new int[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Escreva o numero que vai na posição : " + (i));
                vect[i] = int.Parse(Console.ReadLine());
            }

            //segunda parte
            //indentificando o maior valor
            int maior = 0;
            for (int i = 0; i < n; i++) {
                if (i == 0) {
                    maior = vect[i];
                }

                if (vect[i] > maior) {
                    maior = vect[i];
                }
            }

            //indentificando o menor valor
            int menor = 0;
            for (int i = 0; i < n; i++) {
                if (i == 0) {
                    menor = vect[i];
                }

                if (vect[i] < menor) {
                    menor = vect[i];
                }
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("O Menor valor do vetor é : " + menor);
            Console.WriteLine("O Maior valor do vetor é : " + maior);

            //calculando a diferença entre eles
            int dif = maior - menor;
            Console.WriteLine("A diferença entre eles é : " + dif);
            Console.WriteLine(" _________________________");
            //terceira parte
            //indentificando se o vetor é crescente ou não
            int crescente = 1;

            for (int i = 1; i < n; i++) {

                if (vect[i - 1] <= vect[i]) {
                    crescente++;
                }
            }


            if (crescente == n) {
                Console.WriteLine("| o vetor é crescente     |");
            }
            else { Console.WriteLine("| o vetor não é crescente |"); }
            Console.WriteLine("|_________________________|");
        }
    }
}