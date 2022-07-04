using Lab5.Commands;

namespace Lab5
{
    internal class Calculator
    {
        ArithmeticUnit arithmeticUnit;
        LogicUnit logicUnit;
        ControlUnit controlUnit;

        public Calculator()
        {
            arithmeticUnit = new ArithmeticUnit();
            logicUnit = new LogicUnit();
            controlUnit = new ControlUnit();
        }

        private Complex RunArithmetic(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return arithmeticUnit.Register;
        }

        private bool RunLogic(Command command)
        {
            controlUnit.StoreCommand(command);
            controlUnit.ExecuteCommand();
            return logicUnit.Register;
        }

        public Complex Add(Complex operand1, Complex operand2)
        {
            return RunArithmetic(new Add(arithmeticUnit, operand1, operand2));
        }

        public Complex Sub(Complex operand1, Complex operand2)
        {
            return RunArithmetic(new Sub(arithmeticUnit, operand1, operand2));
        }

        public Complex Mul(Complex operand1, Complex operand2)
        {
            return RunArithmetic(new Mul(arithmeticUnit, operand1, operand2));
        }

        public Complex Div(Complex operand1, Complex operand2)
        {
            return RunArithmetic(new Div(arithmeticUnit, operand1, operand2));
        }

        public bool Equal(Complex operand1, Complex operand2)
        {
            return RunLogic(new Equal(logicUnit, operand1, operand2));
        }

        public bool NotEqual(Complex operand1, Complex operand2)
        {
            return RunLogic(new NotEqual(logicUnit, operand1, operand2));
        }
    }
}
