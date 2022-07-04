namespace Lab5.Commands
{
    internal class Add : Command
    {
        public Add(ArithmeticUnit unit, Complex operand1, Complex operand2)
        {
            this.arithmeticUnit = unit;
            this.operand1 = operand1;
            this.operand2 = operand2;
        }

        public override void Execute()
        {
            arithmeticUnit.Run('+', operand1, operand2);
        }
    }
}
