<Query Kind="Program" />

void Main()
{
	Graph g = new Graph();
	g.AddVertex("A");
	g.AddVertex("B");
	g.AddVertex("C");
	g.AddVertex("D");
	g.AddVertex("E");
	g.AddVertex("F");
	g.AddVertex("G");
	g.AddVertex("H");
	g.AddVertex("I");
	g.AddVertex("J");
	g.AddVertex("K");
	g.AddVertex("L");
	g.AddVertex("M");
	g.AddEdge(0,1);
	g.AddEdge(1,2);
	g.AddEdge(2,3);
	g.AddEdge(0,4);
	g.AddEdge(4,5);
	g.AddEdge(5,6);
	g.AddEdge(0,7);
	g.AddEdge(7,8);
	g.AddEdge(8,9);
	g.AddEdge(0,10);
	g.AddEdge(10,11);
	g.AddEdge(11,12);
	g.DepthFirstSearch();
	g.PrintRecursiveDFS(0);
	
	
}

public class Vertex
{
	public bool wasVisited;
	public string label;
	
	public Vertex(string label)
	{
		this.label = label;
		wasVisited = false;
	}
}

public class Graph
{
	private const int NUM_VERTICES = 20;
	private Vertex[] vertices;
	private int[,] adjMatrix;
	int numVerts;
	
	public Graph()
	{
		vertices = new Vertex[NUM_VERTICES];
		adjMatrix = new int[NUM_VERTICES,NUM_VERTICES];
		numVerts = 0;		
	}
	
	public void AddVertex(string label)
	{
		vertices[numVerts] = new Vertex(label);
		numVerts++;
	}
	
	public void AddEdge(int start, int end)
	{
		adjMatrix[start,end] = 1;
		adjMatrix[end,start] = 1;
	}
	
	public void ShowVertex(int v)
	{
		Console.Write(vertices[v].label + " ");
	}
	
	//with stack
	public void DepthFirstSearch()
	{
		Stack<int> vertexStack = new Stack<int>();
		vertices[0].wasVisited = true;
		ShowVertex(0);
		vertexStack.Push(0);
		int v;
		while (vertexStack.Count >0)
		{
			v = GetAdjUnvisitedVertex(vertexStack.Peek());
			if(v==-1)
			{
				vertexStack.Pop();
			}
			else
			{
				vertices[v].wasVisited = true;
				ShowVertex(v);
				vertexStack.Push(v);
			}
		}
		
		for(int j = 0; j<=numVerts -1;j++)
		{
			vertices[j].wasVisited = false;
		}
		
	}
	
	public void PrintRecursiveDFS(int v)
	{
		vertices[v].wasVisited = true;
		Console.WriteLine(vertices[v].label);
		for (int i = 0; i < numVerts; i++)
		{
			if(adjMatrix[i,v]>0 && vertices[i].wasVisited==false)
			{
				PrintRecursiveDFS(i);
			}
		}
		
	}
	
	public void BreadthFirstSearch()
	{
		Queue<int> q = new Queue<int>();
		vertices[0].wasVisited = true;
		ShowVertex(0);
		q.Enqueue(0);
		int v1, v2;
		while(q.Count>0)
		{
			v1= q.Dequeue();
			v2 = GetAdjUnvisitedVertex(v1);
			while(v2!=-1)
			{
				vertices[v2].wasVisited = true;
				ShowVertex(v2);
				q.Enqueue(v2);
				v2 = GetAdjUnvisitedVertex(v1);
			}
		}
		
		for (int i = 0; i < numVerts -1; i++)
		{
			vertices[i].wasVisited = false;
		}
		{
			
		}
	}
	
	private int GetAdjUnvisitedVertex(int v)
	{
		for (int j = 0; j <=numVerts -1; j++)
		{
			if(adjMatrix[v,j] ==1 && vertices[j].wasVisited == false)
			{
				return j;
			}
			
		}
		
		return -1;
	}
}

public enum State
{
	Visited,Unvisited,Visiting;
}

// Define other methods and classes here

/* Java version to solve the whether there is a route between two nodes in a graph

package Question4_2;

class Node {
    private Node adjacent[];
    public int adjacentCount;
    private String vertex;
    public Question.State state;
    public Node(String vertex, int adjacentLength) {
        this.vertex = vertex;                
        adjacentCount = 0;        
        adjacent = new Node[adjacentLength];
    }
    
    public void addAdjacent(Node x) {
        if (adjacentCount < 30) {
            this.adjacent[adjacentCount] = x;
            adjacentCount++;
        } else {
            System.out.print("No more adjacent can be added");
        }
    }
    public Node[] getAdjacent() {
        return adjacent;
    }
    public String getVertex() {
        return vertex;
    }
}


public class Graph {
	private Node vertices[];
	public int count;
	public Graph() {
		vertices = new Node[6];
		count = 0;
    }
	
    public void addNode(Node x) {
		if (count < 30) {
			vertices[count] = x;
			count++;
		} else {
			System.out.print("Graph full");
		}
    }
    
    public Node[] getNodes() {
        return vertices;
    }
}

public class Question {
	public enum State {
		Unvisited, Visited, Visiting;
	} 

	public static void main(String a[])
	{
		Graph g = createNewGraph();
		Node[] n = g.getNodes();
		Node start = n[3];
		Node end = n[5];
		System.out.println(search(g, start, end));
	}
	
	public static Graph createNewGraph()
	{
		Graph g = new Graph();        
		Node[] temp = new Node[6];

		temp[0] = new Node("a", 3);
		temp[1] = new Node("b", 0);
		temp[2] = new Node("c", 0);
		temp[3] = new Node("d", 1);
		temp[4] = new Node("e", 1);
		temp[5] = new Node("f", 0);

		temp[0].addAdjacent(temp[1]);
		temp[0].addAdjacent(temp[2]);
		temp[0].addAdjacent(temp[3]);
		temp[3].addAdjacent(temp[4]);
		temp[4].addAdjacent(temp[5]);
		for (int i = 0; i < 6; i++) {
			g.addNode(temp[i]);
		}
		return g;
	}

    public static boolean search(Graph g,Node start,Node end) {  
        LinkedList<Node> q = new LinkedList<Node>();
        for (Node u : g.getNodes()) {
            u.state = State.Unvisited;
        }
        start.state = State.Visiting;
        q.add(start);
        Node u;
        while(!q.isEmpty()) {
            u = q.removeFirst();
            if (u != null) {
	            for (Node v : u.getAdjacent()) {
	                if (v.state == State.Unvisited) {
	                    if (v == end) {
	                        return true;
	                    } else {
	                        v.state = State.Visiting;
	                        q.add(v);
	                    }
	                }
	            }
	            u.state = State.Visited;
            }
        }
        return false;
    }
}

*/