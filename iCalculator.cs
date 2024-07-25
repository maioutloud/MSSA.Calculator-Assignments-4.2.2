using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_4._2._2
{
    // ASSIGNMENT 4.2.2 : CALCULATOR
    // CCAD12 : MAI LOR
    interface iCalculator
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
    }
    public class Calculator : iCalculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2) 
        {
            return num1 / num2;
        }
    }
}
