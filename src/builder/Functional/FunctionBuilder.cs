namespace builder.Functional;

public abstract class FunctionBuilder<TSubject, TSelf>
    where TSelf : FunctionBuilder<TSubject, TSelf>
    where TSubject : new()
{
    private readonly List<Func<Person, Person>> _actions = new List<Func<Person, Person>>();
    public TSelf Do(Action<Person> action) => AddAction(action);
    public Person Build() => _actions.Aggregate(new Person(), (p, f) => f(p));
    private TSelf AddAction(Action<Person> action)
    {
        _actions.Add(p => { action(p); return p; });
        return this as TSelf;
    }
}