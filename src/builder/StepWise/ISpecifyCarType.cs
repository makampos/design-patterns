namespace builder.StepWise;

public interface ISpecifyCarType
{
    ISpecifyWheelSize OfType(CarType type);

}