namespace Lab5
{
    internal class LogicUnit
    {
        public bool Register { get; private set; }

        public LogicUnit()
        {
            Register = false;
        }

        public void Run(char operationCode, Complex operand1, Complex operand2)
        {
            switch (operationCode)
            {
                case '=':
                    Register = operand1 == operand2;
                    break;
                case '!':
                    Register = operand1 != operand2;
                    break;
            }
        }
    }
}
