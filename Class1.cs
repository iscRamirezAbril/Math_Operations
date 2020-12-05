using System;
using System.Transactions;

namespace Operations
{
    // Creation of a class called "SumOp"
    public class SumOp
    {
        // Class Method
        public double Sum(double Num1, double Num2)
        {
            double Res_Sum; // Declaration of a variable
            Res_Sum = Num1 + Num2;
            return Res_Sum; // Value return
        }
    }

    // Creation of a class called "SustOp"
    public class SustOp
    {
        // Class Method
        public double Sust(double Num1, double Num2)
        {
            double Res_Sust; // Declaration of a variable
            Res_Sust = Num1 - Num2;
            return Res_Sust; // Value return
        }
    }

    // Creation of a class called "MultOp"
    public class MultOp
    {
        // Class Method
        public double Mult(double Num1, double Num2)
        {
            double Res_Mult; // Declaration of a variable
            Res_Mult = Num1 * Num2;
            return Res_Mult; // Value return
        }
    }

    // Creation of a class called "DivOp"
    public class DivOp
    {
        // Class Method
        public double Div(double Num1, double Num2)
        {
            double Res_Div; // Declaration of a variable
            Res_Div = Num1 / Num2;
            return Res_Div; // Value return
        }
    }

    // Creation of a class called "SquR"
    public class SquR
    {
        double x = 1.0; // Variable declaration

        // Class Method
        public double Square(double Num1)
        {
            double Res_SquR; // Variable declaration

            // for loop
            for (int k = 1; k < 10; k++)
            {
                x = (x + Num1 / x) / 2;
            }

            Res_SquR = x; // Variable "Res_SquR" is assigned "x" value
            return Res_SquR; // Value return
        }
    }

    // Creation of a class called "Percentage"
    public class Percentage
    {
        // Class Method 
        public double Percent(double Num1)
        {
            double Res_Perc; // Variable declaration
            Res_Perc = (Num1) / (100);
            return Res_Perc; // Value return
        }
    }

    // Creation of a class called "xCubed"
    public class xCubed
    {
        // Class Method
        public double xCub(double Num1)
        {
            double Res_Cubed; // Variable declaration
            Res_Cubed = Num1 * Num1 * Num1;
            return Res_Cubed; // Value return
        }
    }

    // Creation of a class called "xSqurd"
    public class xSqurd
    {
        // Class Method
        public double xSqr(double Num1)
        {
            double Res_Squr; // Variable declaration
            Res_Squr = Num1 * Num1;
            return Res_Squr; // Value return
        }
    }

    // Creation of a class called "xRNeg1"
    public class xRNeg1
    {
        // Class method
        public double xNeg1(double Num1)
        {
            double Res_xNegt; // Variable declaration
            Res_xNegt = 1 / Num1;
            return Res_xNegt; // Value return
        }
    }

    // Creation of a class called "Raised10"
    public class Raised10
    {
        double Res_RTen = 1; // Variable declaration

        // Class method
        public double TenRx(double Num1)
        {
            // for loop
            for (int k = 1; k <= Num1; k++)
            {
                Res_RTen *= 10;
            }
            return Res_RTen; // Value return
        }
    }

    // Creation of a class called "Factorial"
    public class Factorial
    {
        double Res_Fac = 1; // Variable declaration

        // Class Method
        public double FactOp(double Num1)
        {
            // for loop
            for (double k = 1; k <= Num1; k++)
            {
                Res_Fac *= k;
            }
            return Res_Fac; // Value return
        }
    }

    // Creation of a class called "Exp"
    public class Exp
    {
        // Class method
        public double NumExp(double Num1, double Num2)
        {
            double Res_PowNum = Num1; // Variable declaration

            // for loop
            for (int k = 1; k < Num2; k++)
            {
                Res_PowNum *= Num1;
            }
            return Res_PowNum; // Value return
        }
    }

    // Creation of a class called "Logarithm"
    public class Logarithm
    {
        /*
         --- FORMULA ---
        Log_10(a) ≈ 0.87x * (A + 1)
        that means...

        x = [(a - 1) / (a + 1)]
        and

        A = x^2 * [(1/3) + { (1/5)x^2} ]

        --- Variables ---
        a = The number that you want to calculate it logarithm
         */

        // Class method
        public double Log(double Num1)
        {
            double x, A, Res_Log; // Variable declaration

            x = (Num1 - 1) / (Num1 + 1);
            A = (x * x) * ((1 / 3) + (1 / 5) * (x * x));

            Res_Log = 0.87 * x * (A + 1);
            return Res_Log; // Value return
        }
    }

    // Creation of a class called "NatLog"
    public class NatLog
    {
        /*
        --- FORMULA ---
       Log_10(a) ≈ [0.87x * (A + 1)] * 2.3025
       that means...

       x = [(a - 1) / (a + 1)]
       and

       A = x^2 * [(1/3) + { (1/5)x^2} ]

       --- Variables ---
       a = The number that you want to calculate it logarithm
        */

        // Class method
        public double NaturalLog(double Num1)
        {
            double x, A, Res_NatLog; // Variable declaration

            x = (Num1 - 1) / (Num1 + 1);
            A = (x * x) * ((1 / 3) + (1 / 5) * (x * x));

            Res_NatLog = (0.87 * x * (A + 1)) * 2.3025;
            return Res_NatLog; // Value return
        }
    }

    // Creation of a class called "sin"
    public class sin
    {
        // Class Method
        public double Sin(double Num1)
        {               // Dividendo // Divisor
            double Res_Sin, Dividend, Divider, sig; // Variable declaration
            int i, j; // Variable declaration

            Res_Sin = 0;

            // for loop
            for (i = 0; i <= 20; i++)
            {
                Dividend = 1;
                // for loop
                for (j = 0; j < (2 * i + 1); j++)          // ---------------------- //
                {                                          // ------ DIVIDEND ------ //
                    Dividend *= Num1;                      // ---------------------- //
                }
                Divider = 1;

                // for loop
                for (j = 1; j <= (2 * i + 1); j++)         // --------------------- //
                {                                          // ------ DIVIDER ------ //
                    Divider *= j;                          // --------------------- //
                }

                // if
                if (i % 2 == 0)
                {
                    sig = 1;
                }   
                // else
                else
                {
                    sig = -1;
                }

                Res_Sin += (Dividend / Divider) * sig;
            }
            return Res_Sin; // Value return
        } 
    }

    // Creation of a class called "cos"
    public class cos
    {
        // Class Method
        public double Cos(double Num1)
        {
                         // Dividendo // Divisor
            double Res_Cos, Dividend, Divider, sig; // Variable declaration
            int i, j; // Variable declaration

            Res_Cos = 0;

            // for loop
            for (i = 0; i <= 20; i++)
            {
                Dividend = 1;
                // for loop
                for (j = 0; j < (2 * i); j++)              // ---------------------- //
                {                                          // ------ DIVIDEND ------ //
                    Dividend *= Num1;                      // ---------------------- //
                }
                Divider = 1;

                // for loop
                for (j = 2; j <= (2 * i); j++)             // --------------------- //
                {                                          // ------ DIVIDER ------ //
                    Divider *= j;                          // --------------------- //
                }

               // if
               if (i % 2 == 0)
               {
                   sig = -1;
               }
               // else
               else
               {
                   sig = 1;
               }

                Res_Cos = Res_Cos - (Dividend / Divider) * sig;
            }
            return Res_Cos; // Value return
        }
    }

    // Creation of a class called "sinh"
    public class sinh
    {
        // Class Method
        public double Sinh(double Num1)
        {
            double Res_Sinh, Dividend, Divider; // Variable declaration
            int i, j; // Variable declaration

            Res_Sinh = 0;

            // for loop
            for (i = 0; i <= 20; i++)
            {
                Dividend = 1;
                // for loop
                for (j = 0; j < (2 * i + 1); j++)          // ---------------------- //
                {                                          // ------ DIVIDEND ------ //
                    Dividend *= Num1;                      // ---------------------- //
                }

                Divider = 1;
                // for loop
                for (j = 1; j <= (2 * i + 1); j++)         // --------------------- //
                {                                          // ------ DIVIDER ------ //
                    Divider *= j;                          // --------------------- //
                }

                Res_Sinh += (Dividend / Divider);
            }
            return Res_Sinh; // Value return
        }
    }

    // Creation of a class called "cosh"
    public class cosh
    {
        // Class Method
        public double Cosh(double Num1)
        {
            double Res_Cosh, Dividend, Divider; // Variable declaration
            int i, j; // Variable declaration

            Res_Cosh = 0;

            // for loop
            for (i = 0; i <= 20; i++)
            {
                Dividend = 1;
                // for loop
                for (j = 0; j < (2 * i); j++)              // ---------------------- //
                {                                          // ------ DIVIDEND ------ //
                    Dividend *= Num1;                      // ---------------------- //
                }

                Divider = 1;
                // for loop
                for (j = 1; j <= (2 * i); j++)             // --------------------- //
                {                                          // ------ DIVIDER ------ //
                    Divider *= j;                          // --------------------- //
                }

                Res_Cosh += (Dividend / Divider);
            }
            return Res_Cosh; // Value return
        }
    }
}
