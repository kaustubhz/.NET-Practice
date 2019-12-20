using System;

namespace TestClassLib
{
    public class Complex
    {
        private int real, imaginary;

        public int Real { get => real; set => real = value; }
        public int Imaginary { get => imaginary; set => imaginary = value; }

        public Complex(int real, int imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }
        public override string ToString()
        {
            return "Real Number=" + Real + " Imaginary Number=" + Imaginary;
        }

        ~Complex()
        {
        }

        public static void GetData()
        {
            Console.WriteLine("Hello from Class Lib");
        }

    }
}
