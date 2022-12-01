namespace Practice_1
{
    public interface IMathOperation<T>
    {
        T Addition(params T[] values);
        T Substraction(params T[] values);
        T Multiplication(params T[] values);
    }
}