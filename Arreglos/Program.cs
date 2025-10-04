namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pila pila = new Pila(5);

                pila.Agregar("A");
                pila.Agregar("B");
                pila.Agregar("C");
                pila.Agregar("D");
                pila.Agregar("E");
               // pila.Agregar("F");

                Imprimir(pila);
                pila.Eliminar();

                Imprimir(pila);
                pila.Eliminar();

                Imprimir(pila);
                pila.Eliminar();

                Imprimir(pila);
                pila.Eliminar();

                Imprimir(pila);
                pila.Eliminar();

                Imprimir(pila);
                pila.Eliminar();


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

    }
}
