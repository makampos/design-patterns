namespace factory.ObjectTrackingAndBulkReplacement;

public class Ref<T> where T : class
{
    public T Value { get; set; }
    public Ref(T value)
    {
        Value = value;
    }
}
