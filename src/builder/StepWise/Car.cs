namespace builder.StepWise;

public class Car
{
    public CarType Type;
    public int WheelSize;
    
    public override string ToString()
    {
        return $"Car of type {Type} with {WheelSize} inch wheels";
    }
    
}