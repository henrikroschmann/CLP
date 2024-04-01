namespace CommandLineParser.Attributes;


[AttributeUsage(AttributeTargets.Property)]
public class Argument : Attribute
{
    private string name;
    public string key;
    private string description;

    public Argument(string Name, string Key, string Description)
    {
        name = Name;
        key = Key;
        description = Description;
    }
}