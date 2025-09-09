namespace PolimorfismoDemo.Utilidades
{
    public class Calculadora
    {
        public int Sumar(int a, int b) => a + b;

        public double Sumar(double a, double b) => a + b;

        public static Calculadora operator +(Calculadora c1, Calculadora c2)
        {
            return new Calculadora();
        }
    }
}