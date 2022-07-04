namespace Lab5.Commands
{
    internal abstract class Command
    {
        protected ArithmeticUnit arithmeticUnit;
        protected LogicUnit logicUnit;
        protected Complex operand1;
        protected Complex operand2;

        public abstract void Execute();
    }
}
