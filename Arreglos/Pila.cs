namespace Arreglos
{
    internal class Pila
    {
        string[] _arreglo;
        int _tope;
        public Pila(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
        }

        public void Agregar(string dato)
        {
            int max = _arreglo.Length - 1;
            if (_tope > max)
            {
                throw new Exception("Pila llena"); 
            }

            _arreglo[_tope] = dato;
            _tope++;
        }
    }
}
