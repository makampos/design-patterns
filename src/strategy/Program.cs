// reference: https://learn.microsoft.com/en-us/dotnet/api/system.icomparable-1?view=net-7.0
namespace strategy
{
    public class Program 
    {
        public class Person : IComparable<Person>, IComparable
        {
            public int Id;
            public string Name;
            public int Age;
            public Person(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }
            private sealed class NameRelationComparecer : IComparer<Person>
            {
                public int Compare(Person x, Person y)
                {
                    if (ReferenceEquals(x, y)) return 0;
                    if (ReferenceEquals(null, y)) return 1;
                    if (ReferenceEquals(null, x)) return -1;
                    return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
                }
            }
            
            // Strategy pattern
            public static IComparer<Person> NameComparer { get; } = new NameRelationComparecer();

            public int CompareTo(Person? other)
            {
                if(ReferenceEquals(this, other)) return 0;
                if(ReferenceEquals(null, other)) return 1;
                return Id.CompareTo(other.Id);
            }
            
            public int CompareTo(object? obj)
            {
               if(ReferenceEquals(this, obj)) return 1;
               if(ReferenceEquals(null, obj)) return 0;
               return obj is Person other 
                   ? CompareTo(other) 
                   : throw new ArgumentException($"Object must be of type {nameof(Person)}");
            }
            
            public static bool operator <(Person left, Person right)
            {
                return Comparer<Person>.Default.Compare(left, right) < 0;
            }
            public static bool operator >(Person left, Person right)
            {
                return Comparer<Person>.Default.Compare(left, right) > 0;
            }
            public static bool operator <=(Person left, Person right)
            {
                return Comparer<Person>.Default.Compare(left, right) <= 0;
            }
            public static bool operator >=(Person left, Person right)
            {
                return Comparer<Person>.Default.Compare(left, right) >= 0;
            }
        }
        public static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person(1, "Paul", 20),
                new Person(2, "Xand", 30),
                new Person(3, "Jack", 40),
                new Person(4, "Lima", 22),
                new Person(5, "Prado", 12),
                new Person(6, "John", 66),
                new Person(7, "Andrew", 39),
            };
            people.Sort(); // default comparing objects using relation operators
            
            // [x] people.Sort((x,y)=> x.Name.CompareTo(y.Name)); 
            
            people.Sort(Person.NameComparer); // using custom comparer
        }
    }
}