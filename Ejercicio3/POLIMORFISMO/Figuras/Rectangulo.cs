namespace PolimorfismoDemo.Figuras
{
    public class Rectangulo : Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double a, double b)
        {
            Ancho = a;
            Alto = b;
        }

        public override double CalcularArea() => Ancho * Alto;

        public override void Dibujar() => Console.WriteLine("Dibujando un rectángulo...");
    }
}