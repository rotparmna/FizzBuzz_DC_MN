using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> lista = new Program().Jugar();
            foreach (var item in lista)
            {
                Console.Write(item + "\n");
            }
            Console.ReadKey();
        }

        public int DivisiblexTres(int numero)
        {
            return numero % 3;
        }

        public int DivisiblexCinco(int numero)
        {
            return numero % 5;
        }

        public bool DivisiblexCincoyTres(int numero)
        {
            return DivisiblexCinco(numero)==0 && DivisiblexTres(numero)==0;
        }

        public List<string> Jugar()
        {
            List<string> listaNumeros = new List<string>();
            int totalNumeros = 99;
            string fizz = "Fizz";
            string buzz = "Buzz";
            string fizzBuzz = "FizzBuzz";

            for (int i = 1; i <= totalNumeros; i++)
            {
                if (this.DivisiblexCincoyTres(i))
                    listaNumeros.Add(fizzBuzz);
                else if (this.DivisiblexTres(i)==0)
                    listaNumeros.Add(fizz);
                else if (this.DivisiblexCinco(i)==0)
                    listaNumeros.Add(buzz);
                else
                    listaNumeros.Add(i.ToString());
            }
            return listaNumeros;
        }

    }
}
