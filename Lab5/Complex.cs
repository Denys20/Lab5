namespace Lab5
{
    internal class Complex
    {
        public static readonly Complex Zero = new Complex(0, 0);

        public double X { get; set; }
        public double Y { get; set; }

        public Complex() { }

        public Complex(double real, double imaginary)
        {
            X = real;
            Y = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex() { X = c1.X + c2.X, Y = c1.Y + c2.Y };
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex() { X = c1.X - c2.X, Y = c1.Y - c2.Y };
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex() { X = c1.X * c2.X - c1.Y * c2.Y, Y = c1.X * c2.Y + c2.X * c1.Y };
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double denominator = c2.X * c2.X + c2.Y * c2.Y;
            return new Complex()
            {
                X = (c1.X * c2.X + c1.Y * c2.Y) / denominator,
                Y = (c1.Y * c2.X - c1.X * c2.Y) / denominator
            };
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return !c1.Equals(c2);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Complex c = (Complex)obj;
                return this.X == c.X && this.Y == c.Y;
            }
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}{1:+#;-#;+0}i", X, Y);
        }
    }
}
