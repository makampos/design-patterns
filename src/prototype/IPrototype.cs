namespace prototype;

public interface IPrototype<T>
{
    T DeepCopy();
}