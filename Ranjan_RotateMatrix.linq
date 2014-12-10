<Query Kind="Program" />

void Main()
{
	int[,] a = new int[,] {
							{1,2,3,4},
							{5,6,7,8},
							{9,10,11,12},
							{13,14,15,16}
						  };
	matrixRotation(a).Dump();
}

 public void rearrange(int[,] temp1, int[,] a, int tempLength, int i, int j)
        {
           temp1[i,j] = a[tempLength, i];
        }
        public int[,] matrixRotation(int[,] a)
        {
            int length = a.GetLength(0);            
            var temp1 = new int[length, length];
                      
            for (int i = 0; i < length; i++)
            {
                int j = 0;
                var tempLength = length - 1;            
                while (tempLength >= 0 && j<length)
                {
                    rearrange(temp1, a, tempLength, i,j);
                    tempLength = tempLength - 1;
                    j++;                    
                }		
            }           

            return temp1;
        }

/*public void rearrange(int[,] temp1, int[,] a, int tempLength, int i)
{
	temp1[i,tempLength] = a[tempLength,i];
}
public int[,] matrixRotation(int[,] a)
{
 	int length = a.GetLength(0);
	length.Dump();
	var temp1 = new int[length,length];
	var prev1 = new int[length];
	
	for (int i = 0; i < length; i++)
	{
	 var tempLength = length;
                while (tempLength > 0)
                {
                    tempLength = tempLength - 1;
                    rearrange(temp1, a, tempLength, i);
                }
	  	 
		//b1[i] = a[1,i];
		//c1[i] = a[0,i];			
	}
	
	for (int j = 0; j <= length; j++)
		{
	    	//a[j,0]=  a1[j];
			//a[j,1] = b1[j];
			//a[j,2] = c1[j];
		}
	
	return temp1;
}*/

// matrix rotation
// 123
// 456
// 789 should become as 
/*  741
    852
    963 */