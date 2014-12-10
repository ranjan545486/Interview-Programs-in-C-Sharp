<Query Kind="Program" />

void Main()
{
  var text = "aabbccdefg";
  var pattern = "cd";
  int c = KMP.Kmp(text,pattern);
  c.Dump();
}

// KMP Algorithm

public class KMP
{
 	private static int[] PrefixTable(string pattern)
{
    //We will calculate the longest prefix of 0->ip that is also a prefix of the pattern
 
    var np = pattern.Length;
    var prefixtable = new int[np];
 
    var ip = 2;
    var k = 0;
 
    while (true)
    {
        if (ip >= np)  //We have shifted out of our pattern, we are done.
            break;
        if (pattern[k] == pattern[ip - 1])//Our prefix extends
        {
            prefixtable[ip] = (k + 1);
            ip++;
            k++;
            continue;
        }
        if (k > 0)//We have a mismatch, so we need to see if we have a smaller prefix that we can use
                  //We already calculated this, so just get it.
        {
            k = prefixtable[ip];
            continue;
        }
        //We have a mismatch, but K = 0, so we dont have a prefix.
        prefixtable[ip] = 0;
        ip++;
    }
    prefixtable[np - 1] = k;
    prefixtable[0] = -1;
    return prefixtable;
}

	
	public static int Kmp(string text, string pattern)
       {
           var nt = text.Length;
           var np = pattern.Length;
           var prefixtable = PrefixTable(pattern);
 
           var it = 0;
           var ip = 0;
 
           //We will keep looping, untill
           //-->We have found a match (ip > (np -1)
           //--> We have shifted out of our text, not found (it > (nt -np))
           //We have match, step forward in the pattern!
           //We have a mismatch, jump back as much as the sigmatable tells us.
 
           while (true)
           {
               if (ip > (np - 1))
               {
                   return it;
               }
               if (it > (nt - np))
               {
                   return -1;
               }
               if (text[it + ip] == pattern[ip])
               {
                   ip++;
                   continue;
               }
               it = (it + (ip - prefixtable[ip]));
               ip = ip > 0 ? prefixtable[ip] : 0;
           }
       }

}