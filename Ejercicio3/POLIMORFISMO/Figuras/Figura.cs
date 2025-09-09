namespace PolimorfismoDemo.Figuras
{
    public abstract class Figura
    {
        public abstract double CalcularArea();

        public virtual void Dibujar()
        {
            Console.WriteLine("Dibujando una figura genérica...");
        }
    }
}