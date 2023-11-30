using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos {
    class Program {
        static void Main(string[] args) {

            int primeiro, a, b;

            Console.WriteLine("Digite dois numeros inteiros: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > b) {
                primeiro = a;
            }
            else {
                primeiro = b;
            }

            if (primeiro % 2 == 0) {
                Console.WriteLine("Sao multiplos.");
            }
            else {
                Console.WriteLine("Nao sao multiplos.");
            }
        }
    }
}
