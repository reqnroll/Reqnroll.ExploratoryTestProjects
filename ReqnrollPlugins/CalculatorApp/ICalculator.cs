namespace CalculatorApp;

public interface ICalculator
{
    void Enter(int number);
    void Reset();
    int GetResult();
    void Add();
    void Multiply();
}