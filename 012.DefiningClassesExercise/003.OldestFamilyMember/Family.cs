namespace DefiningClasses;

public class Family
{
    private List<Person> people;

    public List<Person> People { get; set; }

    public Family()
    {
        this.People = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.People.Add(member);
    }

    public Person GetOldestMember()
    {
        Person person = People.OrderByDescending(p => p.Age).First();

        return person;
    }
}