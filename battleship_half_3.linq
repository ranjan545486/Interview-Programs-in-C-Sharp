<Query Kind="Program" />

void Main()
{
	
}

// BattleshipCode

public class Ship
{
	private List<string> Location = new List<string>();
	private string Name;
	private int Size;
	
	public Ship(string name, int size)
	{
		this.Name = name;
		this.Size = size;
	}
	
	public List<string> Location{ 
	get;
	set;
	}
	
	public int GetSize{get;}
	
	public string Check(string guess)
	{
		string result = "miss";
		if(Location.Contains(guess))
		{
			Location.Remove(guess);
		
		result = Location.Count == 0 ? "sink":"hit";
		}
		
		return result;
		
	}
	
	
}
