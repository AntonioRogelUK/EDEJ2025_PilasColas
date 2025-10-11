namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(2);
            numeros.Add(2);
            numeros.Add(3);
            numeros.Add(4);
            numeros.Add(5);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros[3] = 40;
            Console.WriteLine();
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.RemoveAt(0);

            Console.WriteLine();
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros[3] = 100;
            Console.WriteLine();
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            numeros.Remove(2);
            Console.WriteLine();
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine($"la cantidad de elementos en la lista es de {numeros.Count}");

        }

    }
}
