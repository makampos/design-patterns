using System.ComponentModel.DataAnnotations;

namespace builder.StepWise;

public interface IBuildCar
{
    public Car Build();
}