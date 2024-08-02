using ConsoleApp17;

List<Numeros> listaNumeros= new List<Numeros>();
bool menu = true;
int opcion;
while (menu)
{
    Console.Clear();
    Console.WriteLine("1. Ingresar numeros");
    Console.WriteLine("2. Mostrar numeros");
    opcion= Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            {
                Console.Clear() ;
                Numeros.IngresarNumeros(listaNumeros);
                break;
            }
        case 2:
            {
                Console.Clear() ;
                Numeros.MostrarNumeros(listaNumeros);
                Console.ReadKey();
                break;
            }
        case 3:
            {
                Console.Clear();
                Numeros.MultiplicarNumeros(listaNumeros);
                Console.ReadKey();
                break;
            }
    }
}