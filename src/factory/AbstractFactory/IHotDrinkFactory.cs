namespace factory.AbstractFactory;

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}