namespace GenericBoxOfString;

public class Box<T>
{
    private List<T> box;

    public Box()
    {
        this.box = new List<T>();
    }

    public void Add(T element)
    {
        this.box.Add(element);
    }

    public void Clear()
    {
        this.box.Clear();
    }

    public override string ToString()
    {
        return $"{typeof(T)}: {string.Join(" ", box)}";
    }
}