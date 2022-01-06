using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Addition
{
    internal class Complex
    {
        public double real;
        public double imaginary;

        public Complex()
        {

        }

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator + (Complex a, Complex b)
        {
            Complex ans = new Complex();

            ans.real = a.real + b.real;
            ans.imaginary = a.imaginary + b.imaginary;

            return ans;
        }

        public static Complex operator - (Complex a, Complex b)
        {
            Complex ans = new Complex();

            ans.real = a.real - b.real;
            ans.imaginary = a.imaginary - b.imaginary;

            return ans;
        }

        public static Complex operator * (Complex a, Complex b)
        {
            Complex ans = new Complex();

            ans.real = (a.real * b.real) - (a.imaginary * b.imaginary);
            ans.imaginary = (a.real * b.imaginary) + (a.imaginary * b.real);

            return ans;
        }

        public static Complex operator / (Complex a, Complex b)
        {
            Complex ans = new Complex();

            ans.real = ((a.real * b.real) + (a.imaginary * b.imaginary))/((b.real*b.real) + (b.imaginary*b.imaginary));
            ans.imaginary = ((a.imaginary * b.real) - (a.real * b.imaginary)) / ((b.real * b.real) + (b.imaginary * b.imaginary));

            return ans;
        }

        public override string ToString()
        {
            return real.ToString() + "+" + imaginary.ToString() + "i";
        }
    }
}
