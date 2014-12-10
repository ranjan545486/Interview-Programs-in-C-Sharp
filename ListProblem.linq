<Query Kind="Program" />


   static void Main(string[] args)
        {
            List<string> first1 = new List<string>();
            List<string> first2 = new List<string>();
            List<List<string>> second = new List<List<string>>();
            first1.Add("abc");
            first1.Add("def");
            first2.Add("xyz");
            first2.Add("pqr");
            first2.Add("shrikl");
            		
            second.Add(first1);
            second.Add(first2);
            string c = string.Empty;
            //second.Dump();
            Enumba eb = new Enumba(second);
            if (eb.HasNext())
            {
                c = eb.GetNext();
                c.Dump();
            }
        }
  


public class Enumba
{
   List<List<string>> outer = new List<List<string>>();
   StringBuilder s = new StringBuilder();  
   
	public Enumba(List<List<string>> input)
	{
		this.outer = input;
	}
	
	 public bool HasNext()
        {
            var p = outer.ToArray();
            var z = p.Select(x => x.ToArray()).ToArray();            
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i].Length > 0)
                {
                    return true;                    
                }
                
            }

            return false;

        }

        public string GetNext()
        {
            var p = outer.ToArray();
            var z = p.Select(x => x.ToArray()).ToArray();
            string output = string.Empty;
            int j = 0;
            for (int i = 0; i < z.GetLength(0); i++)
            {
                string[] innerarry = z[i];
                for (j=0; j < innerarry.GetLength(0);)
                {
                    if (j < z.GetLength(0))
                    {
                        output += z[j][i];                        
                    }
                    else
                    {
                        output += z[i][j];
                    }

                    j++;
                }
            }

            return output;
        }

	
}

// Define other methods and classes here
