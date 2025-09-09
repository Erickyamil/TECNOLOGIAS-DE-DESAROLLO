namespace PolimorfismoDemo.Figuras
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double r) => Radio = r;

        public override double CalcularArea() => Math.PI * Radio * Radio;

        public override void Dibujar() => Console.WriteLine("Dibujando un círculo...");
    }
}