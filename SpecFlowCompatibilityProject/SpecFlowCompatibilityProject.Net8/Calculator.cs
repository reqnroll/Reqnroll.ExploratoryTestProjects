using System.Collections.Generic;

namespace UpgradedReqnrollProject
{
    /// <summary>
    /// Basic calculator implementation that fulfills the specs
    /// </summary>
    public class Calculator
    {
        private readonly Stack<int> _operands = new Stack<int>();

        public int Result => _operands.Peek();

        public void Enter(int operand)
        {
            _operands.Push(operand);
        }

        public void Add()
        {
            _operands.Push(_operands.Pop() + _operands.Pop());
        }

        public void Multiply()
        {
            _operands.Push(_operands.Pop() * _operands.Pop());
        }
    }
}
