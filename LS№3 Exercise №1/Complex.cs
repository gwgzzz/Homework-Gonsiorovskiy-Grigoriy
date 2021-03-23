namespace LS_3_Exercise__1
{
    struct Complex 
    {
        double a, b;

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override string ToString()
        {
            return (b < 0) ? $"{a} - {-b}i" : $"{a} + {b}i";
        }

        public static Complex operator +(Complex x, Complex z)
        {
            return new Complex(a: x.a + z.a, b: x.b + z.b);
        }

        public static Complex operator -(Complex x, Complex z)
        {
            return new Complex(a: x.a - z.a, b: x.b - z.b);
        }


    }
}
