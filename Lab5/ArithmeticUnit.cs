namespace Lab5
{
    internal class ArithmeticUnit
    {
        public Complex Register { get; private set; }

        public ArithmeticUnit()
        {
            Register = new Complex(0, 0);
        }

        public void Run(char operationCode, Complex operand1, Complex operand2)
        {
            switch (operationCode)
            {
                case '+':
                    Register = operand1 + operand2;
                    break;
                case '-':
                    Register = operand1 - operand2;
                    break;
                case '*':
                    Register = operand1 * operand2;
                    break;
                case '/':
                    Register = operand1 / operand2;
                    break;
            }
        }
    }
}
