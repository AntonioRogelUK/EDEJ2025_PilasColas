namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Pila pila = new Pila(5);

                // pila.Agregar("A");
                // pila.Agregar("B");
                // pila.Agregar("C");
                // pila.Agregar("D");
                // pila.Agregar("E");
                //// pila.Agregar("F");

                // Imprimir(pila);
                // pila.Eliminar();

                // Imprimir(pila);
                // pila.Eliminar();

                // Imprimir(pila);
                // pila.Eliminar();

                // Imprimir(pila);
                // pila.Eliminar();

                // Imprimir(pila);
                // pila.Eliminar();

                // Imprimir(pila);
                // pila.Eliminar();

                Cola cola = new Cola(5);
                cola.Agregar("A");
                cola.Agregar("B");
                cola.Agregar("C");
                cola.Agregar("D");
                cola.Agregar("E");

                Imprimir(cola);

                for (int i = 0; i < 5; i++)
                {
                    cola.Eliminar();
                    Imprimir(cola);
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        static void Imprimir(Pila pila)
        {
            Console.WriteLine("mostrando contenido");
            Console.WriteLine(pila.ObtenerDatos());
        }
        static void Imprimir(Cola cola)
        {
            Console.WriteLine("mostrando contenido");
            Console.WriteLine(cola.ObtenerDatos());
        }

    }
}
