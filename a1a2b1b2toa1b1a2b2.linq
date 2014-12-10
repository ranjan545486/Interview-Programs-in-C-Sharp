<Query Kind="Program" />

void Main()
{
	string[] a = new string[] {"a1","a2","a3","a4","a5","b1","b2","b3","b4","b5"};
	reshuffler r = new reshuffler();
	r.reshuffle(a,0,a.Length);
}

// a1a2a3a4b1b2b3b4=> a1b1a2b2a3b3a4b4

public class reshuffler
{
	 public void reshuffle(string[] a, int low, int high)
        {
            int mid = (low + high) / 2;
            string[] tempa = new string[mid];
            string[] tempb = new string[mid];
            for (int i = 0; i < mid; i++)
            {
                tempa[i] = a[i];
            }

            for (int i = 0,j=mid; i <mid; i++,j++)
            {
                tempb[i] = a[j];
            }

            a[0] = tempa[0];
            a[1] = tempb[0];
            for (int i = 2,j = 1; j < tempb.Length; i=i+2,j++)
            {
                a[i] = tempa[j];
                a[i + 1] = tempb[j];
            }
			
			a.Dump();	 
        }
	  
	   
	
}
