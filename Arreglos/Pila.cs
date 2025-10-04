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

        public void Eliminar()
        {
            if (_tope == 0)
            {
                throw new Exception("la pila esta vacia");
            }

            _tope--;
            _arreglo[_tope] = string.Empty;
        }

        public string ObtenerDatos()
        {
            string datos = string.Empty;
            for (int i = 0; i < _tope; i++)
            {
                datos += _arreglo[i] + Environment.NewLine;
            }
            return datos;
        }
    }
}
