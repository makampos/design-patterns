namespace dependency.inversion.principle;

public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}