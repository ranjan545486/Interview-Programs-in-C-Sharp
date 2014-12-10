<Query Kind="Program" />

void Main()
{
	string test = "aabbccccddaaa";
	string output = "";
		int count = 1;
		test = test + " ";
		for (int i = 0; i < test.Length - 1; i++)
		{
			if (count == 1)
				output = output + test[i];
			if (test[i + 1] == test[i])
			{
				count++;
				continue;
			}
			output = output + count;
			count = 1;
		}
	output.Dump();

}

// Define other methods and classes here
