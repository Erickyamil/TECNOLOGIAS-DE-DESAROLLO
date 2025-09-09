namespace PolimorfismoDemo.Genericos
{
    public class Caja<T>
    {
        private T contenido;

        public void Guardar(T valor) => contenido = valor;

        public T Obtener() => contenido;
    }
}