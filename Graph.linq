<Query Kind="Program" />

void Main()
{
	
}

public class Vertex
{
	public bool IsVisited;
	public string label;
	
	public Vertex(string label)
	{
		this.label = label;
		this.IsVisited = false;
	}
}

public class Graph
{
	private const int NumberOfVertices = 20;
	private Vertex[] vertices;
	private int[,] adjMatrix;
	int numVerts;
	
	public Graph()
	{
		vertices = new Vertex[NumberOfVertices];
		adjMatrix = new int[NumberOfVertices, NumberOfVertices];
		numVerts = 0;
		for (int j= 0; j < NumberOfVertices; j++)
		{
			for (int k = 0; k < NumberOfVertices - 1; k++)
			{
				adjMatrix[j,k] = 0;
			}
		}
	}
	
	public void AddVertex(string label)
	{
		vertices[numVerts] = new Vertex(label);
		numVerts++;
	}
	
	public void AddEdge(int start , int end)
	{
		adjMatrix[start,end] = 1;
		adjMatrix[end,start] = 1;		
	}
	
	public void ShowVertex(int v)
	{
		Console.Write(vertices[v].label + "");
	}
	
}


// Define other methods and classes here