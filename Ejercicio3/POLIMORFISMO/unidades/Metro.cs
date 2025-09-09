namespace PolimorfismoDemo.Unidades
{
    public class Metro
    {
        public double Valor { get; set; }

        public Metro(double v) => Valor = v;

        public static implicit operator Metro(double d) => new Metro(d);

        public static explicit operator double(Metro m) => m.Valor;
    }
}