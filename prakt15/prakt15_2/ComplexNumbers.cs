using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prakt15_2
{
    class ComplexNumbers
    {
        public double real_a;
        public double imaginary_a;
        public double real_b;
        public double imaginary_b;
        public ComplexNumbers(double real_a, double imaginary_a, double real_b, double imaginary_b)
        {
            this.real_a = real_a;
            this.imaginary_a = imaginary_a;
            this.real_b = real_b;
            this.imaginary_b = imaginary_b;
        }
        public string sum()
        {
            double sum1 = real_a + real_b;
            double sum2 = imaginary_a + imaginary_b;
            if (sum2<0) 
                return $"{sum1}{sum2}i";
            else
                return $"{sum1} + {sum2}i";
        }
        public string subtraction()
        {
            
            double sub1 = real_a - real_b;
            double sub2 = imaginary_a - imaginary_b;
            if (sub2 < 0)
                return $"{sub1}{sub2}i";
            else
                return $"{sub1} + {sub2}i";
        }
        public string multiplication()
        {
            double mult1 = real_a * real_b - imaginary_a * imaginary_b;
            double mult2 = real_a * imaginary_b + imaginary_a * real_b;
            if (mult2<0)
                return $"{mult1}{mult2}i";
            else
                return $"{mult1} + {mult2}i";
        }

    }
}
