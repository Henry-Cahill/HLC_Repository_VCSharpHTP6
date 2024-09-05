//Figure 4.6: Account.cs
//Account class that replaces public methods SetName
// and GetName with a public Name property.
class Account
{
	private string name; // instance variable
	
	public string Name
	{
		get // returns the corresponding instance variable's value
		{
			return name; // returns the value of the name to the client code
		}
		set // assigns a value to the corresponding instance variable
		{
			name = value; // value is implicitly declared and initialized
		}
	}
}
