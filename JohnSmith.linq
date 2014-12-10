<Query Kind="Program" />

void Main()
{
   ReplaceStringWithPercent20 per20 = new ReplaceStringWithPercent20();
   
	string str = "Mr John Smith";
	str = str.Replace(" ","%20");
	str.Dump();
	//per20.ReplaceSpaces(str.ToCharArray());
	
}


public class ReplaceStringWithPercent20
{
 public void ReplaceSpaces(char[] chararray)
	{
		int spaceCount = 0;
		int newlength = 0;
		for(int i =0; i<chararray.Length;i++)
		{
			if(chararray[i] == ' ')
			{
				spaceCount++;
			}
		}
		
		newlength = chararray.Length+spaceCount*2;
		for(int i = chararray.Length-1;i>=0;i--)
		{
		 if(chararray[i] ==' ')
		 {
		 	chararray[newlength -1] = '0';
		 	chararray[newlength -1] = '2';
		 	chararray[newlength -1] = '%';
			newlength = newlength - 3;		
		 }
		 else
		 {
		 	chararray[newlength -1] = chararray[i];
			newlength = newlength - 1;
		 }
		 
		}
		
		chararray.Dump();
		
		
	}
}
// Define other methods and classes here
