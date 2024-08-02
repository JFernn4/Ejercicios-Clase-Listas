using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Numeros
    {
        public int Numero { get; set; }

        public Numeros(int numero)
        {
            Numero = numero;
        }
        public static void IngresarNumeros(List<Numeros> listaNumeros)
        {
            int numero = 0;
            Console.WriteLine("Ingrese un numero.");
            numero = Convert.ToInt32(Console.ReadLine());
            Numeros numero1= new Numeros(numero);
            listaNumeros.Add(numero1);
        }
        public static void MostrarNumeros(List<Numeros> listaNumeros)
        {
            foreach (Numeros numero in listaNumeros)
            {
                Console.WriteLine(numero.Numero);
            }
        }

        public static void MultiplicarNumeros(List<Numeros> listaNumeros)
        {
            int multiplicacion = 1;
            foreach (Numeros numero in listaNumeros)
            {
                multiplicacion *= numero.Numero;
                Console.WriteLine(multiplicacion);
            }
        }
    }
}
