using System;

namespace Lab5.Commands
{
    internal class Div : Command
    {
        public Div(ArithmeticUnit unit, Complex operand1, Complex operand2)
        {
            this.arithmeticUnit = unit;
            this.operand1 = operand1;
            this.operand2 = operand2;
        }

        public override void Execute()
        {
            if (operand2.Equals(Complex.Zero))
                throw new DivideByZeroException();

            arithmeticUnit.Run('/', operand1, operand2);
        }
    }
}
