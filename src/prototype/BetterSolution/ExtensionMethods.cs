namespace prototype.BetterSolution;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this IDeepCopyable<T> item) where T : new()
    {
        return item.DeepCopy();
    }
    public static T DeepCopy<T>(this T person) 
        where T : Person, new()
    {
        return ((IDeepCopyable<T>)person).DeepCopy();
    }
}