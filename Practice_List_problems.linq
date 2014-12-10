<Query Kind="Program" />

void Main()
{
	int data = 3;
	Node head = new Node(data);
	var tail = head;;
	for (int i = 0; i < 5; i++)
	{
		tail.Next= new Node(i);
		tail = tail.Next;
	}
	
	//Traverse(head);
	//RemoveDuplicates(head);
	//Reverse(head,tail);
	//start = DeleteAll(start);
	//Traverse(start);*/
	 LinkedList L = new LinkedList();
        L.Add(new Node(1));
        L.Add(new Node(2));
        L.Add(new Node(3));
        L.Add(new Node(4));
        L.PrintNodes();
        L.reverse();
        Console.WriteLine("---------------------");
        L.PrintNodes();
        Console.ReadLine();
}

public class LinkedList
{

	Node head;
    Node tail;
    public void Add(Node n)
    {
        if (head == null)
        {
            head = n;
            tail = head;
        }
        else
        {
            tail.Next = n;
            tail = tail.Next;
        }

    }

    public void PrintNodes()
    {
        Node temp = head;

        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.Next;
        }
    }


    private LinkedList p_reverse_recursive(Node first)
    {
        LinkedList ret;
        if (first.Next == null)
        {
            Node aux = createNode(first.data);
            ret = new LinkedList();
            ret.Add(aux);
            return ret;
        }
        else
        {
            ret = p_reverse_recursive(first.Next);
            ret.Add(createNode(first.data));
            return ret;
        }

    }

    private Node createNode(int data)
    {
        Node node = new Node(data);
        return node;
    }
public void reverse()
	{
	recursive_reverse2(tail);
	Node temp = tail;
	tail= head;
	head=temp;
	
	}
	
	public void recursive_reverse2(Node endnode)
	{
		Node temp_head = head;
		if(temp_head==endnode)return;
		while(temp_head!=null)
		{
			if(temp_head.Next==endnode)
			{
			break;
			}
			
			temp_head= temp_head.Next;
		}	
			
			endnode.Next=temp_head;
			temp_head.Next=null;
			recursive_reverse2(temp_head);
		
	}
	
	
    public void reverse_recursive()
    {

        if (head != null)
        {
            LinkedList aux = p_reverse_recursive(head);
            head = aux.head;
            tail = aux.tail;
        }


    }
}
 private static void RemoveDuplicates(Node start)
        {
            while (start.Next != null)
            {
                var val = start.Next.data;
                bool elementAlreadyExists = false;
                var n = start;
                while (n != null && n != start.Next)
                {
                    if (n.data == val)
                    {
                        elementAlreadyExists = true;
                    }

                    n = n.Next;
                }

                if (elementAlreadyExists)
                {
                    start.Next = start.Next.Next;
                }

                start = start.Next;
            }
        }


static Node DeleteAll(Node head)
{
	var temp1 = head;
	var temp2 = temp1;
	while(temp1!=null)
	{
		temp2 = temp1.Next;
		temp1=null;
		temp1= temp2;
	}
	
	return temp1;
}

static void Traverse(Node start)
{
	while(start!=null)
	{
		Console.WriteLine(start.data);
		start = start.Next;
	}
	
	Console.WriteLine("Nothing to display");
}

// Define other methods and classes here