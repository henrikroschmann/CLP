namespace CommandLineParser.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ArgumentAttribute : Attribute
{
	private string name;
	public string key;
	private string description;

	public ArgumentAttribute(string Name, string Key, string Description)
	{
		name = Name;
		key = Key;
		description = Description;
	}
}