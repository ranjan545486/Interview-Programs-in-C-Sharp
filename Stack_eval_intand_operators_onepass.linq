<Query Kind="Program" />

void Main()
{
		string expression = "3 * 2 + 5 * 6 + 0";
		Stack<Operator> operator1 = new Stack<Operator>();
		Stack<int> operand = new Stack<int>();

		for (int i = 0; i < expression.Length; i++) {
			char k = expression[i];
			if (k == ' ') {
				continue;
			}
			try {
				var opr = Operator.getOperarorForSign(k);				
				if (operator1.Count!=0) 
				{
					while (operator1.Count !=0	&& (opr.getPriority() <= operator1.Peek().getPriority())) 
					{
						// postfix += stack.pop().getSign();
						operand.Push(Operator.Execute(operator1.Pop(),
								operand.Pop(), operand.Pop()));
					}
				}
				operator1.Push(opr);
				
			} catch {
				operand.Push(int.Parse("" + k));
			}
		}
		if (operator1.Count == 1) {
			// postfix += stack.pop().getSign();
			operand.Push(Operator.Execute(operator1.Pop(), operand.Pop(),
					operand.Pop()));
		}
		Console.WriteLine(expression + " = " + operand.Peek());	
}

public class Operator 
{		 
	public string Operation {get;set;}
	public char Symbol {get; set;}
	public int Priority {get; set;}
	

	public Operator(string operation, char symbol, int priority)
	{
		this.Operation= operation;
		this.Symbol = symbol;
		this.Priority = priority;
	}
	
	public static IEnumerable<Operator> Values
    {
            get
            {
                yield return ADDITION;
                yield return SUBTRACTION;
                yield return MUL;
                yield return DIV;                
            }
    }
		
	public static readonly Operator ADDITION = new Operator("Addition", '+', 1);
    public static readonly Operator SUBTRACTION = new Operator("Subtraction", '-', 0);
    public static readonly Operator MUL = new Operator("Mul", '*', 3);
    public static readonly Operator DIV = new Operator("Div", '/', 2);
		
	public static Operator getOperarorForSign(char sign)
		{
			foreach (var opr in Operator.Values)
			{
				if(opr.Symbol == sign)
				{
					return opr;
				}
			}
			
			throw new ArgumentException();
		}    

	public int getPriority() {
			return this.Priority;
		}

	public char getSign() {
			return this.Symbol;
		}
		
	public static int Execute(Operator opr, int b, int a) {
		switch (opr.Operation) {
		case "Addition":
			return a + b;
		case "Subtraction":
			return a - b;
		case "Mul":
			return a * b;
		case "Div":
			return a / b;
		default:
			return 0;
		}
	}
}

// Define other methods and classes here
probald@cybage.com