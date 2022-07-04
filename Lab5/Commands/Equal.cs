namespace Lab5.Commands
{
    internal class Equal : Command
    {
        public Equal(LogicUnit unit, Complex operand1, Complex operand2)
        {
            this.logicUnit = unit;
            this.operand1 = operand1;
            this.operand2 = operand2;
        }

        public override void Execute()
        {
            logicUnit.Run('=', operand1, operand2);
        }
    }
}
